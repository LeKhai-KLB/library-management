#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LIBRARY_MANAGEMENT")]
	public partial class LibraryDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCATEGORY(CATEGORY instance);
    partial void UpdateCATEGORY(CATEGORY instance);
    partial void DeleteCATEGORY(CATEGORY instance);
    partial void InsertLIBRARIAN(LIBRARIAN instance);
    partial void UpdateLIBRARIAN(LIBRARIAN instance);
    partial void DeleteLIBRARIAN(LIBRARIAN instance);
    partial void InsertREADER(READER instance);
    partial void UpdateREADER(READER instance);
    partial void DeleteREADER(READER instance);
    partial void InsertBOOK(BOOK instance);
    partial void UpdateBOOK(BOOK instance);
    partial void DeleteBOOK(BOOK instance);
    partial void InsertRETURNBOOK(RETURNBOOK instance);
    partial void UpdateRETURNBOOK(RETURNBOOK instance);
    partial void DeleteRETURNBOOK(RETURNBOOK instance);
    partial void InsertISSUEBOOK(ISSUEBOOK instance);
    partial void UpdateISSUEBOOK(ISSUEBOOK instance);
    partial void DeleteISSUEBOOK(ISSUEBOOK instance);
    #endregion
		
		public LibraryDatabaseDataContext() : 
				base(global::Library.Properties.Settings.Default.LIBRARY_MANAGEMENTConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CATEGORY> CATEGORies
		{
			get
			{
				return this.GetTable<CATEGORY>();
			}
		}
		
		public System.Data.Linq.Table<LIBRARIAN> LIBRARIANs
		{
			get
			{
				return this.GetTable<LIBRARIAN>();
			}
		}
		
		public System.Data.Linq.Table<READER> READERs
		{
			get
			{
				return this.GetTable<READER>();
			}
		}
		
		public System.Data.Linq.Table<BOOK> BOOKs
		{
			get
			{
				return this.GetTable<BOOK>();
			}
		}
		
		public System.Data.Linq.Table<RETURNBOOK> RETURNBOOKs
		{
			get
			{
				return this.GetTable<RETURNBOOK>();
			}
		}
		
		public System.Data.Linq.Table<ISSUEBOOK> ISSUEBOOKs
		{
			get
			{
				return this.GetTable<ISSUEBOOK>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CATEGORY")]
	public partial class CATEGORY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Title;
		
		private EntitySet<BOOK> _BOOKs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public CATEGORY()
		{
			this._BOOKs = new EntitySet<BOOK>(new Action<BOOK>(this.attach_BOOKs), new Action<BOOK>(this.detach_BOOKs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CATEGORY_BOOK", Storage="_BOOKs", ThisKey="Title", OtherKey="Category")]
		public EntitySet<BOOK> BOOKs
		{
			get
			{
				return this._BOOKs;
			}
			set
			{
				this._BOOKs.Assign(value);
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
		
		private void attach_BOOKs(BOOK entity)
		{
			this.SendPropertyChanging();
			entity.CATEGORY1 = this;
		}
		
		private void detach_BOOKs(BOOK entity)
		{
			this.SendPropertyChanging();
			entity.CATEGORY1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LIBRARIAN")]
	public partial class LIBRARIAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LibID;
		
		private string _LibName;
		
		private string _LibPass;
		
		private string _LibPhone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLibIDChanging(int value);
    partial void OnLibIDChanged();
    partial void OnLibNameChanging(string value);
    partial void OnLibNameChanged();
    partial void OnLibPassChanging(string value);
    partial void OnLibPassChanged();
    partial void OnLibPhoneChanging(string value);
    partial void OnLibPhoneChanged();
    #endregion
		
		public LIBRARIAN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LibID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LibID
		{
			get
			{
				return this._LibID;
			}
			set
			{
				if ((this._LibID != value))
				{
					this.OnLibIDChanging(value);
					this.SendPropertyChanging();
					this._LibID = value;
					this.SendPropertyChanged("LibID");
					this.OnLibIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LibName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LibName
		{
			get
			{
				return this._LibName;
			}
			set
			{
				if ((this._LibName != value))
				{
					this.OnLibNameChanging(value);
					this.SendPropertyChanging();
					this._LibName = value;
					this.SendPropertyChanged("LibName");
					this.OnLibNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LibPass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LibPass
		{
			get
			{
				return this._LibPass;
			}
			set
			{
				if ((this._LibPass != value))
				{
					this.OnLibPassChanging(value);
					this.SendPropertyChanging();
					this._LibPass = value;
					this.SendPropertyChanged("LibPass");
					this.OnLibPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LibPhone", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string LibPhone
		{
			get
			{
				return this._LibPhone;
			}
			set
			{
				if ((this._LibPhone != value))
				{
					this.OnLibPhoneChanging(value);
					this.SendPropertyChanging();
					this._LibPhone = value;
					this.SendPropertyChanged("LibPhone");
					this.OnLibPhoneChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.READER")]
	public partial class READER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ReID;
		
		private string _ReName;
		
		private string _ReAddress;
		
		private string _RePhone;
		
		private System.Data.Linq.Binary _ReImage;
		
		private EntitySet<ISSUEBOOK> _ISSUEBOOKs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReIDChanging(int value);
    partial void OnReIDChanged();
    partial void OnReNameChanging(string value);
    partial void OnReNameChanged();
    partial void OnReAddressChanging(string value);
    partial void OnReAddressChanged();
    partial void OnRePhoneChanging(string value);
    partial void OnRePhoneChanged();
    partial void OnReImageChanging(System.Data.Linq.Binary value);
    partial void OnReImageChanged();
    #endregion
		
		public READER()
		{
			this._ISSUEBOOKs = new EntitySet<ISSUEBOOK>(new Action<ISSUEBOOK>(this.attach_ISSUEBOOKs), new Action<ISSUEBOOK>(this.detach_ISSUEBOOKs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ReID
		{
			get
			{
				return this._ReID;
			}
			set
			{
				if ((this._ReID != value))
				{
					this.OnReIDChanging(value);
					this.SendPropertyChanging();
					this._ReID = value;
					this.SendPropertyChanged("ReID");
					this.OnReIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ReName
		{
			get
			{
				return this._ReName;
			}
			set
			{
				if ((this._ReName != value))
				{
					this.OnReNameChanging(value);
					this.SendPropertyChanging();
					this._ReName = value;
					this.SendPropertyChanged("ReName");
					this.OnReNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReAddress", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ReAddress
		{
			get
			{
				return this._ReAddress;
			}
			set
			{
				if ((this._ReAddress != value))
				{
					this.OnReAddressChanging(value);
					this.SendPropertyChanging();
					this._ReAddress = value;
					this.SendPropertyChanged("ReAddress");
					this.OnReAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RePhone", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string RePhone
		{
			get
			{
				return this._RePhone;
			}
			set
			{
				if ((this._RePhone != value))
				{
					this.OnRePhoneChanging(value);
					this.SendPropertyChanging();
					this._RePhone = value;
					this.SendPropertyChanged("RePhone");
					this.OnRePhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReImage", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ReImage
		{
			get
			{
				return this._ReImage;
			}
			set
			{
				if ((this._ReImage != value))
				{
					this.OnReImageChanging(value);
					this.SendPropertyChanging();
					this._ReImage = value;
					this.SendPropertyChanged("ReImage");
					this.OnReImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="READER_ISSUEBOOK", Storage="_ISSUEBOOKs", ThisKey="ReID", OtherKey="IssueReader")]
		public EntitySet<ISSUEBOOK> ISSUEBOOKs
		{
			get
			{
				return this._ISSUEBOOKs;
			}
			set
			{
				this._ISSUEBOOKs.Assign(value);
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
		
		private void attach_ISSUEBOOKs(ISSUEBOOK entity)
		{
			this.SendPropertyChanging();
			entity.READER = this;
		}
		
		private void detach_ISSUEBOOKs(ISSUEBOOK entity)
		{
			this.SendPropertyChanging();
			entity.READER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BOOK")]
	public partial class BOOK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ISBN;
		
		private string _BookName;
		
		private string _Author;
		
		private string _Publisher;
		
		private int _Quantity;
		
		private string _Category;
		
		private string _Summary;
		
		private System.Data.Linq.Binary _BookImage;
		
		private EntitySet<ISSUEBOOK> _ISSUEBOOKs;
		
		private EntityRef<CATEGORY> _CATEGORY1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnISBNChanging(string value);
    partial void OnISBNChanged();
    partial void OnBookNameChanging(string value);
    partial void OnBookNameChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnPublisherChanging(string value);
    partial void OnPublisherChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnSummaryChanging(string value);
    partial void OnSummaryChanged();
    partial void OnBookImageChanging(System.Data.Linq.Binary value);
    partial void OnBookImageChanged();
    #endregion
		
		public BOOK()
		{
			this._ISSUEBOOKs = new EntitySet<ISSUEBOOK>(new Action<ISSUEBOOK>(this.attach_ISSUEBOOKs), new Action<ISSUEBOOK>(this.detach_ISSUEBOOKs));
			this._CATEGORY1 = default(EntityRef<CATEGORY>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISBN", DbType="Char(13) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ISBN
		{
			get
			{
				return this._ISBN;
			}
			set
			{
				if ((this._ISBN != value))
				{
					this.OnISBNChanging(value);
					this.SendPropertyChanging();
					this._ISBN = value;
					this.SendPropertyChanged("ISBN");
					this.OnISBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BookName
		{
			get
			{
				return this._BookName;
			}
			set
			{
				if ((this._BookName != value))
				{
					this.OnBookNameChanging(value);
					this.SendPropertyChanging();
					this._BookName = value;
					this.SendPropertyChanged("BookName");
					this.OnBookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publisher", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Publisher
		{
			get
			{
				return this._Publisher;
			}
			set
			{
				if ((this._Publisher != value))
				{
					this.OnPublisherChanging(value);
					this.SendPropertyChanging();
					this._Publisher = value;
					this.SendPropertyChanged("Publisher");
					this.OnPublisherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					if (this._CATEGORY1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Summary", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Summary
		{
			get
			{
				return this._Summary;
			}
			set
			{
				if ((this._Summary != value))
				{
					this.OnSummaryChanging(value);
					this.SendPropertyChanging();
					this._Summary = value;
					this.SendPropertyChanged("Summary");
					this.OnSummaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookImage", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary BookImage
		{
			get
			{
				return this._BookImage;
			}
			set
			{
				if ((this._BookImage != value))
				{
					this.OnBookImageChanging(value);
					this.SendPropertyChanging();
					this._BookImage = value;
					this.SendPropertyChanged("BookImage");
					this.OnBookImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BOOK_ISSUEBOOK", Storage="_ISSUEBOOKs", ThisKey="ISBN", OtherKey="IssueBook1")]
		public EntitySet<ISSUEBOOK> ISSUEBOOKs
		{
			get
			{
				return this._ISSUEBOOKs;
			}
			set
			{
				this._ISSUEBOOKs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CATEGORY_BOOK", Storage="_CATEGORY1", ThisKey="Category", OtherKey="Title", IsForeignKey=true, DeleteRule="SET DEFAULT")]
		public CATEGORY CATEGORY1
		{
			get
			{
				return this._CATEGORY1.Entity;
			}
			set
			{
				CATEGORY previousValue = this._CATEGORY1.Entity;
				if (((previousValue != value) 
							|| (this._CATEGORY1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CATEGORY1.Entity = null;
						previousValue.BOOKs.Remove(this);
					}
					this._CATEGORY1.Entity = value;
					if ((value != null))
					{
						value.BOOKs.Add(this);
						this._Category = value.Title;
					}
					else
					{
						this._Category = default(string);
					}
					this.SendPropertyChanged("CATEGORY1");
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
		
		private void attach_ISSUEBOOKs(ISSUEBOOK entity)
		{
			this.SendPropertyChanging();
			entity.BOOK = this;
		}
		
		private void detach_ISSUEBOOKs(ISSUEBOOK entity)
		{
			this.SendPropertyChanging();
			entity.BOOK = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RETURNBOOK")]
	public partial class RETURNBOOK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ReturnID;
		
		private System.DateTime _ReturnDate;
		
		private EntityRef<ISSUEBOOK> _ISSUEBOOK;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReturnIDChanging(int value);
    partial void OnReturnIDChanged();
    partial void OnReturnDateChanging(System.DateTime value);
    partial void OnReturnDateChanged();
    #endregion
		
		public RETURNBOOK()
		{
			this._ISSUEBOOK = default(EntityRef<ISSUEBOOK>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ReturnID
		{
			get
			{
				return this._ReturnID;
			}
			set
			{
				if ((this._ReturnID != value))
				{
					if (this._ISSUEBOOK.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnReturnIDChanging(value);
					this.SendPropertyChanging();
					this._ReturnID = value;
					this.SendPropertyChanged("ReturnID");
					this.OnReturnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="DateTime NOT NULL")]
		public System.DateTime ReturnDate
		{
			get
			{
				return this._ReturnDate;
			}
			set
			{
				if ((this._ReturnDate != value))
				{
					this.OnReturnDateChanging(value);
					this.SendPropertyChanging();
					this._ReturnDate = value;
					this.SendPropertyChanged("ReturnDate");
					this.OnReturnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ISSUEBOOK_RETURNBOOK", Storage="_ISSUEBOOK", ThisKey="ReturnID", OtherKey="IssueID", IsForeignKey=true)]
		public ISSUEBOOK ISSUEBOOK
		{
			get
			{
				return this._ISSUEBOOK.Entity;
			}
			set
			{
				ISSUEBOOK previousValue = this._ISSUEBOOK.Entity;
				if (((previousValue != value) 
							|| (this._ISSUEBOOK.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ISSUEBOOK.Entity = null;
						previousValue.RETURNBOOK = null;
					}
					this._ISSUEBOOK.Entity = value;
					if ((value != null))
					{
						value.RETURNBOOK = this;
						this._ReturnID = value.IssueID;
					}
					else
					{
						this._ReturnID = default(int);
					}
					this.SendPropertyChanged("ISSUEBOOK");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ISSUEBOOK")]
	public partial class ISSUEBOOK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IssueID;
		
		private string _IssueBook1;
		
		private int _IssueReader;
		
		private System.DateTime _IssueDate;
		
		private EntityRef<RETURNBOOK> _RETURNBOOK;
		
		private EntityRef<BOOK> _BOOK;
		
		private EntityRef<READER> _READER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIssueIDChanging(int value);
    partial void OnIssueIDChanged();
    partial void OnIssueBook1Changing(string value);
    partial void OnIssueBook1Changed();
    partial void OnIssueReaderChanging(int value);
    partial void OnIssueReaderChanged();
    partial void OnIssueDateChanging(System.DateTime value);
    partial void OnIssueDateChanged();
    #endregion
		
		public ISSUEBOOK()
		{
			this._RETURNBOOK = default(EntityRef<RETURNBOOK>);
			this._BOOK = default(EntityRef<BOOK>);
			this._READER = default(EntityRef<READER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IssueID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IssueID
		{
			get
			{
				return this._IssueID;
			}
			set
			{
				if ((this._IssueID != value))
				{
					this.OnIssueIDChanging(value);
					this.SendPropertyChanging();
					this._IssueID = value;
					this.SendPropertyChanged("IssueID");
					this.OnIssueIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="IssueBook", Storage="_IssueBook1", DbType="Char(13) NOT NULL", CanBeNull=false)]
		public string IssueBook1
		{
			get
			{
				return this._IssueBook1;
			}
			set
			{
				if ((this._IssueBook1 != value))
				{
					this.OnIssueBook1Changing(value);
					this.SendPropertyChanging();
					this._IssueBook1 = value;
					this.SendPropertyChanged("IssueBook1");
					this.OnIssueBook1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IssueReader", DbType="Int NOT NULL")]
		public int IssueReader
		{
			get
			{
				return this._IssueReader;
			}
			set
			{
				if ((this._IssueReader != value))
				{
					if (this._READER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIssueReaderChanging(value);
					this.SendPropertyChanging();
					this._IssueReader = value;
					this.SendPropertyChanged("IssueReader");
					this.OnIssueReaderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IssueDate", DbType="DateTime NOT NULL")]
		public System.DateTime IssueDate
		{
			get
			{
				return this._IssueDate;
			}
			set
			{
				if ((this._IssueDate != value))
				{
					this.OnIssueDateChanging(value);
					this.SendPropertyChanging();
					this._IssueDate = value;
					this.SendPropertyChanged("IssueDate");
					this.OnIssueDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ISSUEBOOK_RETURNBOOK", Storage="_RETURNBOOK", ThisKey="IssueID", OtherKey="ReturnID", IsUnique=true, IsForeignKey=false)]
		public RETURNBOOK RETURNBOOK
		{
			get
			{
				return this._RETURNBOOK.Entity;
			}
			set
			{
				RETURNBOOK previousValue = this._RETURNBOOK.Entity;
				if (((previousValue != value) 
							|| (this._RETURNBOOK.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RETURNBOOK.Entity = null;
						previousValue.ISSUEBOOK = null;
					}
					this._RETURNBOOK.Entity = value;
					if ((value != null))
					{
						value.ISSUEBOOK = this;
					}
					this.SendPropertyChanged("RETURNBOOK");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BOOK_ISSUEBOOK", Storage="_BOOK", ThisKey="IssueBook1", OtherKey="ISBN", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public BOOK BOOK
		{
			get
			{
				return this._BOOK.Entity;
			}
			set
			{
				BOOK previousValue = this._BOOK.Entity;
				if (((previousValue != value) 
							|| (this._BOOK.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BOOK.Entity = null;
						previousValue.ISSUEBOOKs.Remove(this);
					}
					this._BOOK.Entity = value;
					if ((value != null))
					{
						value.ISSUEBOOKs.Add(this);
						this._IssueBook1 = value.ISBN;
					}
					else
					{
						this._IssueBook1 = default(string);
					}
					this.SendPropertyChanged("BOOK");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="READER_ISSUEBOOK", Storage="_READER", ThisKey="IssueReader", OtherKey="ReID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public READER READER
		{
			get
			{
				return this._READER.Entity;
			}
			set
			{
				READER previousValue = this._READER.Entity;
				if (((previousValue != value) 
							|| (this._READER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._READER.Entity = null;
						previousValue.ISSUEBOOKs.Remove(this);
					}
					this._READER.Entity = value;
					if ((value != null))
					{
						value.ISSUEBOOKs.Add(this);
						this._IssueReader = value.ReID;
					}
					else
					{
						this._IssueReader = default(int);
					}
					this.SendPropertyChanged("READER");
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
