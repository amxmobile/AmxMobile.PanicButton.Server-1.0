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
    /// Defines the base entity type for 'TableCatalogItems'.
    /// </summary>
    [Serializable()]
    [Index("TableCatalogItems_Name", "TableCatalogItems_Name", true, "Name")]
    [Index("TableCatalogItems_TargetTypeName", "TableCatalogItems_TargetTypeName", true, "TargetTypeName")]
    public abstract class TableCatalogItemBase : BootFX.Common.Entities.Entity
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected TableCatalogItemBase()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected TableCatalogItemBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the value for 'TableCatalogId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'TableCatalogId' column.
        /// </remarks>
        [EntityField("TableCatalogId", System.Data.DbType.Int32, ((BootFX.Common.Entities.EntityFieldFlags.Key | BootFX.Common.Entities.EntityFieldFlags.Common) 
                    | BootFX.Common.Entities.EntityFieldFlags.AutoIncrement))]
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
        /// Gets or sets the value for 'Name'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Name' column.
        /// </remarks>
        [EntityField("Name", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 64)]
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
        /// Gets or sets the value for 'Description'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Description' column.
        /// </remarks>
        [EntityField("Description", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 256)]
        public string Description
        {
            get
            {
                return ((string)(this["Description"]));
            }
            set
            {
                this["Description"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'IsCommon'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'IsCommon' column.
        /// </remarks>
        [EntityField("IsCommon", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool IsCommon
        {
            get
            {
                return ((bool)(this["IsCommon"]));
            }
            set
            {
                this["IsCommon"] = value;
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
        /// Gets or sets the value for 'IsExtended'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'IsExtended' column.
        /// </remarks>
        [EntityField("IsExtended", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        public bool IsExtended
        {
            get
            {
                return ((bool)(this["IsExtended"]));
            }
            set
            {
                this["IsExtended"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'TargetTypeName'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'TargetTypeName' column.
        /// </remarks>
        [EntityField("TargetTypeName", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 128)]
        public string TargetTypeName
        {
            get
            {
                return ((string)(this["TargetTypeName"]));
            }
            set
            {
                this["TargetTypeName"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'IsCustomised'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'IsCustomised' column.
        /// </remarks>
        [EntityField("IsCustomised", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool IsCustomised
        {
            get
            {
                return ((bool)(this["IsCustomised"]));
            }
            set
            {
                this["IsCustomised"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'IsHidden'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'IsHidden' column.
        /// </remarks>
        [EntityField("IsHidden", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool IsHidden
        {
            get
            {
                return ((bool)(this["IsHidden"]));
            }
            set
            {
                this["IsHidden"] = value;
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
        /// Creates an SqlFilter for an instance of 'TableCatalogItem'.
        /// </summary>
        public static BootFX.Common.Data.SqlFilter CreateFilter()
        {
            return new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
        }
        
        /// <summary>
        /// Sets properties on an instance of 'TableCatalogItem'.
        /// </summary>
        public static void SetProperties(int tableCatalogId, string[] propertyNames, object[] propertyValues)
        {
            TableCatalogItem entity = AmxMobile.PanicButton.Server.TableCatalogItem.GetById(tableCatalogId);
            entity.SetProperties(entity, propertyNames, propertyValues);
            entity.SaveChanges();
        }
        
        /// <summary>
        /// Get all <see cref="TableCatalogItem"/> entities.
        /// </summary>
        public static TableCatalogItemCollection GetAll()
        {
            BootFX.Common.Data.SqlFilter filter = BootFX.Common.Data.SqlFilter.CreateGetAllFilter(typeof(TableCatalogItem));
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets the <see cref="TableCatalogItem"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        public static TableCatalogItem GetById(int tableCatalogId)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetById(tableCatalogId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets the <see cref="TableCatalogItem"/> entity where the ID matches the given specification.
        /// </summary>
        public static TableCatalogItem GetById(int tableCatalogId, BootFX.Common.Data.SqlOperator tableCatalogIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("TableCatalogId", tableCatalogIdOperator, tableCatalogId);
            return ((TableCatalogItem)(filter.ExecuteEntity()));
        }
        
        /// <summary>
        /// Gets the <see cref="TableCatalogItem"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        public static TableCatalogItem GetById(int tableCatalogId, BootFX.Common.OnNotFound onNotFound)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetById(tableCatalogId, BootFX.Common.Data.SqlOperator.EqualTo, onNotFound);
        }
        
        /// <summary>
        /// Gets the <see cref="TableCatalogItem"/> entity where the ID matches the given specification.
        /// </summary>
        public static TableCatalogItem GetById(int tableCatalogId, BootFX.Common.Data.SqlOperator tableCatalogIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("TableCatalogId", tableCatalogIdOperator, tableCatalogId);
            TableCatalogItem results = ((TableCatalogItem)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets an entity where Name is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for index <c>TableCatalogItems_Name</c>.
        /// </remarks>
        public static TableCatalogItem GetByName(string name)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByName(name, BootFX.Common.OnNotFound.ReturnNull);
        }
        
        /// <summary>
        /// Gets an entity where Name is equal to the given value.
        /// </summary>
        /// <remarks>
        /// Created for index <c>TableCatalogItems_Name</c>.
        /// </remarks>
        public static TableCatalogItem GetByName(string name, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("Name", BootFX.Common.Data.SqlOperator.EqualTo, name);
            TableCatalogItem results = ((TableCatalogItem)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets an entity where TargetTypeName is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for index <c>TableCatalogItems_TargetTypeName</c>.
        /// </remarks>
        public static TableCatalogItem GetByTargetTypeName(string targetTypeName)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByTargetTypeName(targetTypeName, BootFX.Common.OnNotFound.ReturnNull);
        }
        
        /// <summary>
        /// Gets an entity where TargetTypeName is equal to the given value.
        /// </summary>
        /// <remarks>
        /// Created for index <c>TableCatalogItems_TargetTypeName</c>.
        /// </remarks>
        public static TableCatalogItem GetByTargetTypeName(string targetTypeName, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("TargetTypeName", BootFX.Common.Data.SqlOperator.EqualTo, targetTypeName);
            TableCatalogItem results = ((TableCatalogItem)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where DisplayName is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>DisplayName</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByDisplayName(string displayName)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByDisplayName(displayName, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where DisplayName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>DisplayName</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByDisplayName(string displayName, BootFX.Common.Data.SqlOperator displayNameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("DisplayName", displayNameOperator, displayName);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where DisplayName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>DisplayName</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByDisplayName(string displayName, BootFX.Common.Data.SqlOperator displayNameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("DisplayName", displayNameOperator, displayName);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Description is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Description</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByDescription(string description)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByDescription(description, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Description matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Description</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByDescription(string description, BootFX.Common.Data.SqlOperator descriptionOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("Description", descriptionOperator, description);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Description matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Description</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByDescription(string description, BootFX.Common.Data.SqlOperator descriptionOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("Description", descriptionOperator, description);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where IsCommon is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>IsCommon</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsCommon(bool isCommon)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByIsCommon(isCommon, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where IsCommon matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsCommon</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsCommon(bool isCommon, BootFX.Common.Data.SqlOperator isCommonOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsCommon", isCommonOperator, isCommon);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where IsCommon matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsCommon</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsCommon(bool isCommon, BootFX.Common.Data.SqlOperator isCommonOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsCommon", isCommonOperator, isCommon);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where IsActive is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsActive(bool isActive)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByIsActive(isActive, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where IsActive matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsActive(bool isActive, BootFX.Common.Data.SqlOperator isActiveOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsActive", isActiveOperator, isActive);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where IsActive matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsActive(bool isActive, BootFX.Common.Data.SqlOperator isActiveOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsActive", isActiveOperator, isActive);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where IsExtended is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>IsExtended</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsExtended(bool isExtended)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByIsExtended(isExtended, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where IsExtended matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsExtended</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsExtended(bool isExtended, BootFX.Common.Data.SqlOperator isExtendedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsExtended", isExtendedOperator, isExtended);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where IsExtended matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsExtended</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsExtended(bool isExtended, BootFX.Common.Data.SqlOperator isExtendedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsExtended", isExtendedOperator, isExtended);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where IsCustomised is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>IsCustomised</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsCustomised(bool isCustomised)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByIsCustomised(isCustomised, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where IsCustomised matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsCustomised</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsCustomised(bool isCustomised, BootFX.Common.Data.SqlOperator isCustomisedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsCustomised", isCustomisedOperator, isCustomised);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where IsCustomised matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsCustomised</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsCustomised(bool isCustomised, BootFX.Common.Data.SqlOperator isCustomisedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsCustomised", isCustomisedOperator, isCustomised);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where IsHidden is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>IsHidden</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsHidden(bool isHidden)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByIsHidden(isHidden, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where IsHidden matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsHidden</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsHidden(bool isHidden, BootFX.Common.Data.SqlOperator isHiddenOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsHidden", isHiddenOperator, isHidden);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where IsHidden matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsHidden</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByIsHidden(bool isHidden, BootFX.Common.Data.SqlOperator isHiddenOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("IsHidden", isHiddenOperator, isHidden);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowVersion is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowVersion(int rowVersion)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByRowVersion(rowVersion, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByRowCreatedUtc(rowCreatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowCreatedUserId(int rowCreatedUserId)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByRowCreatedUserId(rowCreatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByRowUpdatedUtc(rowUpdatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowUpdatedUserId(int rowUpdatedUserId)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByRowUpdatedUserId(rowUpdatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - TableCatalogItem
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId)
        {
            return AmxMobile.PanicButton.Server.TableCatalogItem.GetByRowLastTransactionId(rowLastTransactionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            return ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static TableCatalogItemCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(TableCatalogItem));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            TableCatalogItemCollection results = ((TableCatalogItemCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Get all of the child 'CustomField' entities.
        /// </summary>
        /// <remarks>
        /// Created for link <c>TableCatalogItem</c>.  (Stub method.)
        /// </remarks>
        public CustomFieldCollection GetCustomFieldItems()
        {
            // defer...
            return TableCatalogItem.GetCustomFieldItems(this.TableCatalogId);
        }
        
        /// <summary>
        /// Get all of the child 'CustomField' entities.
        /// </summary>
        /// <remarks>
        /// Created for link <c>TableCatalogItem</c>.  (Concrete method.)
        /// </remarks>
        public static CustomFieldCollection GetCustomFieldItems(int tableCatalogId)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomField));
            filter.Constraints.Add("TableCatalogId", BootFX.Common.Data.SqlOperator.EqualTo, tableCatalogId);
            return ((CustomFieldCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Searches for <see cref="TableCatalogItem"/> items with the given terms.
        /// </summary>
        public static TableCatalogItemCollection Search(string terms)
        {
            BootFX.Common.Data.SqlSearcher searcher = new BootFX.Common.Data.SqlSearcher(typeof(TableCatalogItem), terms);
            return ((TableCatalogItemCollection)(searcher.ExecuteEntityCollection()));
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
