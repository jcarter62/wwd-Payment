SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

/* 44525E0F12FE416F85B218AA46A25253 */
ALTER PROCEDURE [dbo].[sp_Recmst_Post]
  (@iv_BatchID int,
   @ov_Done int output,
   @ov_Error int output,
   @ov_ErrorMsg Varchar(80) output )
AS

/*********************************************************************************************/
/*    Name:          sp_Recmst_Post                                                          */
/*    InPut Params:  @iv_batchID                                                             */
/*    OutPut Params: @ov_Done                                                                */
/*    Description:   Post Records setup in Recmst.pas                                        */
/*    Coded:         J.C.                                                                    */
/*    Use In:        Recmst.pas                                                              */
/*    Date Created:  10/21/99                                                                */
/*                                                                                           */
/*    Modified:                                                                              */
/*    01/14/14 L.G. Updated syntax for SQL Server 2008 compatibility                         */
/*    08/10/15 JC Added CrMaster, CrDetail & TblLog updates                                  */
/*********************************************************************************************/
DECLARE
 @Er_Flag int,
 @Next_Tranid int,
 @Next_Armstid int,
 @tmp_count int,
 @Unapplied_Credits_Count int,
 @Unapplied_Payments_Count int

SELECT @Er_Flag = 0,
       @ov_Error = 0,
       @ov_ErrorMsg = 'OK'


declare @Save_Error int
      , @Save_Count int
                       
select  @Save_Error = 0
      , @Save_Count = 0

BEGIN
/* Create #TempPostRec2 Table for later use */
    create table #TempPostRec2
         ( SEQ            int            identity(1,1)
         , BatchID        int            null 
         , Name_ID        int            null
         , ActionDate     datetime       null
         , CurrAmount     float          null
         , ArmstID        int            null
         , credit_CR      varchar(20)    null
         , Credit_DB      varchar(20)    null
         )

/* Create #TempPostRec3 Table for later use */
    create table #TempPostRec3
         ( Seq                int           Identity(1,1)
         , ArmstID            int           null
         , Name_ID            int           null
         , ActionDate         datetime      null
         , BillingType_ID     varchar(6)    null
         , OrigAmount         float         null
         , CurrAmount         float         null
         , TransType          varchar(3)    null
         , Credit_cr          varchar(20)   null
         , Credit_db          varchar(20)   null
         )


  /* Create #TempPostRec10 and #TempPostRec11 Table for later use */
    SELECT 
         m.ActionDate
       , m.ArmstID
       , m.Name_ID
       , m.TransType
       , m.editarmstid 
       , m.editarmstid as l_armstid
    INTO #TempPostRec10
    FROM Armst m 
   Where m.BatchID =  @iv_BatchID

   create table #TempPostRec1                             -- Used later, within transaction
        ( SEQ                int            Identity(1,1) -- Same structure as #TempPostRec11
        , TranID             int            null
        , EditApplied        float          null
        , Invoice_No         int            null
        , Cash_cr            varchar(20)    null
        , Cash_db            varchar(20)    null
        , Bill_cr            varchar(20)    null
        , Bill_db            varchar(20)    null
        , ActionDate         datetime       null
        , ArmstID            int            null
        , Name_ID            int            null
        , TransType          varchar(3)     null
        , editarmstid        int            null
        , l_armstid          int            null
        ) 

   create table #TempPostRec11
        ( SEQ                int            Identity(1,1)
        , TranID             int            null
        , EditApplied        float          null
        , Invoice_No         int            null
        , Cash_cr            varchar(20)    null
        , Cash_db            varchar(20)    null
        , Bill_cr            varchar(20)    null
        , Bill_db            varchar(20)    null
        , ActionDate         datetime       null
        , ArmstID            int            null
        , Name_ID            int            null
        , TransType          varchar(3)     null
        , editarmstid        int            null
        , l_armstid          int            null
        ) 

  insert into #TempPostRec11
         ( TranID
         , EditApplied
         , Invoice_No
         , Cash_cr
         , Cash_db
         , Bill_cr
         , Bill_db
         , ActionDate
         , ArmstID
         , Name_ID
         , TransType
         , editarmstid
         , l_armstid
         )
    select d.TranID
         , d.EditApplied
         , d.Invoice_No
         , d.Cash_cr
         , d.Cash_db
         , d.Bill_cr
         , d.Bill_db
         , t.ActionDate
         , t.ArmstID
         , t.Name_ID
         , t.TransType
         , t.editarmstid
         , t.l_armstid
      FROM #TempPostRec10 t left outer join Ardtl d 
        ON t.l_armstid = d.armstid


   TRUNCATE TABLE #TempPostRec10
   TRUNCATE TABLE #TempPostRec11


   
/* First, Get list of ArDtl records we need to create...  */
  SELECT 
         m.ActionDate
       , m.ArmstID
       , m.Name_ID
       , m.TransType
       , l.editarmstid
       , l.armstid as l_armstid

    INTO #TempPostRec0

  FROM Armst m -- with ( index = byBatch)
  left outer join Armst l -- with ( index = byEditArmstID)   
    ON m.armstid = l.editarmstid
 Where m.BatchID =  @iv_BatchID


  Select @Save_Count = 0



-- Table is created outside of the transaction...
  insert into #TempPostRec1
         ( TranID
         , EditApplied
         , Invoice_No
         , Cash_cr
         , Cash_db
         , Bill_cr
         , Bill_db
         , ActionDate
         , ArmstID
         , Name_ID
         , TransType
         , editarmstid
         , l_armstid
         )
    select d.TranID
         , d.EditApplied
         , d.Invoice_No
         , d.Cash_cr
         , d.Cash_db
         , d.Bill_cr
         , d.Bill_db
         , t.ActionDate
         , t.ArmstID
         , t.Name_ID
         , t.TransType
         , t.editarmstid
         , t.l_armstid
      FROM #TempPostRec0 t left outer join Ardtl d 
        on t.l_armstid = d.armstid
       and round(d.EditApplied,2) <> 0

    select @Save_Error = @@Error
         , @Save_Count = @@RowCount 

      IF ( @Save_Error > 0 ) 
        SELECT @Er_Flag     = 1,
               @ov_ErrorMsg = 'Creating List of New Detail Records.'
      ELSE
        SELECT @tmp_count = COUNT(*) FROM #TempPostRec1



/*  Get last ArDtl tranid currently in use - will be added to sequence that starts with 1... */


  IF ( @Er_Flag = 0 ) 
  BEGIN 
    SELECT @Next_Tranid = MAX(tranid) FROM ardtl

    select @Save_Error = @@Error
         , @Save_Count = @@RowCount 

        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 2,
                 @ov_ErrorMsg = 'Get Last Used Tranid.'

  END



/*  Create NEW ArDtl records based on #TempPostRec1                                          */  
  /****************/
  BEGIN TRANSACTION
  /****************/

  IF ( @Er_Flag = 0 ) 
  BEGIN
    IF @tmp_count > 0 
    BEGIN

      INSERT INTO Ardtl
      (
        TranID,RelatedTranID,OrigAmount,Invoice_No,Cash_cr,Cash_db,Bill_cr,
        Bill_db,ActionDate,ArmstID,Name_ID,BillingType_ID,CurrAmount,TransType,
        Posted,NoShow)
      SELECT
             Seq+@Next_Tranid
           , TranID
           ,-EditApplied
           , Invoice_No
           , Cash_cr
           , Cash_db
           , Bill_cr
           , Bill_db 
           , ActionDate
           , ArmstID
           , Name_ID
           , TransType
           , 0
           , 'REC' 
           , 1
           , 0
        FROM #TempPostRec1

      select @Save_Error = @@Error
           , @Save_Count = @@RowCount 

          IF ( @Save_Error > 0 ) 
            SELECT @Er_Flag     = 3,
                   @ov_ErrorMsg = 'Insert New Ardtl Records.'


/* Count new ArDtl records inserted... */
      IF ( @Er_Flag <= 0 ) 
      BEGIN

        SELECT @tmp_count = COUNT(Tranid) FROM Ardtl
          WHERE  Tranid > @Next_Tranid

              IF @tmp_count <= 0     
                SELECT @Er_Flag     = 103,
                       @ov_ErrorMsg = 'Insert New Ardtl Records (No Records Found)'

      END
    END  --  IF @tmp_count > 0  
  END    --  If Er_Flag = 0





/* Update CurrAmount in Armst */
  IF ( @Er_Flag = 0 ) 
  BEGIN
    Update Armst set CurrAmount = 
       CurrAmount + 
       isnull(( SELECT SUM(ROUND(l.EditApplied,2)) 
                FROM Armst l -- with ( index=byEditArMstID)
                Where l.EditArmstID = Armst.ArmstID

              ),0)
       where Armst.BatchID = @iv_batchid

   select @Save_Error = @@Error
        , @Save_Count = @@RowCount 

          IF ( @Save_Count <= 0 ) 
            SELECT @Er_Flag     = 104,
                   @ov_ErrorMsg = 'Update Armst.Curramount (No Records Found)'
          ELSE
          IF ( @Save_Error > 0 ) 
            SELECT @Er_Flag     = 4,
                   @ov_ErrorMsg = 'Update Armst.Curramount .'

  END






/* Get last armstid currently in use...                                                      */
  IF ( @Er_Flag = 0 ) 
  BEGIN

    SELECT @Next_Armstid = MAX(armstid) FROM armst

    select @Save_Error = @@Error
         , @Save_Count = @@RowCount 

        IF ( @Save_Count <= 0 ) 
          SELECT @Er_Flag     = 105,
                 @ov_ErrorMsg = 'Get Last Used Armstid (No Records Found)'
        ELSE
        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 5,
                 @ov_ErrorMsg = 'Get Last Used Armstid.'

  END






/* Insert data from Armst for this batch with negative CurrAmounts into TempPostRec2 ...     */
  IF ( @Er_Flag = 0 ) 
  BEGIN

    INSERT INTO #TempPostRec2
    SELECT 
      BatchID, Name_ID, ActionDate, CurrAmount,
      ArmstID, credit_CR, Credit_DB
    From Armst
    where 
      ( BatchID = @iv_Batchid ) and
      ( round(CurrAmount,2) < 0 )

      select @Save_Error = @@Error
           , @Save_Count = @@RowCount 

        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 6,
                 @ov_ErrorMsg = 'Creating Unapplied Payment Credits(1).'


/* Count unapplied credits ...                                                               */
    SELECT @Unapplied_Credits_Count = ISNULL(COUNT(*),0) FROM #TempPostRec2

  END  -- if Er_Flag = 0






/* Insert unapplied credits into Armst ...                                                   */
  IF ( @Er_Flag = 0 )  AND ( @Unapplied_Credits_Count > 0 )
  BEGIN

    INSERT INTO Armst
    ( 
      ArmstID,BatchID,Name_ID,ActionDate,OrigAmount,CurrAmount,ReceiptID,
      Credit_CR,Credit_DB,BillingType_ID,TransType,Description,PostDate,Posted
    )

    SELECT
      Seq+@Next_ArmstID,BatchID,Name_ID,ActionDate,CurrAmount,CurrAmount,ArmstID,
      Credit_cr,Credit_db,'REC','CR','Credit',GetDate(),1

    FROM #TempPostRec2

    select @Save_Error = @@Error
         , @Save_Count = @@RowCount 

        IF ( @Save_Count <= 0 ) 
          SELECT @Er_Flag     = 107,
                 @ov_ErrorMsg = 'Creating Unapplied Payment Credits.(No Records Found)(2)'
        ELSE

        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 7,
                 @ov_ErrorMsg = 'Creating Unapplied Payment Credits(2).'

  END




/* Load TempPostRec3 with data from Armst from this batch with transtype = 'CR' ...          */
  IF ( @Er_Flag = 0 ) 
  BEGIN

    INSERT INTO #TempPostRec3
    SELECT
      ArmstID,Name_ID,ActionDate,BillingType_ID,
      OrigAmount,CurrAmount,TransType,Credit_cr,Credit_db

    From Armst

    where 
      ( BatchID = @iv_Batchid ) and
      ( TransType = 'CR' )

    select @Save_Error = @@Error
         , @Save_Count = @@RowCount 

        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 8,
                 @ov_ErrorMsg = 'Creating Unapplied Payment Credits(3).'



/* Count unapplied payment credits (results of previous section ...                          */
    SELECT @Unapplied_Payments_Count = ISNULL(COUNT(*),0) FROM #TempPostRec3

  END






/* If there are unapplied payments, get the next ArDtl transid... */
  IF ( @Er_Flag = 0 ) AND ( @Unapplied_Payments_Count > 0 )
  BEGIN
  
    SELECT @Next_TranID = Max(TranID) FROM Ardtl


/* Use that tranid to insert records into ArDtl...                                           */
    INSERT INTO Ardtl
    (
      TranID,ARMstID,NAME_ID,ActionDate,BillingType_ID,OrigAmount,CurrAmount,
      TransType,Cash_CR,Cash_DB,Posted
    )

    SELECT
      Seq+@Next_TranID,ARMstID,NAME_ID,ActionDate,BillingType_ID,OrigAmount,CurrAmount,
      TransType,Credit_CR,Credit_DB,1

    FROM #TempPostRec3

    select @Save_Error = @@Error
         , @Save_Count = @@RowCount 

        IF ( @Save_Count <= 0 ) 

          SELECT @Er_Flag     = 109,
                 @ov_ErrorMsg = 'Creating Unapplied Payment Credits.(No Records Found)(3)'
        ELSE
        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 9,
                 @ov_ErrorMsg = 'Creating Unapplied Payment Credits(3).'

  END






/* Set Curramount to zero; set posted and post date for TransType other than 'CR'            */
  IF ( @Er_Flag = 0 ) 
  BEGIN

    Update Armst set CurrAmount = 0,Posted = 1, PostDate = GetDate()
    Where 
      ( BatchID = @iv_batchid ) and 
      ( TransType<>'CR' )

    select @Save_Error = @@Error
         , @Save_Count = @@RowCount 

        IF ( @Save_Count <= 0 ) 
          SELECT @Er_Flag     = 110,
                 @ov_ErrorMsg = 'Updating Open Amounts (Armst).(No Records Found)'
        ELSE
        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 10,
                 @ov_ErrorMsg = 'Updating Open Amounts (Armst).'

  END




/* Update ArDtl records...                                                                   */
  IF ( @Er_Flag = 0 ) 
  BEGIN

  INSERT INTO #TempPostRec10
  SELECT 
         m.ActionDate
       , m.ArmstID
       , m.Name_ID
       , m.TransType
       , l.editarmstid             -- added
       , l.armstid as l_armstid    -- added

    FROM Armst m -- with ( index = byBatch)
    left outer join Armst l -- with ( index = byEditArmstID)   
      ON m.armstid = l.editarmstid
   Where m.BatchID =  @iv_BatchID

   select @tmp_count = count(*) from #TempPostRec10
 

  INSERT INTO #TempPostRec11
  SELECT 
         d.TranID
       , d.EditApplied
       , d.Invoice_No
       , d.Cash_cr
       , d.Cash_db
       , d.Bill_cr
       , d.Bill_db
       , t.ActionDate
       , t.ArmstID
       , t.Name_ID
       , t.TransType
       , t.editarmstid            -- added

       , t.l_armstid              -- added

    FROM #TempPostRec10 t left outer join Ardtl d 
      ON t.l_armstid = d.armstid
     and round(d.EditApplied,2) <> 0 

   select @Save_Error = @@Error
        , @Save_Count = @@RowCount 

   declare @Armstid int
   declare Armstid_Cursor cursor for
    select distinct l_Armstid 
      from #TempPostRec11
     where l_Armstid is not null
     order by l_Armstid

   open Armstid_Cursor
   fetch next from Armstid_Cursor into @Armstid

   while @@Fetch_Status = 0
   begin 

     Update Ardtl 
     SET 
      Ardtl.CurrAmount = round(Ardtl.CurrAmount - isnull(Ardtl.EditApplied,0),2)
    , Ardtl.EditApplied = Null
    , Ardtl.EditArmstID = null
    WHERE Ardtl.ArmstID = @Armstid

     fetch next from Armstid_Cursor into @Armstid

   end
   deallocate Armstid_Cursor


   select @Save_Error = @@Error
        , @Save_Count = @@RowCount 

        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 11,
                 @ov_ErrorMsg = 'Updating Open Amounts (Ardtl).'

  END






/* Update Armst...                                                                           */
  IF ( @Er_Flag = 0 ) 
  BEGIN

/* This updates Armst off what appears to be the same data as used for ArDtl above.
   However, this seems to perform, so it has been left alone.  */
    Update Armst 
    set 
      Armst.CurrAmount = round(Armst.CurrAmount - isnull(Armst.EditApplied,0),2),
      Armst.EditApplied = Null,Armst.EditArmstID = null
    from Armst m join Armst -- with ( INDEX=byEditArmstID)
      on m.armstid = armst.editarmstid
    Where m.BatchID = @iv_batchid

   select @Save_Error = @@Error
        , @Save_Count = @@RowCount 

        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 12,
                 @ov_ErrorMsg = 'Updating Payment Open Amounts (Armst).'

  END

/* Update Batches...  */
  IF ( @Er_Flag = 0 ) 
  BEGIN

    Update Batches

    SET 
      Posted = 1, 
      DatePosted = getdate(), 
      CurrentUser = NULL
    Where BatchID = @iv_batchid

    select @Save_Error = @@Error
         , @Save_Count = @@RowCount 

        IF ( @Save_Count <= 0 ) 
          SELECT @Er_Flag     = 113,
                 @ov_ErrorMsg = 'Updating Batches Table.(No Records Found)'
        ELSE
        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 13,
                 @ov_ErrorMsg = 'Updating Batches Table.'

  END

/* CrMaster, CrDetail, TblLog ... */
if ( @Er_Flag = 0)
begin
	BEGIN TRY
		/* Create Lists of Id values */
		select ARMSTID into #ArMstList
		from armst m 
		where m.BatchID = @iv_BatchID;

		select distinct c.CrMid into #CrMasterList
		from #ArMstList m 
		inner join CrArMst c on m.ARMSTID = c.ArMstId

		select distinct c.CrDid into #CrDetailList
		from #ArMstList m 
		inner join CrArMst c on m.ARMSTID = c.ArMstId

		/* Update CrMaster.StateAr = posted */
		update CRMaster
		set StateAR = 'posted'
		from CRMaster m
		inner join #CrMasterList t on m.id = t.CrMid;

		/* Log it */
		insert into TblLog ( tblId, tblName, txt ) 
		select m.id, 'crmaster', 'ar post'
		from CRMaster m 
		inner join #CrMasterList t on m.id = t.CrMid;

		/* Update CrDetail.State = posted */
		update CRDetail 
		set State = 'posted'
		from CRDetail d
		inner join #CrDetailList t on d.id = t.CrDid;

		drop table #CrMasterList;
		drop table #CrDetailList;
		drop table #ArMstList;
	END TRY
	BEGIN CATCH
		set @Er_Flag = 200;
		set @ov_ErrorMsg = 'CrMaster, CrDetail or TblLog Update Failed';
	END CATCH;
end

/* End the transaction, one way or the other...                                              */
  SELECT @ov_Error = @Er_Flag

  IF ( @Er_Flag <> 0 ) 
    ROLLBACK TRAN
  ELSE
  BEGIN
    COMMIT TRAN

    select @Save_Error = @@Error

        IF ( @Save_Error > 0 ) 
          SELECT @Er_Flag     = 14,
                 @ov_ErrorMsg = 'Commit Transaction.'
  END

  DROP TABLE #TempPostRec0
  DROP TABLE #TempPostRec1
  DROP TABLE #TempPostRec2
  Drop Table #TempPostRec3
  DROP TABLE #TempPostRec10
  DROP TABLE #TempPostRec11
  
END

