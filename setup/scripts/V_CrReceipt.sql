/****** Object:  View [dbo].[v_CrReceipt]    Script Date: 7/8/2015 8:44:04 AM ******/
IF OBJECT_ID('dbo.v_crreceipt', 'V') IS NOT NULL
	DROP VIEW [dbo].[v_CrReceipt];
GO

/****** Object:  View [dbo].[v_CrReceipt]    Script Date: 7/8/2015 8:44:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_CrReceipt]
AS
SELECT        m.Id, m.DeliveryName AS mDeliveryName, m.Amount AS mAmount, m.PayRef AS mPayRef, m.PayType AS mPayType, m.PayVia AS mPayVia, m.Note AS mnote, d.Account AS dAccount, d.Name AS dName, 
                         d.Amount AS dAmount, d.Note AS dnote, m.RcptID AS mRcptID, m.CDate AS mCreatedOn, d.Type AS dType
FROM            dbo.CRMaster AS m INNER JOIN
                         dbo.CRDetail AS d ON m.Id = d.CRMid

GO

