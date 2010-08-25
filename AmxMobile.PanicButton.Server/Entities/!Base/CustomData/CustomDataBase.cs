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
    /// Defines the base entity type for 'CustomData'.
    /// </summary>
    [Serializable()]
    [Index("CustomData_CustomFieldIdObjectId", "CustomData_CustomFieldIdObjectId", true, "CustomFieldId,ObjectId")]
    public abstract class CustomDataBase : BootFX.Common.Entities.Entity
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected CustomDataBase()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected CustomDataBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the value for 'CustomDataId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CustomDataId' column.
        /// </remarks>
        [EntityField("CustomDataId", System.Data.DbType.Int32, ((BootFX.Common.Entities.EntityFieldFlags.Key | BootFX.Common.Entities.EntityFieldFlags.Common) 
                    | BootFX.Common.Entities.EntityFieldFlags.AutoIncrement))]
        public int CustomDataId
        {
            get
            {
                return ((int)(this["CustomDataId"]));
            }
            set
            {
                this["CustomDataId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'CustomFieldId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CustomFieldId' column.
        /// </remarks>
        [EntityField("CustomFieldId", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DBNullEquivalent(0)]
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
        /// Gets or sets the value for 'ObjectId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ObjectId' column.
        /// </remarks>
        [EntityField("ObjectId", System.Data.DbType.Int64, BootFX.Common.Entities.EntityFieldFlags.Common)]
        public long ObjectId
        {
            get
            {
                return ((long)(this["ObjectId"]));
            }
            set
            {
                this["ObjectId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'Value'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Value' column.
        /// </remarks>
        [EntityField("Value", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 1024)]
        public string Value
        {
            get
            {
                return ((string)(this["Value"]));
            }
            set
            {
                this["Value"] = value;
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
        /// Gets the link to 'CustomField'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'FK_CustomData_CustomFields' constraint.
        /// </remarks>
        [EntityLinkToParent("CustomField", "FK_CustomData_CustomFields", typeof(CustomField), new string[] {
                "CustomFieldId"})]
        public CustomField CustomField
        {
            get
            {
                return ((CustomField)(this.GetParent("CustomField")));
            }
            set
            {
                this.SetParent("CustomField", value);
            }
        }
        
        /// <summary>
        /// Creates an SqlFilter for an instance of 'CustomData'.
        /// </summary>
        public static BootFX.Common.Data.SqlFilter CreateFilter()
        {
            return new BootFX.Common.Data.SqlFilter(typeof(CustomData));
        }
        
        /// <summary>
        /// Sets properties on an instance of 'CustomData'.
        /// </summary>
        public static void SetProperties(int customDataId, string[] propertyNames, object[] propertyValues)
        {
            CustomData entity = AmxMobile.PanicButton.Server.CustomData.GetById(customDataId);
            entity.SetProperties(entity, propertyNames, propertyValues);
            entity.SaveChanges();
        }
        
        /// <summary>
        /// Get all <see cref="CustomData"/> entities.
        /// </summary>
        public static CustomDataCollection GetAll()
        {
            BootFX.Common.Data.SqlFilter filter = BootFX.Common.Data.SqlFilter.CreateGetAllFilter(typeof(CustomData));
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets the <see cref="CustomData"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        public static CustomData GetById(int customDataId)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetById(customDataId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets the <see cref="CustomData"/> entity where the ID matches the given specification.
        /// </summary>
        public static CustomData GetById(int customDataId, BootFX.Common.Data.SqlOperator customDataIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("CustomDataId", customDataIdOperator, customDataId);
            return ((CustomData)(filter.ExecuteEntity()));
        }
        
        /// <summary>
        /// Gets the <see cref="CustomData"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        public static CustomData GetById(int customDataId, BootFX.Common.OnNotFound onNotFound)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetById(customDataId, BootFX.Common.Data.SqlOperator.EqualTo, onNotFound);
        }
        
        /// <summary>
        /// Gets the <see cref="CustomData"/> entity where the ID matches the given specification.
        /// </summary>
        public static CustomData GetById(int customDataId, BootFX.Common.Data.SqlOperator customDataIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("CustomDataId", customDataIdOperator, customDataId);
            CustomData results = ((CustomData)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets an entity where CustomFieldId and ObjectId are equal to the given values.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for index <c>CustomData_CustomFieldIdObjectId</c>.
        /// </remarks>
        public static CustomData GetByCustomFieldIdAndObjectId(int customFieldId, long objectId)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByCustomFieldIdAndObjectId(customFieldId, objectId, BootFX.Common.OnNotFound.ReturnNull);
        }
        
        /// <summary>
        /// Gets an entity where CustomFieldId and ObjectId are equal to the given values.
        /// </summary>
        /// <remarks>
        /// Created for index <c>CustomData_CustomFieldIdObjectId</c>.
        /// </remarks>
        public static CustomData GetByCustomFieldIdAndObjectId(int customFieldId, long objectId, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("CustomFieldId", BootFX.Common.Data.SqlOperator.EqualTo, customFieldId);
            filter.Constraints.Add("ObjectId", BootFX.Common.Data.SqlOperator.EqualTo, objectId);
            CustomData results = ((CustomData)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CustomFieldId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CustomFieldId</c>
        /// </remarks>
        public static CustomDataCollection GetByCustomFieldId(int customFieldId)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByCustomFieldId(customFieldId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CustomFieldId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CustomFieldId</c>
        /// </remarks>
        public static CustomDataCollection GetByCustomFieldId(int customFieldId, BootFX.Common.Data.SqlOperator customFieldIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("CustomFieldId", customFieldIdOperator, customFieldId);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CustomFieldId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CustomFieldId</c>
        /// </remarks>
        public static CustomDataCollection GetByCustomFieldId(int customFieldId, BootFX.Common.Data.SqlOperator customFieldIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("CustomFieldId", customFieldIdOperator, customFieldId);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ObjectId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ObjectId</c>
        /// </remarks>
        public static CustomDataCollection GetByObjectId(long objectId)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByObjectId(objectId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ObjectId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ObjectId</c>
        /// </remarks>
        public static CustomDataCollection GetByObjectId(long objectId, BootFX.Common.Data.SqlOperator objectIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("ObjectId", objectIdOperator, objectId);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ObjectId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ObjectId</c>
        /// </remarks>
        public static CustomDataCollection GetByObjectId(long objectId, BootFX.Common.Data.SqlOperator objectIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("ObjectId", objectIdOperator, objectId);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Value is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Value</c>
        /// </remarks>
        public static CustomDataCollection GetByValue(string value)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByValue(value, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Value matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Value</c>
        /// </remarks>
        public static CustomDataCollection GetByValue(string value, BootFX.Common.Data.SqlOperator valueOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("Value", valueOperator, value);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Value matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Value</c>
        /// </remarks>
        public static CustomDataCollection GetByValue(string value, BootFX.Common.Data.SqlOperator valueOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("Value", valueOperator, value);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowVersion is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static CustomDataCollection GetByRowVersion(int rowVersion)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByRowVersion(rowVersion, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static CustomDataCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static CustomDataCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static CustomDataCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByRowCreatedUtc(rowCreatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static CustomDataCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static CustomDataCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowCreatedUserId(int rowCreatedUserId)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByRowCreatedUserId(rowCreatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static CustomDataCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByRowUpdatedUtc(rowUpdatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static CustomDataCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static CustomDataCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowUpdatedUserId(int rowUpdatedUserId)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByRowUpdatedUserId(rowUpdatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - CustomData
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId)
        {
            return AmxMobile.PanicButton.Server.CustomData.GetByRowLastTransactionId(rowLastTransactionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            return ((CustomDataCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static CustomDataCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(CustomData));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            CustomDataCollection results = ((CustomDataCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Searches for <see cref="CustomData"/> items with the given terms.
        /// </summary>
        public static CustomDataCollection Search(string terms)
        {
            BootFX.Common.Data.SqlSearcher searcher = new BootFX.Common.Data.SqlSearcher(typeof(CustomData), terms);
            return ((CustomDataCollection)(searcher.ExecuteEntityCollection()));
        }
    }
}
