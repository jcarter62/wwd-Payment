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
    partial void InsertCRDetail(CRDetail instance);
    partial void UpdateCRDetail(CRDetail instance);
    partial void DeleteCRDetail(CRDetail instance);
    partial void InsertCRMaster(CRMaster instance);
    partial void UpdateCRMaster(CRMaster instance);
    partial void DeleteCRMaster(CRMaster instance);
    partial void InsertCRAccount(CRAccount instance);
    partial void UpdateCRAccount(CRAccount instance);
    partial void DeleteCRAccount(CRAccount instance);
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
		
		public System.Data.Linq.Table<CRDetail> CRDetails
		{
			get
			{
				return this.GetTable<CRDetail>();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CRDetail")]
	public partial class CRDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _State;
		
		private string _SessionId;
		
		private string _CRMid;
		
		private string _Account;
		
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
}
#pragma warning restore 1591
