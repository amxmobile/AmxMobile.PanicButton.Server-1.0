namespace AmxMobile.PanicButton.Server
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Data;
    using System.Collections;
    using System.Collections.Specialized;
    using BootFX.Common;
    using BootFX.Common.Data;
    using BootFX.Common.Entities;
    using BootFX.Common.Entities.Attributes;
    using BootFX.Common.BusinessServices;
    
    
    /// <summary>
    /// Defines the base entity type for 'CustomFields'.
    /// </summary>
    [Serializable()]
    [Index("CustomFields_CustomerIdTableCatalogIdName", "CustomFields_CustomerIdTableCatalogIdName", true, "ShmCustomerId,Name,TableCatalogId")]
    public abstract class CustomFieldBase : BootFX.Common.Entities.Entity
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected CustomFieldBase()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected CustomFieldBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the value for 'CustomFieldId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CustomFieldId' column.
        /// </remarks>
        [EntityField("CustomFieldId", System.Data.DbType.Int32, ((BootFX.Common.Entities.EntityFieldFlags.Key | BootFX.Common.Entities.EntityFieldFlags.Common) 
                    | BootFX.Common.Entities.EntityFieldFlags.AutoIncrement))]
        public int CustomFieldId
        {
            get
            {
                return ((int)(this["CustomFieldId"]));
            }
            set
            {
                this["CustomFieldId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ShmCustomerId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ShmCustomerId' column.
        /// </remarks>
        [EntityField("ShmCustomerId", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DBNullEquivalent(0)]
        public int ShmCustomerId
        {
            get
            {
                return ((int)(this["ShmCustomerId"]));
            }
            set
            {
                this["ShmCustomerId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'Name'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Name' column.
        /// </remarks>
        [EntityField("Name", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 32)]
        public string Name
        {
            get
            {
                return ((string)(this["Name"]));
            }
            set
            {
                this["Name"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'IsActive'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'IsActive' column.
        /// </remarks>
        [EntityField("IsActive", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        public bool IsActive
        {
            get
            {
                return ((bool)(this["IsActive"]));
            }
            set
            {
                this["IsActive"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'Ordinal'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Ordinal' column.
        /// </remarks>
        [EntityField("Ordinal", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        public int Ordinal
        {
            get
            {
                return ((int)(this["Ordinal"]));
            }
            set
            {
                this["Ordinal"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ShowOnGrid'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ShowOnGrid' column.
        /// </remarks>
        [EntityField("ShowOnGrid", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool ShowOnGrid
        {
            get
            {
                return ((bool)(this["ShowOnGrid"]));
            }
            set
            {
                this["ShowOnGrid"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'TableCatalogId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'TableCatalogId' column.
        /// </remarks>
        [EntityField("TableCatalogId", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DBNullEquivalent(0)]
        public int TableCatalogId
        {
            get
            {
                return ((int)(this["TableCatalogId"]));
            }
            set
            {
                this["TableCatalogId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'FilterBehaviour'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'FilterBehaviour' column.
        /// </remarks>
        [EntityField("FilterBehaviour", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int FilterBehaviour
        {
            get
            {
                return ((int)(this["FilterBehaviour"]));
            }
            set
            {
                this["FilterBehaviour"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'DisplayName'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'DisplayName' column.
        /// </remarks>
        [EntityField("DisplayName", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 64)]
        public string DisplayName
        {
            get
            {
                return ((string)(this["DisplayName"]));
            }
            set
            {
                this["DisplayName"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'RowVersion'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'RowVersion' column.
        /// </remarks>
        [EntityField("RowVersion", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int RowVersion
        {
            get
            {
                return ((int)(this["RowVersion"]));
            }
            set
            {
                this["RowVersion"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'RowCreatedUtc'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'RowCreatedUtc' column.
        /// </remarks>
        [EntityField("RowCreatedUtc", System.Data.DbType.DateTime, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.DateTime RowCreatedUtc
        {
            get
            {
                return ((System.DateTime)(this["RowCreatedUtc"]));
            }
            set
            {
                this["RowCreatedUtc"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'RowCreatedUserId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'RowCreatedUserId' column.
        /// </remarks>
        [EntityField("RowCreatedUserId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public int RowCreatedUserId
        {
            get
            {
                return ((int)(this["RowCreatedUserId"]));
            }
            set
            {
                this["RowCreatedUserId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'RowUpdatedUtc'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'RowUpdatedUtc' column.
        /// </remarks>
        [EntityField("RowUpdatedUtc", System.Data.DbType.DateTime, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.DateTime RowUpdatedUtc
        {
            get
            {
                return ((System.DateTime)(this["RowUpdatedUtc"]));
            }
            set
            {
                this["RowUpdatedUtc"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'RowUpdatedUserId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'RowUpdatedUserId' column.
        /// </remarks>
        [EntityField("RowUpdatedUserId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public int RowUpdatedUserId
        {
            get
            {
                return ((int)(this["RowUpdatedUserId"]));
            }
            set
            {
                this["RowUpdatedUserId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'RowLastTransactionId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'RowLastTransactionId' column.
        /// </remarks>
        [EntityField("RowLastTransactionId", System.Data.DbType.Guid, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.Guid RowLastTransactionId
        {
            get
            {
                return ((System.Guid)(this["RowLastTransactionId"]));
            }
            set
            {
                this["RowLastTransactionId"] = value;
            }
        }
        
        /// <summary>
        /// Gets the link to 'TableCatalogItem'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'FK_CustomFields_TableCatalogItems' constraint.
        /// </remarks>
        [EntityLinkToParent("TableCatalogItem", "FK_CustomFields_TableCatalogItems", typeof(TableCatalogItem), new string[] {
                "TableCatalogId"})]
        public TableCatalogItem TableCatalogItem
        {
            get
            {
                return ((TableCatalogItem)(this.GetParent("TableCatalogItem")));
            }
            set
            {
                this.SetParent("TableCatalogItem", value);
            }
        }
        
        /// <summary>
        /// Creates an SqlFilter for an instance of 'CustomField'.
        /// </summary>
        public static BootFX.Common.Data.SqlFilter CreateFilter()
        {
            return new BootFX.Common.Data.SqlFilter(typeof(CustomField));
        }
        
        /// <summary>
        /// Sets properties on an instance of 'CustomField'.
        /// </summary>
        public static void SetProperties(int customFieldId, string[] propertyNames, object[] propertyValues)
        {
            CustomField entity = AmxMobile.PanicButton.Server.CustomField.GetById(customFieldId);
            entity.SetProperties(entity, propertyNames, propertyValues);
            entity.SaveChanges();
        }
        
        /// <summary>
        /// Get all <see cref="CustomField"/> entities.
        /// </summary>
        public static CustomFieldCollection GetAll()
        {
            BootFX.Common.Data.SqlFilter filter = BootFX.Common.Data.SqlFilter.CreateGetAllFilter(typeof(CustomField));
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets the <see cref="CustomField"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        public static CustomField GetById(int customFieldId)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetById(customFieldId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets the <see cref="CustomField"/> entity where the ID matches the given specification.
        /// </summary>
        public static CustomField GetById(int customFieldId, BootFX.Common.Data.SqlOperator customFieldIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("CustomFieldId", customFieldIdOperator, customFieldId);
            return ((CustomField)(filter.ExecuteEntity()));
        }
        
        /// <summary>
        /// Gets the <see cref="CustomField"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        public static CustomField GetById(int customFieldId, BootFX.Common.OnNotFound onNotFound)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetById(customFieldId, BootFX.Common.Data.SqlOperator.EqualTo, onNotFound);
        }
        
        /// <summary>
        /// Gets the <see cref="CustomField"/> entity where the ID matches the given specification.
        /// </summary>
        public static CustomField GetById(int customFieldId, BootFX.Common.Data.SqlOperator customFieldIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("CustomFieldId", customFieldIdOperator, customFieldId);
            CustomField results = ((CustomField)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets an entity where ShmCustomerId, Name and TableCatalogId are equal to the given values.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for index <c>CustomFields_CustomerIdTableCatalogIdName</c>.
        /// </remarks>
        public static CustomField GetByShmCustomerIdAndNameAndTableCatalogId(int shmCustomerId, string name, int tableCatalogId)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByShmCustomerIdAndNameAndTableCatalogId(shmCustomerId, name, tableCatalogId, BootFX.Common.OnNotFound.ReturnNull);
        }
        
        /// <summary>
        /// Gets an entity where ShmCustomerId, Name and TableCatalogId are equal to the given values.
        /// </summary>
        /// <remarks>
        /// Created for index <c>CustomFields_CustomerIdTableCatalogIdName</c>.
        /// </remarks>
        public static CustomField GetByShmCustomerIdAndNameAndTableCatalogId(int shmCustomerId, string name, int tableCatalogId, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("ShmCustomerId", BootFX.Common.Data.SqlOperator.EqualTo, shmCustomerId);
            filter.Constraints.Add("Name", BootFX.Common.Data.SqlOperator.EqualTo, name);
            filter.Constraints.Add("TableCatalogId", BootFX.Common.Data.SqlOperator.EqualTo, tableCatalogId);
            CustomField results = ((CustomField)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ShmCustomerId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ShmCustomerId</c>
        /// </remarks>
        public static CustomFieldCollection GetByShmCustomerId(int shmCustomerId)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByShmCustomerId(shmCustomerId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ShmCustomerId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ShmCustomerId</c>
        /// </remarks>
        public static CustomFieldCollection GetByShmCustomerId(int shmCustomerId, BootFX.Common.Data.SqlOperator shmCustomerIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("ShmCustomerId", shmCustomerIdOperator, shmCustomerId);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ShmCustomerId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ShmCustomerId</c>
        /// </remarks>
        public static CustomFieldCollection GetByShmCustomerId(int shmCustomerId, BootFX.Common.Data.SqlOperator shmCustomerIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("ShmCustomerId", shmCustomerIdOperator, shmCustomerId);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Name is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static CustomFieldCollection GetByName(string name)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByName(name, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Name matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static CustomFieldCollection GetByName(string name, BootFX.Common.Data.SqlOperator nameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("Name", nameOperator, name);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Name matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static CustomFieldCollection GetByName(string name, BootFX.Common.Data.SqlOperator nameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("Name", nameOperator, name);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where IsActive is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static CustomFieldCollection GetByIsActive(bool isActive)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByIsActive(isActive, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where IsActive matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static CustomFieldCollection GetByIsActive(bool isActive, BootFX.Common.Data.SqlOperator isActiveOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("IsActive", isActiveOperator, isActive);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where IsActive matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static CustomFieldCollection GetByIsActive(bool isActive, BootFX.Common.Data.SqlOperator isActiveOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("IsActive", isActiveOperator, isActive);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Ordinal is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Ordinal</c>
        /// </remarks>
        public static CustomFieldCollection GetByOrdinal(int ordinal)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByOrdinal(ordinal, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Ordinal matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Ordinal</c>
        /// </remarks>
        public static CustomFieldCollection GetByOrdinal(int ordinal, BootFX.Common.Data.SqlOperator ordinalOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("Ordinal", ordinalOperator, ordinal);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Ordinal matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Ordinal</c>
        /// </remarks>
        public static CustomFieldCollection GetByOrdinal(int ordinal, BootFX.Common.Data.SqlOperator ordinalOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("Ordinal", ordinalOperator, ordinal);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ShowOnGrid is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ShowOnGrid</c>
        /// </remarks>
        public static CustomFieldCollection GetByShowOnGrid(bool showOnGrid)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByShowOnGrid(showOnGrid, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ShowOnGrid matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ShowOnGrid</c>
        /// </remarks>
        public static CustomFieldCollection GetByShowOnGrid(bool showOnGrid, BootFX.Common.Data.SqlOperator showOnGridOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("ShowOnGrid", showOnGridOperator, showOnGrid);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ShowOnGrid matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ShowOnGrid</c>
        /// </remarks>
        public static CustomFieldCollection GetByShowOnGrid(bool showOnGrid, BootFX.Common.Data.SqlOperator showOnGridOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("ShowOnGrid", showOnGridOperator, showOnGrid);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where TableCatalogId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>TableCatalogId</c>
        /// </remarks>
        public static CustomFieldCollection GetByTableCatalogId(int tableCatalogId)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByTableCatalogId(tableCatalogId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where TableCatalogId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TableCatalogId</c>
        /// </remarks>
        public static CustomFieldCollection GetByTableCatalogId(int tableCatalogId, BootFX.Common.Data.SqlOperator tableCatalogIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("TableCatalogId", tableCatalogIdOperator, tableCatalogId);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where TableCatalogId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TableCatalogId</c>
        /// </remarks>
        public static CustomFieldCollection GetByTableCatalogId(int tableCatalogId, BootFX.Common.Data.SqlOperator tableCatalogIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("TableCatalogId", tableCatalogIdOperator, tableCatalogId);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where FilterBehaviour is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>FilterBehaviour</c>
        /// </remarks>
        public static CustomFieldCollection GetByFilterBehaviour(int filterBehaviour)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByFilterBehaviour(filterBehaviour, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where FilterBehaviour matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>FilterBehaviour</c>
        /// </remarks>
        public static CustomFieldCollection GetByFilterBehaviour(int filterBehaviour, BootFX.Common.Data.SqlOperator filterBehaviourOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("FilterBehaviour", filterBehaviourOperator, filterBehaviour);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where FilterBehaviour matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>FilterBehaviour</c>
        /// </remarks>
        public static CustomFieldCollection GetByFilterBehaviour(int filterBehaviour, BootFX.Common.Data.SqlOperator filterBehaviourOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("FilterBehaviour", filterBehaviourOperator, filterBehaviour);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where DisplayName is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>DisplayName</c>
        /// </remarks>
        public static CustomFieldCollection GetByDisplayName(string displayName)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByDisplayName(displayName, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where DisplayName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>DisplayName</c>
        /// </remarks>
        public static CustomFieldCollection GetByDisplayName(string displayName, BootFX.Common.Data.SqlOperator displayNameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("DisplayName", displayNameOperator, displayName);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where DisplayName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>DisplayName</c>
        /// </remarks>
        public static CustomFieldCollection GetByDisplayName(string displayName, BootFX.Common.Data.SqlOperator displayNameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("DisplayName", displayNameOperator, displayName);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowVersion is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowVersion(int rowVersion)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByRowVersion(rowVersion, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByRowCreatedUtc(rowCreatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowCreatedUserId(int rowCreatedUserId)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByRowCreatedUserId(rowCreatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByRowUpdatedUtc(rowUpdatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowUpdatedUserId(int rowUpdatedUserId)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByRowUpdatedUserId(rowUpdatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomField
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId)
        {
            return AmxMobile.PanicButton.Server.CustomField.GetByRowLastTransactionId(rowLastTransactionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static CustomFieldCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            CustomFieldCollection results = ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Get all of the child 'CustomData' entities.
        /// </summary>
        /// <remarks>
        /// Created for link <c>CustomField</c>.  (Stub method.)
        /// </remarks>
        public CustomDataCollection GetCustomDataItems()
        {
            // defer...
            return CustomField.GetCustomDataItems(this.CustomFieldId);
        }
        
        /// <summary>
        /// Get all of the child 'CustomData' entities.
        /// </summary>
        /// <remarks>
        /// Created for link <c>CustomField</c>.  (Concrete method.)
        /// </remarks>
        public static CustomDataCollection GetCustomDataItems(int customFieldId)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("CustomFieldId", BootFX.Common.Data.SqlOperator.EqualTo, customFieldId);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Searches for <see cref="CustomField"/> items with the given terms.
        /// </summary>
        public static CustomFieldCollection Search(string terms)
        {
            BootFX.Common.Data.SqlSearcher searcher = new BootFX.Common.Data.SqlSearcher(typeof(CustomField), terms);
            return ((CustomFieldCollection)(searcher.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Returns the value in the 'Name' property.
        /// </summary>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
