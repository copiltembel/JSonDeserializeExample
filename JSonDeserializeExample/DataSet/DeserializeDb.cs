﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeserializeDb.DataAccess.DataSet
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DeserializeExample")]
	public partial class DbContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLocation(Location instance);
    partial void UpdateLocation(Location instance);
    partial void DeleteLocation(Location instance);
    partial void InsertProfile(Profile instance);
    partial void UpdateProfile(Profile instance);
    partial void DeleteProfile(Profile instance);
    #endregion
		
		public DbContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Location> Locations
		{
			get
			{
				return this.GetTable<Location>();
			}
		}
		
		public System.Data.Linq.Table<Profile> Profiles
		{
			get
			{
				return this.GetTable<Profile>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_alterdiagram")]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public int Sp_alterdiagram([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> version, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarBinary(MAX)")] System.Data.Linq.Binary definition)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id, version, definition);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_creatediagram")]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public int Sp_creatediagram([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> version, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarBinary(MAX)")] System.Data.Linq.Binary definition)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id, version, definition);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_dropdiagram")]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public int Sp_dropdiagram([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_helpdiagramdefinition")]
		public ISingleResult<Sp_helpdiagramdefinitionResult> Sp_helpdiagramdefinition([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id);
			return ((ISingleResult<Sp_helpdiagramdefinitionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_helpdiagrams")]
		public ISingleResult<Sp_helpdiagramsResult> Sp_helpdiagrams([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id);
			return ((ISingleResult<Sp_helpdiagramsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_renamediagram")]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public int Sp_renamediagram([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string new_diagramname)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id, new_diagramname);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Location")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Location : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _LocationId;
		
		private string _Address;
		
		private string _City;
		
		private System.Guid _ProfileId;
		
		private EntityRef<Profile> _Profile;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLocationIdChanging(System.Guid value);
    partial void OnLocationIdChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnProfileIdChanging(System.Guid value);
    partial void OnProfileIdChanged();
    #endregion
		
		public Location()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public System.Guid LocationId
		{
			get
			{
				return this._LocationId;
			}
			set
			{
				if ((this._LocationId != value))
				{
					this.OnLocationIdChanging(value);
					this.SendPropertyChanging();
					this._LocationId = value;
					this.SendPropertyChanged("LocationId");
					this.OnLocationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
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
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfileId", DbType="UniqueIdentifier NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Guid ProfileId
		{
			get
			{
				return this._ProfileId;
			}
			set
			{
				if ((this._ProfileId != value))
				{
					if (this._Profile.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProfileIdChanging(value);
					this.SendPropertyChanging();
					this._ProfileId = value;
					this.SendPropertyChanged("ProfileId");
					this.OnProfileIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Profile_Locations", Storage="_Profile", ThisKey="ProfileId", OtherKey="ProfileId", IsForeignKey=true)]
        [DataMember(Order = 1, EmitDefaultValue = false)]
        public Profile Profile
		{
			get
			{
				return this._Profile.Entity;
			}
			set
			{
				Profile previousValue = this._Profile.Entity;
				if (((previousValue != value) 
							|| (this._Profile.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Profile.Entity = null;
						previousValue.Locations.Remove(this);
					}
					this._Profile.Entity = value;
					if ((value != null))
					{
						value.Locations.Add(this);
						this._ProfileId = value.ProfileId;
					}
					else
					{
						this._ProfileId = default(System.Guid);
					}
					this.SendPropertyChanged("Profile");
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
		
		private void Initialize()
		{
			this._Profile = default(EntityRef<Profile>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Profile")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Profile : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ProfileId;
		
		private System.DateTime _Birthday;
		
		private bool _CanBeRecommended;
		
		private EntitySet<Location> _Locations;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProfileIdChanging(System.Guid value);
    partial void OnProfileIdChanged();
    partial void OnBirthdayChanging(System.DateTime value);
    partial void OnBirthdayChanged();
    partial void OnCanBeRecommendedChanging(bool value);
    partial void OnCanBeRecommendedChanged();
    #endregion
		
		public Profile()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfileId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public System.Guid ProfileId
		{
			get
			{
				return this._ProfileId;
			}
			set
			{
				if ((this._ProfileId != value))
				{
					this.OnProfileIdChanging(value);
					this.SendPropertyChanging();
					this._ProfileId = value;
					this.SendPropertyChanged("ProfileId");
					this.OnProfileIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.DateTime Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanBeRecommended", DbType="Bit NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public bool CanBeRecommended
		{
			get
			{
				return this._CanBeRecommended;
			}
			set
			{
				if ((this._CanBeRecommended != value))
				{
					this.OnCanBeRecommendedChanging(value);
					this.SendPropertyChanging();
					this._CanBeRecommended = value;
					this.SendPropertyChanged("CanBeRecommended");
					this.OnCanBeRecommendedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Profile_Locations", Storage="_Locations", ThisKey="ProfileId", OtherKey="ProfileId", DeleteRule="NO ACTION")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4, EmitDefaultValue=false)]
		public EntitySet<Location> Locations
		{
			get
			{
				if ((this.serializing 
							&& (this._Locations.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Locations;
			}
			set
			{
				this._Locations.Assign(value);
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
		
		private void attach_Locations(Location entity)
		{
			this.SendPropertyChanging();
			entity.Profile = this;
		}
		
		private void detach_Locations(Location entity)
		{
			this.SendPropertyChanging();
			entity.Profile = null;
		}
		
		private void Initialize()
		{
			this._Locations = new EntitySet<Location>(new Action<Location>(this.attach_Locations), new Action<Location>(this.detach_Locations));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Sp_helpdiagramdefinitionResult
	{
		
		private System.Nullable<int> _Version;
		
		private System.Data.Linq.Binary _Definition;
		
		public Sp_helpdiagramdefinitionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="version", Storage="_Version", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public System.Nullable<int> Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				if ((this._Version != value))
				{
					this._Version = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="definition", Storage="_Definition", DbType="VarBinary(MAX)", CanBeNull=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.Data.Linq.Binary Definition
		{
			get
			{
				return this._Definition;
			}
			set
			{
				if ((this._Definition != value))
				{
					this._Definition = value;
				}
			}
		}
	}
	
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Sp_helpdiagramsResult
	{
		
		private string _Database;
		
		private string _Name;
		
		private System.Nullable<int> _ID;
		
		private string _Owner;
		
		private System.Nullable<int> _OwnerID;
		
		public Sp_helpdiagramsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Database", DbType="NVarChar(128)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public string Database
		{
			get
			{
				return this._Database;
			}
			set
			{
				if ((this._Database != value))
				{
					this._Database = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(128)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner", DbType="NVarChar(128)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string Owner
		{
			get
			{
				return this._Owner;
			}
			set
			{
				if ((this._Owner != value))
				{
					this._Owner = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerID", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.Nullable<int> OwnerID
		{
			get
			{
				return this._OwnerID;
			}
			set
			{
				if ((this._OwnerID != value))
				{
					this._OwnerID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591