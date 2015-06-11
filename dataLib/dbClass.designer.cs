﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dataLib
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="testdb")]
	public partial class dbClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCRMasterId(CRMasterId instance);
    partial void UpdateCRMasterId(CRMasterId instance);
    partial void DeleteCRMasterId(CRMasterId instance);
    partial void InsertCRMaster(CRMaster instance);
    partial void UpdateCRMaster(CRMaster instance);
    partial void DeleteCRMaster(CRMaster instance);
    partial void InsertCRAccount(CRAccount instance);
    partial void UpdateCRAccount(CRAccount instance);
    partial void DeleteCRAccount(CRAccount instance);
    partial void InsertCRDetail(CRDetail instance);
    partial void UpdateCRDetail(CRDetail instance);
    partial void DeleteCRDetail(CRDetail instance);
    #endregion
		
		public dbClassDataContext() : 
				base(global::dataLib.Properties.Settings.Default.testdbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CRMasterId> CRMasterIds
		{
			get
			{
				return this.GetTable<CRMasterId>();
			}
		}
		
		public System.Data.Linq.Table<CRMaster> CRMasters
		{
			get
			{
				return this.GetTable<CRMaster>();
			}
		}
		
		public System.Data.Linq.Table<CRAccount> CRAccounts
		{
			get
			{
				return this.GetTable<CRAccount>();
			}
		}
		
		public System.Data.Linq.Table<NAME> NAMEs
		{
			get
			{
				return this.GetTable<NAME>();
			}
		}
		
		public System.Data.Linq.Table<CRDetail> CRDetails
		{
			get
			{
				return this.GetTable<CRDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CRMasterId")]
	public partial class CRMasterId : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _RcptId;
		
		private System.Nullable<System.DateTime> _CDate;
		
		private string _CUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnRcptIdChanging(string value);
    partial void OnRcptIdChanged();
    partial void OnCDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCDateChanged();
    partial void OnCUserChanging(string value);
    partial void OnCUserChanged();
    #endregion
		
		public CRMasterId()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RcptId", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string RcptId
		{
			get
			{
				return this._RcptId;
			}
			set
			{
				if ((this._RcptId != value))
				{
					this.OnRcptIdChanging(value);
					this.SendPropertyChanging();
					this._RcptId = value;
					this.SendPropertyChanged("RcptId");
					this.OnRcptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CDate
		{
			get
			{
				return this._CDate;
			}
			set
			{
				if ((this._CDate != value))
				{
					this.OnCDateChanging(value);
					this.SendPropertyChanging();
					this._CDate = value;
					this.SendPropertyChanged("CDate");
					this.OnCDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUser", DbType="VarChar(50)")]
		public string CUser
		{
			get
			{
				return this._CUser;
			}
			set
			{
				if ((this._CUser != value))
				{
					this.OnCUserChanging(value);
					this.SendPropertyChanging();
					this._CUser = value;
					this.SendPropertyChanged("CUser");
					this.OnCUserChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CRMaster")]
	public partial class CRMaster : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _State;
		
		private string _SessionId;
		
		private string _DeliveryName;
		
		private string _RcptID;
		
		private System.Nullable<double> _Amount;
		
		private string _PayType;
		
		private string _PayRef;
		
		private string _PayVia;
		
		private string _Note;
		
		private System.Nullable<System.DateTime> _CDate;
		
		private string _CUser;
		
		private System.Nullable<System.DateTime> _UDate;
		
		private string _UUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnSessionIdChanging(string value);
    partial void OnSessionIdChanged();
    partial void OnDeliveryNameChanging(string value);
    partial void OnDeliveryNameChanged();
    partial void OnRcptIDChanging(string value);
    partial void OnRcptIDChanged();
    partial void OnAmountChanging(System.Nullable<double> value);
    partial void OnAmountChanged();
    partial void OnPayTypeChanging(string value);
    partial void OnPayTypeChanged();
    partial void OnPayRefChanging(string value);
    partial void OnPayRefChanged();
    partial void OnPayViaChanging(string value);
    partial void OnPayViaChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    partial void OnCDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCDateChanged();
    partial void OnCUserChanging(string value);
    partial void OnCUserChanged();
    partial void OnUDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUDateChanged();
    partial void OnUUserChanging(string value);
    partial void OnUUserChanged();
    #endregion
		
		public CRMaster()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="VarChar(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(15)", UpdateCheck=UpdateCheck.Never)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionId", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				if ((this._SessionId != value))
				{
					this.OnSessionIdChanging(value);
					this.SendPropertyChanging();
					this._SessionId = value;
					this.SendPropertyChanged("SessionId");
					this.OnSessionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeliveryName", DbType="VarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string DeliveryName
		{
			get
			{
				return this._DeliveryName;
			}
			set
			{
				if ((this._DeliveryName != value))
				{
					this.OnDeliveryNameChanging(value);
					this.SendPropertyChanging();
					this._DeliveryName = value;
					this.SendPropertyChanged("DeliveryName");
					this.OnDeliveryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RcptID", DbType="VarChar(15)", UpdateCheck=UpdateCheck.Never)]
		public string RcptID
		{
			get
			{
				return this._RcptID;
			}
			set
			{
				if ((this._RcptID != value))
				{
					this.OnRcptIDChanging(value);
					this.SendPropertyChanging();
					this._RcptID = value;
					this.SendPropertyChanged("RcptID");
					this.OnRcptIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Float", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<double> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PayType", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string PayType
		{
			get
			{
				return this._PayType;
			}
			set
			{
				if ((this._PayType != value))
				{
					this.OnPayTypeChanging(value);
					this.SendPropertyChanging();
					this._PayType = value;
					this.SendPropertyChanged("PayType");
					this.OnPayTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PayRef", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string PayRef
		{
			get
			{
				return this._PayRef;
			}
			set
			{
				if ((this._PayRef != value))
				{
					this.OnPayRefChanging(value);
					this.SendPropertyChanging();
					this._PayRef = value;
					this.SendPropertyChanged("PayRef");
					this.OnPayRefChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PayVia", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string PayVia
		{
			get
			{
				return this._PayVia;
			}
			set
			{
				if ((this._PayVia != value))
				{
					this.OnPayViaChanging(value);
					this.SendPropertyChanging();
					this._PayVia = value;
					this.SendPropertyChanged("PayVia");
					this.OnPayViaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="VarChar(80)", UpdateCheck=UpdateCheck.Never)]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> CDate
		{
			get
			{
				return this._CDate;
			}
			set
			{
				if ((this._CDate != value))
				{
					this.OnCDateChanging(value);
					this.SendPropertyChanging();
					this._CDate = value;
					this.SendPropertyChanged("CDate");
					this.OnCDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUser", DbType="VarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string CUser
		{
			get
			{
				return this._CUser;
			}
			set
			{
				if ((this._CUser != value))
				{
					this.OnCUserChanging(value);
					this.SendPropertyChanging();
					this._CUser = value;
					this.SendPropertyChanged("CUser");
					this.OnCUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> UDate
		{
			get
			{
				return this._UDate;
			}
			set
			{
				if ((this._UDate != value))
				{
					this.OnUDateChanging(value);
					this.SendPropertyChanging();
					this._UDate = value;
					this.SendPropertyChanged("UDate");
					this.OnUDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UUser", DbType="VarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string UUser
		{
			get
			{
				return this._UUser;
			}
			set
			{
				if ((this._UUser != value))
				{
					this.OnUUserChanging(value);
					this.SendPropertyChanging();
					this._UUser = value;
					this.SendPropertyChanged("UUser");
					this.OnUUserChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CRAccount")]
	public partial class CRAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _AccountNo;
		
		private string _AccountName;
		
		private System.Nullable<int> _AccountNoInt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnAccountNoChanging(string value);
    partial void OnAccountNoChanged();
    partial void OnAccountNameChanging(string value);
    partial void OnAccountNameChanged();
    partial void OnAccountNoIntChanging(System.Nullable<int> value);
    partial void OnAccountNoIntChanged();
    #endregion
		
		public CRAccount()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNo", DbType="VarChar(50)")]
		public string AccountNo
		{
			get
			{
				return this._AccountNo;
			}
			set
			{
				if ((this._AccountNo != value))
				{
					this.OnAccountNoChanging(value);
					this.SendPropertyChanging();
					this._AccountNo = value;
					this.SendPropertyChanged("AccountNo");
					this.OnAccountNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountName", DbType="VarChar(50)")]
		public string AccountName
		{
			get
			{
				return this._AccountName;
			}
			set
			{
				if ((this._AccountName != value))
				{
					this.OnAccountNameChanging(value);
					this.SendPropertyChanging();
					this._AccountName = value;
					this.SendPropertyChanged("AccountName");
					this.OnAccountNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNoInt", DbType="Int")]
		public System.Nullable<int> AccountNoInt
		{
			get
			{
				return this._AccountNoInt;
			}
			set
			{
				if ((this._AccountNoInt != value))
				{
					this.OnAccountNoIntChanging(value);
					this.SendPropertyChanging();
					this._AccountNoInt = value;
					this.SendPropertyChanged("AccountNoInt");
					this.OnAccountNoIntChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NAME")]
	public partial class NAME
	{
		
		private int _NAME_ID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _DBA;
		
		private string _Address1;
		
		private string _Address2;
		
		private string _Address3;
		
		private string _City;
		
		private string _State;
		
		private string _Zip;
		
		private string _Phone;
		
		private string _Phone_Ext;
		
		private string _Fax;
		
		private string _Cell;
		
		private string _Other_Phone;
		
		private string _Other_Ext;
		
		private int _IsActive;
		
		private System.Nullable<System.DateTime> _UseStamp;
		
		private string _Notes;
		
		private System.Nullable<System.DateTime> _Created;
		
		private int _RecForm;
		
		private int _CurFormOnFile;
		
		private System.Nullable<System.DateTime> _DateLastForm;
		
		private string _NameType;
		
		private string _RRAStatus;
		
		private System.Nullable<int> _AcresInFedDistricts;
		
		private int _MultiDistrict;
		
		private string _Citizenship;
		
		private string _TypeOtherDesc;
		
		private string _FullName;
		
		private int _Resident;
		
		private System.Nullable<double> _PENALTYMULTIPLIER;
		
		private string _CountyRecord;
		
		private System.Nullable<int> _SubOfName;
		
		private System.Nullable<System.DateTime> _DateCreated;
		
		private string _UserCreated;
		
		private System.Nullable<System.DateTime> _DateChanged;
		
		private string _UserChanged;
		
		private System.Nullable<System.DateTime> _LastPenaltyDate;
		
		private System.Nullable<int> _EntityLink;
		
		public NAME()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME_ID", DbType="Int NOT NULL")]
		public int NAME_ID
		{
			get
			{
				return this._NAME_ID;
			}
			set
			{
				if ((this._NAME_ID != value))
				{
					this._NAME_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(35) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(35)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DBA", DbType="VarChar(35)")]
		public string DBA
		{
			get
			{
				return this._DBA;
			}
			set
			{
				if ((this._DBA != value))
				{
					this._DBA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address1", DbType="VarChar(30)")]
		public string Address1
		{
			get
			{
				return this._Address1;
			}
			set
			{
				if ((this._Address1 != value))
				{
					this._Address1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address2", DbType="VarChar(30)")]
		public string Address2
		{
			get
			{
				return this._Address2;
			}
			set
			{
				if ((this._Address2 != value))
				{
					this._Address2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address3", DbType="VarChar(30)")]
		public string Address3
		{
			get
			{
				return this._Address3;
			}
			set
			{
				if ((this._Address3 != value))
				{
					this._Address3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(15)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(2)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="VarChar(10)")]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this._Zip = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(13)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Ext", DbType="VarChar(5)")]
		public string Phone_Ext
		{
			get
			{
				return this._Phone_Ext;
			}
			set
			{
				if ((this._Phone_Ext != value))
				{
					this._Phone_Ext = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="VarChar(13)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this._Fax = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cell", DbType="VarChar(13)")]
		public string Cell
		{
			get
			{
				return this._Cell;
			}
			set
			{
				if ((this._Cell != value))
				{
					this._Cell = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Other_Phone", DbType="VarChar(13)")]
		public string Other_Phone
		{
			get
			{
				return this._Other_Phone;
			}
			set
			{
				if ((this._Other_Phone != value))
				{
					this._Other_Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Other_Ext", DbType="VarChar(5)")]
		public string Other_Ext
		{
			get
			{
				return this._Other_Ext;
			}
			set
			{
				if ((this._Other_Ext != value))
				{
					this._Other_Ext = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Int NOT NULL")]
		public int IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this._IsActive = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UseStamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> UseStamp
		{
			get
			{
				return this._UseStamp;
			}
			set
			{
				if ((this._UseStamp != value))
				{
					this._UseStamp = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this._Notes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime")]
		public System.Nullable<System.DateTime> Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this._Created = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecForm", DbType="Int NOT NULL")]
		public int RecForm
		{
			get
			{
				return this._RecForm;
			}
			set
			{
				if ((this._RecForm != value))
				{
					this._RecForm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurFormOnFile", DbType="Int NOT NULL")]
		public int CurFormOnFile
		{
			get
			{
				return this._CurFormOnFile;
			}
			set
			{
				if ((this._CurFormOnFile != value))
				{
					this._CurFormOnFile = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateLastForm", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateLastForm
		{
			get
			{
				return this._DateLastForm;
			}
			set
			{
				if ((this._DateLastForm != value))
				{
					this._DateLastForm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameType", DbType="VarChar(60)")]
		public string NameType
		{
			get
			{
				return this._NameType;
			}
			set
			{
				if ((this._NameType != value))
				{
					this._NameType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RRAStatus", DbType="VarChar(30)")]
		public string RRAStatus
		{
			get
			{
				return this._RRAStatus;
			}
			set
			{
				if ((this._RRAStatus != value))
				{
					this._RRAStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AcresInFedDistricts", DbType="Int")]
		public System.Nullable<int> AcresInFedDistricts
		{
			get
			{
				return this._AcresInFedDistricts;
			}
			set
			{
				if ((this._AcresInFedDistricts != value))
				{
					this._AcresInFedDistricts = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MultiDistrict", DbType="Int NOT NULL")]
		public int MultiDistrict
		{
			get
			{
				return this._MultiDistrict;
			}
			set
			{
				if ((this._MultiDistrict != value))
				{
					this._MultiDistrict = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Citizenship", DbType="VarChar(30)")]
		public string Citizenship
		{
			get
			{
				return this._Citizenship;
			}
			set
			{
				if ((this._Citizenship != value))
				{
					this._Citizenship = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeOtherDesc", DbType="VarChar(60)")]
		public string TypeOtherDesc
		{
			get
			{
				return this._TypeOtherDesc;
			}
			set
			{
				if ((this._TypeOtherDesc != value))
				{
					this._TypeOtherDesc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(50)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resident", DbType="Int NOT NULL")]
		public int Resident
		{
			get
			{
				return this._Resident;
			}
			set
			{
				if ((this._Resident != value))
				{
					this._Resident = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PENALTYMULTIPLIER", DbType="Float")]
		public System.Nullable<double> PENALTYMULTIPLIER
		{
			get
			{
				return this._PENALTYMULTIPLIER;
			}
			set
			{
				if ((this._PENALTYMULTIPLIER != value))
				{
					this._PENALTYMULTIPLIER = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountyRecord", DbType="VarChar(60)")]
		public string CountyRecord
		{
			get
			{
				return this._CountyRecord;
			}
			set
			{
				if ((this._CountyRecord != value))
				{
					this._CountyRecord = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubOfName", DbType="Int")]
		public System.Nullable<int> SubOfName
		{
			get
			{
				return this._SubOfName;
			}
			set
			{
				if ((this._SubOfName != value))
				{
					this._SubOfName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this._DateCreated = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCreated", DbType="VarChar(10)")]
		public string UserCreated
		{
			get
			{
				return this._UserCreated;
			}
			set
			{
				if ((this._UserCreated != value))
				{
					this._UserCreated = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateChanged", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateChanged
		{
			get
			{
				return this._DateChanged;
			}
			set
			{
				if ((this._DateChanged != value))
				{
					this._DateChanged = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserChanged", DbType="VarChar(10)")]
		public string UserChanged
		{
			get
			{
				return this._UserChanged;
			}
			set
			{
				if ((this._UserChanged != value))
				{
					this._UserChanged = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastPenaltyDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastPenaltyDate
		{
			get
			{
				return this._LastPenaltyDate;
			}
			set
			{
				if ((this._LastPenaltyDate != value))
				{
					this._LastPenaltyDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EntityLink", DbType="Int")]
		public System.Nullable<int> EntityLink
		{
			get
			{
				return this._EntityLink;
			}
			set
			{
				if ((this._EntityLink != value))
				{
					this._EntityLink = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CRDetail")]
	public partial class CRDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _State;
		
		private string _SessionId;
		
		private string _CRMid;
		
		private string _Account;
		
		private string _Name;
		
		private System.Nullable<double> _Amount;
		
		private string _Type;
		
		private string _Note;
		
		private System.Nullable<System.DateTime> _CDate;
		
		private string _CUser;
		
		private System.Nullable<System.DateTime> _UDate;
		
		private string _UUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnSessionIdChanging(string value);
    partial void OnSessionIdChanged();
    partial void OnCRMidChanging(string value);
    partial void OnCRMidChanged();
    partial void OnAccountChanging(string value);
    partial void OnAccountChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAmountChanging(System.Nullable<double> value);
    partial void OnAmountChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    partial void OnCDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCDateChanged();
    partial void OnCUserChanging(string value);
    partial void OnCUserChanged();
    partial void OnUDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUDateChanged();
    partial void OnUUserChanging(string value);
    partial void OnUUserChanged();
    #endregion
		
		public CRDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="VarChar(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(15)", UpdateCheck=UpdateCheck.Never)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionId", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				if ((this._SessionId != value))
				{
					this.OnSessionIdChanging(value);
					this.SendPropertyChanging();
					this._SessionId = value;
					this.SendPropertyChanged("SessionId");
					this.OnSessionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRMid", DbType="VarChar(40)", UpdateCheck=UpdateCheck.Never)]
		public string CRMid
		{
			get
			{
				return this._CRMid;
			}
			set
			{
				if ((this._CRMid != value))
				{
					this.OnCRMidChanging(value);
					this.SendPropertyChanging();
					this._CRMid = value;
					this.SendPropertyChanged("CRMid");
					this.OnCRMidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string Account
		{
			get
			{
				return this._Account;
			}
			set
			{
				if ((this._Account != value))
				{
					this.OnAccountChanging(value);
					this.SendPropertyChanging();
					this._Account = value;
					this.SendPropertyChanged("Account");
					this.OnAccountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Float", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<double> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="VarChar(80)", UpdateCheck=UpdateCheck.Never)]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> CDate
		{
			get
			{
				return this._CDate;
			}
			set
			{
				if ((this._CDate != value))
				{
					this.OnCDateChanging(value);
					this.SendPropertyChanging();
					this._CDate = value;
					this.SendPropertyChanged("CDate");
					this.OnCDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUser", DbType="VarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string CUser
		{
			get
			{
				return this._CUser;
			}
			set
			{
				if ((this._CUser != value))
				{
					this.OnCUserChanging(value);
					this.SendPropertyChanging();
					this._CUser = value;
					this.SendPropertyChanged("CUser");
					this.OnCUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> UDate
		{
			get
			{
				return this._UDate;
			}
			set
			{
				if ((this._UDate != value))
				{
					this.OnUDateChanging(value);
					this.SendPropertyChanging();
					this._UDate = value;
					this.SendPropertyChanged("UDate");
					this.OnUDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UUser", DbType="VarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string UUser
		{
			get
			{
				return this._UUser;
			}
			set
			{
				if ((this._UUser != value))
				{
					this.OnUUserChanging(value);
					this.SendPropertyChanging();
					this._UUser = value;
					this.SendPropertyChanged("UUser");
					this.OnUUserChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
