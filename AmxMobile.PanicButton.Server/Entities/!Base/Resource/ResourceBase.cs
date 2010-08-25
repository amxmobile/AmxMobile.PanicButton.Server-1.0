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
    /// Defines the base entity type for 'ShmResources'.
    /// </summary>
    [Serializable()]
    [Index("IX_ShmResources", "IX_ShmResources", true, "CustomerId,ExternalId")]
    public abstract class ResourceBase : BootFX.Common.Entities.Entity
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected ResourceBase()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected ResourceBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the value for 'ResourceId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ResourceId' column.
        /// </remarks>
        [EntityField("ResourceId", System.Data.DbType.Int32, ((BootFX.Common.Entities.EntityFieldFlags.Key | BootFX.Common.Entities.EntityFieldFlags.Common) 
                    | BootFX.Common.Entities.EntityFieldFlags.AutoIncrement))]
        public int ResourceId
        {
            get
            {
                return ((int)(this["ResourceId"]));
            }
            set
            {
                this["ResourceId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'CustomerId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CustomerId' column.
        /// </remarks>
        [EntityField("CustomerId", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DBNullEquivalent(0)]
        public int CustomerId
        {
            get
            {
                return ((int)(this["CustomerId"]));
            }
            set
            {
                this["CustomerId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ExternalId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ExternalId' column.
        /// </remarks>
        [EntityField("ExternalId", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 64)]
        public string ExternalId
        {
            get
            {
                return ((string)(this["ExternalId"]));
            }
            set
            {
                this["ExternalId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'Name'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Name' column.
        /// </remarks>
        [EntityField("Name", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 128)]
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
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 1)]
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
        /// Gets or sets the value for 'AutoAccept'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'AutoAccept' column.
        /// </remarks>
        [EntityField("AutoAccept", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool AutoAccept
        {
            get
            {
                return ((bool)(this["AutoAccept"]));
            }
            set
            {
                this["AutoAccept"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'AutoRefresh'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'AutoRefresh' column.
        /// </remarks>
        [EntityField("AutoRefresh", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool AutoRefresh
        {
            get
            {
                return ((bool)(this["AutoRefresh"]));
            }
            set
            {
                this["AutoRefresh"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'NumSentOk'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'NumSentOk' column.
        /// </remarks>
        [EntityField("NumSentOk", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int NumSentOk
        {
            get
            {
                return ((int)(this["NumSentOk"]));
            }
            set
            {
                this["NumSentOk"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'LastSentOk'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'LastSentOk' column.
        /// </remarks>
        [EntityField("LastSentOk", System.Data.DbType.DateTime, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.DateTime LastSentOk
        {
            get
            {
                return ((System.DateTime)(this["LastSentOk"]));
            }
            set
            {
                this["LastSentOk"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'NumBounced'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'NumBounced' column.
        /// </remarks>
        [EntityField("NumBounced", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int NumBounced
        {
            get
            {
                return ((int)(this["NumBounced"]));
            }
            set
            {
                this["NumBounced"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'LastBounced'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'LastBounced' column.
        /// </remarks>
        [EntityField("LastBounced", System.Data.DbType.DateTime, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.DateTime LastBounced
        {
            get
            {
                return ((System.DateTime)(this["LastBounced"]));
            }
            set
            {
                this["LastBounced"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'NumReceiveFailed'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'NumReceiveFailed' column.
        /// </remarks>
        [EntityField("NumReceiveFailed", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int NumReceiveFailed
        {
            get
            {
                return ((int)(this["NumReceiveFailed"]));
            }
            set
            {
                this["NumReceiveFailed"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'LastReceiveFailed'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'LastReceiveFailed' column.
        /// </remarks>
        [EntityField("LastReceiveFailed", System.Data.DbType.DateTime, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.DateTime LastReceiveFailed
        {
            get
            {
                return ((System.DateTime)(this["LastReceiveFailed"]));
            }
            set
            {
                this["LastReceiveFailed"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'NumSendFailed'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'NumSendFailed' column.
        /// </remarks>
        [EntityField("NumSendFailed", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int NumSendFailed
        {
            get
            {
                return ((int)(this["NumSendFailed"]));
            }
            set
            {
                this["NumSendFailed"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'LastSendFailed'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'LastSendFailed' column.
        /// </remarks>
        [EntityField("LastSendFailed", System.Data.DbType.DateTime, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.DateTime LastSendFailed
        {
            get
            {
                return ((System.DateTime)(this["LastSendFailed"]));
            }
            set
            {
                this["LastSendFailed"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'CurrentState'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CurrentState' column.
        /// </remarks>
        [EntityField("CurrentState", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int CurrentState
        {
            get
            {
                return ((int)(this["CurrentState"]));
            }
            set
            {
                this["CurrentState"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'MaxToSignal'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'MaxToSignal' column.
        /// </remarks>
        [EntityField("MaxToSignal", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 3)]
        public int MaxToSignal
        {
            get
            {
                return ((int)(this["MaxToSignal"]));
            }
            set
            {
                this["MaxToSignal"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'Active'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Active' column.
        /// </remarks>
        [EntityField("Active", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 1)]
        public bool Active
        {
            get
            {
                return ((bool)(this["Active"]));
            }
            set
            {
                this["Active"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ResourceSubCategoryId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ResourceSubCategoryId' column.
        /// </remarks>
        [EntityField("ResourceSubCategoryId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int ResourceSubCategoryId
        {
            get
            {
                return ((int)(this["ResourceSubCategoryId"]));
            }
            set
            {
                this["ResourceSubCategoryId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ResourceType'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ResourceType' column.
        /// </remarks>
        [EntityField("ResourceType", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int ResourceType
        {
            get
            {
                return ((int)(this["ResourceType"]));
            }
            set
            {
                this["ResourceType"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ProfileId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ProfileId' column.
        /// </remarks>
        [EntityField("ProfileId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int ProfileId
        {
            get
            {
                return ((int)(this["ProfileId"]));
            }
            set
            {
                this["ProfileId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'Password'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Password' column.
        /// </remarks>
        [EntityField("Password", System.Data.DbType.String, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common), 48)]
        public string Password
        {
            get
            {
                return ((string)(this["Password"]));
            }
            set
            {
                this["Password"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ResourceCategoryId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ResourceCategoryId' column.
        /// </remarks>
        [EntityField("ResourceCategoryId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int ResourceCategoryId
        {
            get
            {
                return ((int)(this["ResourceCategoryId"]));
            }
            set
            {
                this["ResourceCategoryId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'OrganisationalGroup'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'OrganisationalGroup' column.
        /// </remarks>
        [EntityField("OrganisationalGroup", System.Data.DbType.String, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common), 16)]
        public string OrganisationalGroup
        {
            get
            {
                return ((string)(this["OrganisationalGroup"]));
            }
            set
            {
                this["OrganisationalGroup"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'CurrentConfigurationReleaseId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CurrentConfigurationReleaseId' column.
        /// </remarks>
        [EntityField("CurrentConfigurationReleaseId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int CurrentConfigurationReleaseId
        {
            get
            {
                return ((int)(this["CurrentConfigurationReleaseId"]));
            }
            set
            {
                this["CurrentConfigurationReleaseId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'TargetMobileClientVersionId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'TargetMobileClientVersionId' column.
        /// </remarks>
        [EntityField("TargetMobileClientVersionId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int TargetMobileClientVersionId
        {
            get
            {
                return ((int)(this["TargetMobileClientVersionId"]));
            }
            set
            {
                this["TargetMobileClientVersionId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'CurrentMobileClientVersionId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CurrentMobileClientVersionId' column.
        /// </remarks>
        [EntityField("CurrentMobileClientVersionId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int CurrentMobileClientVersionId
        {
            get
            {
                return ((int)(this["CurrentMobileClientVersionId"]));
            }
            set
            {
                this["CurrentMobileClientVersionId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'LastConnectivityUpdateUtc'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'LastConnectivityUpdateUtc' column.
        /// </remarks>
        [EntityField("LastConnectivityUpdateUtc", System.Data.DbType.DateTime, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.DateTime LastConnectivityUpdateUtc
        {
            get
            {
                return ((System.DateTime)(this["LastConnectivityUpdateUtc"]));
            }
            set
            {
                this["LastConnectivityUpdateUtc"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'CurrentMasterDataReleaseId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CurrentMasterDataReleaseId' column.
        /// </remarks>
        [EntityField("CurrentMasterDataReleaseId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int CurrentMasterDataReleaseId
        {
            get
            {
                return ((int)(this["CurrentMasterDataReleaseId"]));
            }
            set
            {
                this["CurrentMasterDataReleaseId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'AutomaticReleaseUpdateOn'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'AutomaticReleaseUpdateOn' column.
        /// </remarks>
        [EntityField("AutomaticReleaseUpdateOn", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool AutomaticReleaseUpdateOn
        {
            get
            {
                return ((bool)(this["AutomaticReleaseUpdateOn"]));
            }
            set
            {
                this["AutomaticReleaseUpdateOn"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'LastTransactionUpdateUtc'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'LastTransactionUpdateUtc' column.
        /// </remarks>
        [EntityField("LastTransactionUpdateUtc", System.Data.DbType.DateTime, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        public System.DateTime LastTransactionUpdateUtc
        {
            get
            {
                return ((System.DateTime)(this["LastTransactionUpdateUtc"]));
            }
            set
            {
                this["LastTransactionUpdateUtc"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'MobileControllerLoggingOn'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'MobileControllerLoggingOn' column.
        /// </remarks>
        [EntityField("MobileControllerLoggingOn", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool MobileControllerLoggingOn
        {
            get
            {
                return ((bool)(this["MobileControllerLoggingOn"]));
            }
            set
            {
                this["MobileControllerLoggingOn"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'MobileApplicationGeneralLoggingOn'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'MobileApplicationGeneralLoggingOn' column.
        /// </remarks>
        [EntityField("MobileApplicationGeneralLoggingOn", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool MobileApplicationGeneralLoggingOn
        {
            get
            {
                return ((bool)(this["MobileApplicationGeneralLoggingOn"]));
            }
            set
            {
                this["MobileApplicationGeneralLoggingOn"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'MobileApplicationUpdateLoggingOn'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'MobileApplicationUpdateLoggingOn' column.
        /// </remarks>
        [EntityField("MobileApplicationUpdateLoggingOn", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool MobileApplicationUpdateLoggingOn
        {
            get
            {
                return ((bool)(this["MobileApplicationUpdateLoggingOn"]));
            }
            set
            {
                this["MobileApplicationUpdateLoggingOn"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'CurrentMobileControllerVersion'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CurrentMobileControllerVersion' column.
        /// </remarks>
        [EntityField("CurrentMobileControllerVersion", System.Data.DbType.String, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common), 32)]
        public string CurrentMobileControllerVersion
        {
            get
            {
                return ((string)(this["CurrentMobileControllerVersion"]));
            }
            set
            {
                this["CurrentMobileControllerVersion"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'MobileClientInitialization'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'MobileClientInitialization' column.
        /// </remarks>
        [EntityField("MobileClientInitialization", System.Data.DbType.Int32, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public int MobileClientInitialization
        {
            get
            {
                return ((int)(this["MobileClientInitialization"]));
            }
            set
            {
                this["MobileClientInitialization"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'MaxPdaHistoryInDays'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'MaxPDAHistoryInDays' column.
        /// </remarks>
        [EntityField("MaxPDAHistoryInDays", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 5)]
        public int MaxPdaHistoryInDays
        {
            get
            {
                return ((int)(this["MaxPdaHistoryInDays"]));
            }
            set
            {
                this["MaxPdaHistoryInDays"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'SupervisorTelephone'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'SupervisorTelephone' column.
        /// </remarks>
        [EntityField("SupervisorTelephone", System.Data.DbType.String, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common), 64)]
        public string SupervisorTelephone
        {
            get
            {
                return ((string)(this["SupervisorTelephone"]));
            }
            set
            {
                this["SupervisorTelephone"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'PinCodeEnabled'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'PINCodeEnabled' column.
        /// </remarks>
        [EntityField("PINCodeEnabled", System.Data.DbType.Boolean, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 0)]
        public bool PinCodeEnabled
        {
            get
            {
                return ((bool)(this["PinCodeEnabled"]));
            }
            set
            {
                this["PinCodeEnabled"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'Locale'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'Locale' column.
        /// </remarks>
        [EntityField("Locale", System.Data.DbType.String, BootFX.Common.Entities.EntityFieldFlags.Common, 16)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, "en-GB")]
        public string Locale
        {
            get
            {
                return ((string)(this["Locale"]));
            }
            set
            {
                this["Locale"] = value;
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
        /// Gets or sets the value for 'SecurityGroupId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'SecurityGroupId' column.
        /// </remarks>
        [EntityField("SecurityGroupId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int SecurityGroupId
        {
            get
            {
                return ((int)(this["SecurityGroupId"]));
            }
            set
            {
                this["SecurityGroupId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ContractGroupId'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ContractGroupId' column.
        /// </remarks>
        [EntityField("ContractGroupId", System.Data.DbType.Int32, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common))]
        [DBNullEquivalent(0)]
        public int ContractGroupId
        {
            get
            {
                return ((int)(this["ContractGroupId"]));
            }
            set
            {
                this["ContractGroupId"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'TargetMobileClientName'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'TargetMobileClientName' column.
        /// </remarks>
        [EntityField("TargetMobileClientName", System.Data.DbType.String, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common), 64)]
        public string TargetMobileClientName
        {
            get
            {
                return ((string)(this["TargetMobileClientName"]));
            }
            set
            {
                this["TargetMobileClientName"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'CurrentMobileClientName'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'CurrentMobileClientName' column.
        /// </remarks>
        [EntityField("CurrentMobileClientName", System.Data.DbType.String, (BootFX.Common.Entities.EntityFieldFlags.Nullable | BootFX.Common.Entities.EntityFieldFlags.Common), 64)]
        public string CurrentMobileClientName
        {
            get
            {
                return ((string)(this["CurrentMobileClientName"]));
            }
            set
            {
                this["CurrentMobileClientName"] = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the value for 'ForceCodeCapture'.
        /// </summary>
        /// <remarks>
        /// This property maps to the 'ForceCodeCapture' column.
        /// </remarks>
        [EntityField("ForceCodeCapture", System.Data.DbType.Boolean, BootFX.Common.Entities.EntityFieldFlags.Common)]
        [DatabaseDefault(BootFX.Common.Data.Schema.SqlDatabaseDefaultType.Primitive, 1)]
        public bool ForceCodeCapture
        {
            get
            {
                return ((bool)(this["ForceCodeCapture"]));
            }
            set
            {
                this["ForceCodeCapture"] = value;
            }
        }
        
        /// <summary>
        /// Creates an SqlFilter for an instance of 'Resource'.
        /// </summary>
        public static BootFX.Common.Data.SqlFilter CreateFilter()
        {
            return new BootFX.Common.Data.SqlFilter(typeof(Resource));
        }
        
        /// <summary>
        /// Sets properties on an instance of 'Resource'.
        /// </summary>
        public static void SetProperties(int resourceId, string[] propertyNames, object[] propertyValues)
        {
            Resource entity = AmxMobile.PanicButton.Server.Resource.GetById(resourceId);
            entity.SetProperties(entity, propertyNames, propertyValues);
            entity.SaveChanges();
        }
        
        /// <summary>
        /// Get all <see cref="Resource"/> entities.
        /// </summary>
        public static ResourceCollection GetAll()
        {
            BootFX.Common.Data.SqlFilter filter = BootFX.Common.Data.SqlFilter.CreateGetAllFilter(typeof(Resource));
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets the <see cref="Resource"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        public static Resource GetById(int resourceId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetById(resourceId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets the <see cref="Resource"/> entity where the ID matches the given specification.
        /// </summary>
        public static Resource GetById(int resourceId, BootFX.Common.Data.SqlOperator resourceIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ResourceId", resourceIdOperator, resourceId);
            return ((Resource)(filter.ExecuteEntity()));
        }
        
        /// <summary>
        /// Gets the <see cref="Resource"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        public static Resource GetById(int resourceId, BootFX.Common.OnNotFound onNotFound)
        {
            return AmxMobile.PanicButton.Server.Resource.GetById(resourceId, BootFX.Common.Data.SqlOperator.EqualTo, onNotFound);
        }
        
        /// <summary>
        /// Gets the <see cref="Resource"/> entity where the ID matches the given specification.
        /// </summary>
        public static Resource GetById(int resourceId, BootFX.Common.Data.SqlOperator resourceIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ResourceId", resourceIdOperator, resourceId);
            Resource results = ((Resource)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets an entity where CustomerId and ExternalId are equal to the given values.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for index <c>IX_ShmResources</c>.
        /// </remarks>
        public static Resource GetByCustomerIdAndExternalId(int customerId, string externalId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByCustomerIdAndExternalId(customerId, externalId, BootFX.Common.OnNotFound.ReturnNull);
        }
        
        /// <summary>
        /// Gets an entity where CustomerId and ExternalId are equal to the given values.
        /// </summary>
        /// <remarks>
        /// Created for index <c>IX_ShmResources</c>.
        /// </remarks>
        public static Resource GetByCustomerIdAndExternalId(int customerId, string externalId, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CustomerId", BootFX.Common.Data.SqlOperator.EqualTo, customerId);
            filter.Constraints.Add("ExternalId", BootFX.Common.Data.SqlOperator.EqualTo, externalId);
            Resource results = ((Resource)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CustomerId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CustomerId</c>
        /// </remarks>
        public static ResourceCollection GetByCustomerId(int customerId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByCustomerId(customerId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CustomerId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CustomerId</c>
        /// </remarks>
        public static ResourceCollection GetByCustomerId(int customerId, BootFX.Common.Data.SqlOperator customerIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CustomerId", customerIdOperator, customerId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CustomerId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CustomerId</c>
        /// </remarks>
        public static ResourceCollection GetByCustomerId(int customerId, BootFX.Common.Data.SqlOperator customerIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CustomerId", customerIdOperator, customerId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ExternalId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ExternalId</c>
        /// </remarks>
        public static ResourceCollection GetByExternalId(string externalId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByExternalId(externalId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ExternalId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ExternalId</c>
        /// </remarks>
        public static ResourceCollection GetByExternalId(string externalId, BootFX.Common.Data.SqlOperator externalIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ExternalId", externalIdOperator, externalId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ExternalId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ExternalId</c>
        /// </remarks>
        public static ResourceCollection GetByExternalId(string externalId, BootFX.Common.Data.SqlOperator externalIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ExternalId", externalIdOperator, externalId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Name is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static ResourceCollection GetByName(string name)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByName(name, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Name matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static ResourceCollection GetByName(string name, BootFX.Common.Data.SqlOperator nameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("Name", nameOperator, name);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Name matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static ResourceCollection GetByName(string name, BootFX.Common.Data.SqlOperator nameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("Name", nameOperator, name);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where IsActive is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static ResourceCollection GetByIsActive(bool isActive)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByIsActive(isActive, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where IsActive matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static ResourceCollection GetByIsActive(bool isActive, BootFX.Common.Data.SqlOperator isActiveOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("IsActive", isActiveOperator, isActive);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where IsActive matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static ResourceCollection GetByIsActive(bool isActive, BootFX.Common.Data.SqlOperator isActiveOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("IsActive", isActiveOperator, isActive);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where AutoAccept is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>AutoAccept</c>
        /// </remarks>
        public static ResourceCollection GetByAutoAccept(bool autoAccept)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByAutoAccept(autoAccept, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where AutoAccept matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutoAccept</c>
        /// </remarks>
        public static ResourceCollection GetByAutoAccept(bool autoAccept, BootFX.Common.Data.SqlOperator autoAcceptOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("AutoAccept", autoAcceptOperator, autoAccept);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where AutoAccept matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutoAccept</c>
        /// </remarks>
        public static ResourceCollection GetByAutoAccept(bool autoAccept, BootFX.Common.Data.SqlOperator autoAcceptOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("AutoAccept", autoAcceptOperator, autoAccept);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where AutoRefresh is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>AutoRefresh</c>
        /// </remarks>
        public static ResourceCollection GetByAutoRefresh(bool autoRefresh)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByAutoRefresh(autoRefresh, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where AutoRefresh matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutoRefresh</c>
        /// </remarks>
        public static ResourceCollection GetByAutoRefresh(bool autoRefresh, BootFX.Common.Data.SqlOperator autoRefreshOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("AutoRefresh", autoRefreshOperator, autoRefresh);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where AutoRefresh matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutoRefresh</c>
        /// </remarks>
        public static ResourceCollection GetByAutoRefresh(bool autoRefresh, BootFX.Common.Data.SqlOperator autoRefreshOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("AutoRefresh", autoRefreshOperator, autoRefresh);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where NumSentOk is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>NumSentOk</c>
        /// </remarks>
        public static ResourceCollection GetByNumSentOk(int numSentOk)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByNumSentOk(numSentOk, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where NumSentOk matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumSentOk</c>
        /// </remarks>
        public static ResourceCollection GetByNumSentOk(int numSentOk, BootFX.Common.Data.SqlOperator numSentOkOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("NumSentOk", numSentOkOperator, numSentOk);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where NumSentOk matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumSentOk</c>
        /// </remarks>
        public static ResourceCollection GetByNumSentOk(int numSentOk, BootFX.Common.Data.SqlOperator numSentOkOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("NumSentOk", numSentOkOperator, numSentOk);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastSentOk is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastSentOk</c>
        /// </remarks>
        public static ResourceCollection GetByLastSentOk(System.DateTime lastSentOk)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByLastSentOk(lastSentOk, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastSentOk matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastSentOk</c>
        /// </remarks>
        public static ResourceCollection GetByLastSentOk(System.DateTime lastSentOk, BootFX.Common.Data.SqlOperator lastSentOkOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastSentOk", lastSentOkOperator, lastSentOk);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastSentOk matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastSentOk</c>
        /// </remarks>
        public static ResourceCollection GetByLastSentOk(System.DateTime lastSentOk, BootFX.Common.Data.SqlOperator lastSentOkOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastSentOk", lastSentOkOperator, lastSentOk);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where NumBounced is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>NumBounced</c>
        /// </remarks>
        public static ResourceCollection GetByNumBounced(int numBounced)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByNumBounced(numBounced, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where NumBounced matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumBounced</c>
        /// </remarks>
        public static ResourceCollection GetByNumBounced(int numBounced, BootFX.Common.Data.SqlOperator numBouncedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("NumBounced", numBouncedOperator, numBounced);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where NumBounced matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumBounced</c>
        /// </remarks>
        public static ResourceCollection GetByNumBounced(int numBounced, BootFX.Common.Data.SqlOperator numBouncedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("NumBounced", numBouncedOperator, numBounced);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastBounced is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastBounced</c>
        /// </remarks>
        public static ResourceCollection GetByLastBounced(System.DateTime lastBounced)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByLastBounced(lastBounced, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastBounced matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastBounced</c>
        /// </remarks>
        public static ResourceCollection GetByLastBounced(System.DateTime lastBounced, BootFX.Common.Data.SqlOperator lastBouncedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastBounced", lastBouncedOperator, lastBounced);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastBounced matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastBounced</c>
        /// </remarks>
        public static ResourceCollection GetByLastBounced(System.DateTime lastBounced, BootFX.Common.Data.SqlOperator lastBouncedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastBounced", lastBouncedOperator, lastBounced);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where NumReceiveFailed is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>NumReceiveFailed</c>
        /// </remarks>
        public static ResourceCollection GetByNumReceiveFailed(int numReceiveFailed)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByNumReceiveFailed(numReceiveFailed, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where NumReceiveFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumReceiveFailed</c>
        /// </remarks>
        public static ResourceCollection GetByNumReceiveFailed(int numReceiveFailed, BootFX.Common.Data.SqlOperator numReceiveFailedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("NumReceiveFailed", numReceiveFailedOperator, numReceiveFailed);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where NumReceiveFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumReceiveFailed</c>
        /// </remarks>
        public static ResourceCollection GetByNumReceiveFailed(int numReceiveFailed, BootFX.Common.Data.SqlOperator numReceiveFailedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("NumReceiveFailed", numReceiveFailedOperator, numReceiveFailed);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastReceiveFailed is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastReceiveFailed</c>
        /// </remarks>
        public static ResourceCollection GetByLastReceiveFailed(System.DateTime lastReceiveFailed)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByLastReceiveFailed(lastReceiveFailed, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastReceiveFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastReceiveFailed</c>
        /// </remarks>
        public static ResourceCollection GetByLastReceiveFailed(System.DateTime lastReceiveFailed, BootFX.Common.Data.SqlOperator lastReceiveFailedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastReceiveFailed", lastReceiveFailedOperator, lastReceiveFailed);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastReceiveFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastReceiveFailed</c>
        /// </remarks>
        public static ResourceCollection GetByLastReceiveFailed(System.DateTime lastReceiveFailed, BootFX.Common.Data.SqlOperator lastReceiveFailedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastReceiveFailed", lastReceiveFailedOperator, lastReceiveFailed);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where NumSendFailed is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>NumSendFailed</c>
        /// </remarks>
        public static ResourceCollection GetByNumSendFailed(int numSendFailed)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByNumSendFailed(numSendFailed, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where NumSendFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumSendFailed</c>
        /// </remarks>
        public static ResourceCollection GetByNumSendFailed(int numSendFailed, BootFX.Common.Data.SqlOperator numSendFailedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("NumSendFailed", numSendFailedOperator, numSendFailed);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where NumSendFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumSendFailed</c>
        /// </remarks>
        public static ResourceCollection GetByNumSendFailed(int numSendFailed, BootFX.Common.Data.SqlOperator numSendFailedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("NumSendFailed", numSendFailedOperator, numSendFailed);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastSendFailed is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastSendFailed</c>
        /// </remarks>
        public static ResourceCollection GetByLastSendFailed(System.DateTime lastSendFailed)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByLastSendFailed(lastSendFailed, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastSendFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastSendFailed</c>
        /// </remarks>
        public static ResourceCollection GetByLastSendFailed(System.DateTime lastSendFailed, BootFX.Common.Data.SqlOperator lastSendFailedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastSendFailed", lastSendFailedOperator, lastSendFailed);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastSendFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastSendFailed</c>
        /// </remarks>
        public static ResourceCollection GetByLastSendFailed(System.DateTime lastSendFailed, BootFX.Common.Data.SqlOperator lastSendFailedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastSendFailed", lastSendFailedOperator, lastSendFailed);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentState is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentState</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentState(int currentState)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByCurrentState(currentState, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentState matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentState</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentState(int currentState, BootFX.Common.Data.SqlOperator currentStateOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentState", currentStateOperator, currentState);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentState matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentState</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentState(int currentState, BootFX.Common.Data.SqlOperator currentStateOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentState", currentStateOperator, currentState);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MaxToSignal is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MaxToSignal</c>
        /// </remarks>
        public static ResourceCollection GetByMaxToSignal(int maxToSignal)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByMaxToSignal(maxToSignal, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MaxToSignal matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MaxToSignal</c>
        /// </remarks>
        public static ResourceCollection GetByMaxToSignal(int maxToSignal, BootFX.Common.Data.SqlOperator maxToSignalOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MaxToSignal", maxToSignalOperator, maxToSignal);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MaxToSignal matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MaxToSignal</c>
        /// </remarks>
        public static ResourceCollection GetByMaxToSignal(int maxToSignal, BootFX.Common.Data.SqlOperator maxToSignalOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MaxToSignal", maxToSignalOperator, maxToSignal);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Active is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Active</c>
        /// </remarks>
        public static ResourceCollection GetByActive(bool active)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByActive(active, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Active matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Active</c>
        /// </remarks>
        public static ResourceCollection GetByActive(bool active, BootFX.Common.Data.SqlOperator activeOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("Active", activeOperator, active);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Active matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Active</c>
        /// </remarks>
        public static ResourceCollection GetByActive(bool active, BootFX.Common.Data.SqlOperator activeOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("Active", activeOperator, active);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ResourceSubCategoryId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ResourceSubCategoryId</c>
        /// </remarks>
        public static ResourceCollection GetByResourceSubCategoryId(int resourceSubCategoryId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByResourceSubCategoryId(resourceSubCategoryId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ResourceSubCategoryId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceSubCategoryId</c>
        /// </remarks>
        public static ResourceCollection GetByResourceSubCategoryId(int resourceSubCategoryId, BootFX.Common.Data.SqlOperator resourceSubCategoryIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ResourceSubCategoryId", resourceSubCategoryIdOperator, resourceSubCategoryId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ResourceSubCategoryId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceSubCategoryId</c>
        /// </remarks>
        public static ResourceCollection GetByResourceSubCategoryId(int resourceSubCategoryId, BootFX.Common.Data.SqlOperator resourceSubCategoryIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ResourceSubCategoryId", resourceSubCategoryIdOperator, resourceSubCategoryId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ResourceType is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ResourceType</c>
        /// </remarks>
        public static ResourceCollection GetByResourceType(int resourceType)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByResourceType(resourceType, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ResourceType matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceType</c>
        /// </remarks>
        public static ResourceCollection GetByResourceType(int resourceType, BootFX.Common.Data.SqlOperator resourceTypeOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ResourceType", resourceTypeOperator, resourceType);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ResourceType matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceType</c>
        /// </remarks>
        public static ResourceCollection GetByResourceType(int resourceType, BootFX.Common.Data.SqlOperator resourceTypeOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ResourceType", resourceTypeOperator, resourceType);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ProfileId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ProfileId</c>
        /// </remarks>
        public static ResourceCollection GetByProfileId(int profileId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByProfileId(profileId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ProfileId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ProfileId</c>
        /// </remarks>
        public static ResourceCollection GetByProfileId(int profileId, BootFX.Common.Data.SqlOperator profileIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ProfileId", profileIdOperator, profileId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ProfileId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ProfileId</c>
        /// </remarks>
        public static ResourceCollection GetByProfileId(int profileId, BootFX.Common.Data.SqlOperator profileIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ProfileId", profileIdOperator, profileId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Password is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Password</c>
        /// </remarks>
        public static ResourceCollection GetByPassword(string password)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByPassword(password, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Password matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Password</c>
        /// </remarks>
        public static ResourceCollection GetByPassword(string password, BootFX.Common.Data.SqlOperator passwordOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("Password", passwordOperator, password);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Password matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Password</c>
        /// </remarks>
        public static ResourceCollection GetByPassword(string password, BootFX.Common.Data.SqlOperator passwordOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("Password", passwordOperator, password);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ResourceCategoryId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ResourceCategoryId</c>
        /// </remarks>
        public static ResourceCollection GetByResourceCategoryId(int resourceCategoryId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByResourceCategoryId(resourceCategoryId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ResourceCategoryId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceCategoryId</c>
        /// </remarks>
        public static ResourceCollection GetByResourceCategoryId(int resourceCategoryId, BootFX.Common.Data.SqlOperator resourceCategoryIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ResourceCategoryId", resourceCategoryIdOperator, resourceCategoryId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ResourceCategoryId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceCategoryId</c>
        /// </remarks>
        public static ResourceCollection GetByResourceCategoryId(int resourceCategoryId, BootFX.Common.Data.SqlOperator resourceCategoryIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ResourceCategoryId", resourceCategoryIdOperator, resourceCategoryId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where OrganisationalGroup is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>OrganisationalGroup</c>
        /// </remarks>
        public static ResourceCollection GetByOrganisationalGroup(string organisationalGroup)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByOrganisationalGroup(organisationalGroup, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where OrganisationalGroup matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>OrganisationalGroup</c>
        /// </remarks>
        public static ResourceCollection GetByOrganisationalGroup(string organisationalGroup, BootFX.Common.Data.SqlOperator organisationalGroupOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("OrganisationalGroup", organisationalGroupOperator, organisationalGroup);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where OrganisationalGroup matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>OrganisationalGroup</c>
        /// </remarks>
        public static ResourceCollection GetByOrganisationalGroup(string organisationalGroup, BootFX.Common.Data.SqlOperator organisationalGroupOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("OrganisationalGroup", organisationalGroupOperator, organisationalGroup);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentConfigurationReleaseId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentConfigurationReleaseId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentConfigurationReleaseId(int currentConfigurationReleaseId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByCurrentConfigurationReleaseId(currentConfigurationReleaseId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentConfigurationReleaseId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentConfigurationReleaseId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentConfigurationReleaseId(int currentConfigurationReleaseId, BootFX.Common.Data.SqlOperator currentConfigurationReleaseIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentConfigurationReleaseId", currentConfigurationReleaseIdOperator, currentConfigurationReleaseId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentConfigurationReleaseId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentConfigurationReleaseId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentConfigurationReleaseId(int currentConfigurationReleaseId, BootFX.Common.Data.SqlOperator currentConfigurationReleaseIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentConfigurationReleaseId", currentConfigurationReleaseIdOperator, currentConfigurationReleaseId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientVersionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>TargetMobileClientVersionId</c>
        /// </remarks>
        public static ResourceCollection GetByTargetMobileClientVersionId(int targetMobileClientVersionId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByTargetMobileClientVersionId(targetMobileClientVersionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientVersionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TargetMobileClientVersionId</c>
        /// </remarks>
        public static ResourceCollection GetByTargetMobileClientVersionId(int targetMobileClientVersionId, BootFX.Common.Data.SqlOperator targetMobileClientVersionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("TargetMobileClientVersionId", targetMobileClientVersionIdOperator, targetMobileClientVersionId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientVersionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TargetMobileClientVersionId</c>
        /// </remarks>
        public static ResourceCollection GetByTargetMobileClientVersionId(int targetMobileClientVersionId, BootFX.Common.Data.SqlOperator targetMobileClientVersionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("TargetMobileClientVersionId", targetMobileClientVersionIdOperator, targetMobileClientVersionId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientVersionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientVersionId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileClientVersionId(int currentMobileClientVersionId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByCurrentMobileClientVersionId(currentMobileClientVersionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientVersionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientVersionId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileClientVersionId(int currentMobileClientVersionId, BootFX.Common.Data.SqlOperator currentMobileClientVersionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentMobileClientVersionId", currentMobileClientVersionIdOperator, currentMobileClientVersionId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientVersionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientVersionId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileClientVersionId(int currentMobileClientVersionId, BootFX.Common.Data.SqlOperator currentMobileClientVersionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentMobileClientVersionId", currentMobileClientVersionIdOperator, currentMobileClientVersionId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastConnectivityUpdateUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastConnectivityUpdateUtc</c>
        /// </remarks>
        public static ResourceCollection GetByLastConnectivityUpdateUtc(System.DateTime lastConnectivityUpdateUtc)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByLastConnectivityUpdateUtc(lastConnectivityUpdateUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastConnectivityUpdateUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastConnectivityUpdateUtc</c>
        /// </remarks>
        public static ResourceCollection GetByLastConnectivityUpdateUtc(System.DateTime lastConnectivityUpdateUtc, BootFX.Common.Data.SqlOperator lastConnectivityUpdateUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastConnectivityUpdateUtc", lastConnectivityUpdateUtcOperator, lastConnectivityUpdateUtc);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastConnectivityUpdateUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastConnectivityUpdateUtc</c>
        /// </remarks>
        public static ResourceCollection GetByLastConnectivityUpdateUtc(System.DateTime lastConnectivityUpdateUtc, BootFX.Common.Data.SqlOperator lastConnectivityUpdateUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastConnectivityUpdateUtc", lastConnectivityUpdateUtcOperator, lastConnectivityUpdateUtc);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentMasterDataReleaseId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentMasterDataReleaseId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMasterDataReleaseId(int currentMasterDataReleaseId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByCurrentMasterDataReleaseId(currentMasterDataReleaseId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentMasterDataReleaseId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMasterDataReleaseId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMasterDataReleaseId(int currentMasterDataReleaseId, BootFX.Common.Data.SqlOperator currentMasterDataReleaseIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentMasterDataReleaseId", currentMasterDataReleaseIdOperator, currentMasterDataReleaseId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentMasterDataReleaseId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMasterDataReleaseId</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMasterDataReleaseId(int currentMasterDataReleaseId, BootFX.Common.Data.SqlOperator currentMasterDataReleaseIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentMasterDataReleaseId", currentMasterDataReleaseIdOperator, currentMasterDataReleaseId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where AutomaticReleaseUpdateOn is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>AutomaticReleaseUpdateOn</c>
        /// </remarks>
        public static ResourceCollection GetByAutomaticReleaseUpdateOn(bool automaticReleaseUpdateOn)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByAutomaticReleaseUpdateOn(automaticReleaseUpdateOn, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where AutomaticReleaseUpdateOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutomaticReleaseUpdateOn</c>
        /// </remarks>
        public static ResourceCollection GetByAutomaticReleaseUpdateOn(bool automaticReleaseUpdateOn, BootFX.Common.Data.SqlOperator automaticReleaseUpdateOnOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("AutomaticReleaseUpdateOn", automaticReleaseUpdateOnOperator, automaticReleaseUpdateOn);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where AutomaticReleaseUpdateOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutomaticReleaseUpdateOn</c>
        /// </remarks>
        public static ResourceCollection GetByAutomaticReleaseUpdateOn(bool automaticReleaseUpdateOn, BootFX.Common.Data.SqlOperator automaticReleaseUpdateOnOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("AutomaticReleaseUpdateOn", automaticReleaseUpdateOnOperator, automaticReleaseUpdateOn);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastTransactionUpdateUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastTransactionUpdateUtc</c>
        /// </remarks>
        public static ResourceCollection GetByLastTransactionUpdateUtc(System.DateTime lastTransactionUpdateUtc)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByLastTransactionUpdateUtc(lastTransactionUpdateUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastTransactionUpdateUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastTransactionUpdateUtc</c>
        /// </remarks>
        public static ResourceCollection GetByLastTransactionUpdateUtc(System.DateTime lastTransactionUpdateUtc, BootFX.Common.Data.SqlOperator lastTransactionUpdateUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastTransactionUpdateUtc", lastTransactionUpdateUtcOperator, lastTransactionUpdateUtc);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastTransactionUpdateUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastTransactionUpdateUtc</c>
        /// </remarks>
        public static ResourceCollection GetByLastTransactionUpdateUtc(System.DateTime lastTransactionUpdateUtc, BootFX.Common.Data.SqlOperator lastTransactionUpdateUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("LastTransactionUpdateUtc", lastTransactionUpdateUtcOperator, lastTransactionUpdateUtc);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MobileControllerLoggingOn is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MobileControllerLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileControllerLoggingOn(bool mobileControllerLoggingOn)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByMobileControllerLoggingOn(mobileControllerLoggingOn, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MobileControllerLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileControllerLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileControllerLoggingOn(bool mobileControllerLoggingOn, BootFX.Common.Data.SqlOperator mobileControllerLoggingOnOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MobileControllerLoggingOn", mobileControllerLoggingOnOperator, mobileControllerLoggingOn);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MobileControllerLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileControllerLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileControllerLoggingOn(bool mobileControllerLoggingOn, BootFX.Common.Data.SqlOperator mobileControllerLoggingOnOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MobileControllerLoggingOn", mobileControllerLoggingOnOperator, mobileControllerLoggingOn);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationGeneralLoggingOn is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MobileApplicationGeneralLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileApplicationGeneralLoggingOn(bool mobileApplicationGeneralLoggingOn)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByMobileApplicationGeneralLoggingOn(mobileApplicationGeneralLoggingOn, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationGeneralLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileApplicationGeneralLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileApplicationGeneralLoggingOn(bool mobileApplicationGeneralLoggingOn, BootFX.Common.Data.SqlOperator mobileApplicationGeneralLoggingOnOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MobileApplicationGeneralLoggingOn", mobileApplicationGeneralLoggingOnOperator, mobileApplicationGeneralLoggingOn);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationGeneralLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileApplicationGeneralLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileApplicationGeneralLoggingOn(bool mobileApplicationGeneralLoggingOn, BootFX.Common.Data.SqlOperator mobileApplicationGeneralLoggingOnOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MobileApplicationGeneralLoggingOn", mobileApplicationGeneralLoggingOnOperator, mobileApplicationGeneralLoggingOn);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationUpdateLoggingOn is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MobileApplicationUpdateLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileApplicationUpdateLoggingOn(bool mobileApplicationUpdateLoggingOn)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByMobileApplicationUpdateLoggingOn(mobileApplicationUpdateLoggingOn, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationUpdateLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileApplicationUpdateLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileApplicationUpdateLoggingOn(bool mobileApplicationUpdateLoggingOn, BootFX.Common.Data.SqlOperator mobileApplicationUpdateLoggingOnOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MobileApplicationUpdateLoggingOn", mobileApplicationUpdateLoggingOnOperator, mobileApplicationUpdateLoggingOn);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationUpdateLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileApplicationUpdateLoggingOn</c>
        /// </remarks>
        public static ResourceCollection GetByMobileApplicationUpdateLoggingOn(bool mobileApplicationUpdateLoggingOn, BootFX.Common.Data.SqlOperator mobileApplicationUpdateLoggingOnOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MobileApplicationUpdateLoggingOn", mobileApplicationUpdateLoggingOnOperator, mobileApplicationUpdateLoggingOn);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileControllerVersion is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentMobileControllerVersion</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileControllerVersion(string currentMobileControllerVersion)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByCurrentMobileControllerVersion(currentMobileControllerVersion, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileControllerVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileControllerVersion</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileControllerVersion(string currentMobileControllerVersion, BootFX.Common.Data.SqlOperator currentMobileControllerVersionOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentMobileControllerVersion", currentMobileControllerVersionOperator, currentMobileControllerVersion);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileControllerVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileControllerVersion</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileControllerVersion(string currentMobileControllerVersion, BootFX.Common.Data.SqlOperator currentMobileControllerVersionOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentMobileControllerVersion", currentMobileControllerVersionOperator, currentMobileControllerVersion);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MobileClientInitialization is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MobileClientInitialization</c>
        /// </remarks>
        public static ResourceCollection GetByMobileClientInitialization(int mobileClientInitialization)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByMobileClientInitialization(mobileClientInitialization, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MobileClientInitialization matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileClientInitialization</c>
        /// </remarks>
        public static ResourceCollection GetByMobileClientInitialization(int mobileClientInitialization, BootFX.Common.Data.SqlOperator mobileClientInitializationOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MobileClientInitialization", mobileClientInitializationOperator, mobileClientInitialization);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MobileClientInitialization matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileClientInitialization</c>
        /// </remarks>
        public static ResourceCollection GetByMobileClientInitialization(int mobileClientInitialization, BootFX.Common.Data.SqlOperator mobileClientInitializationOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MobileClientInitialization", mobileClientInitializationOperator, mobileClientInitialization);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MaxPdaHistoryInDays is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MaxPdaHistoryInDays</c>
        /// </remarks>
        public static ResourceCollection GetByMaxPdaHistoryInDays(int maxPdaHistoryInDays)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByMaxPdaHistoryInDays(maxPdaHistoryInDays, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MaxPdaHistoryInDays matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MaxPdaHistoryInDays</c>
        /// </remarks>
        public static ResourceCollection GetByMaxPdaHistoryInDays(int maxPdaHistoryInDays, BootFX.Common.Data.SqlOperator maxPdaHistoryInDaysOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MaxPdaHistoryInDays", maxPdaHistoryInDaysOperator, maxPdaHistoryInDays);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MaxPdaHistoryInDays matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MaxPdaHistoryInDays</c>
        /// </remarks>
        public static ResourceCollection GetByMaxPdaHistoryInDays(int maxPdaHistoryInDays, BootFX.Common.Data.SqlOperator maxPdaHistoryInDaysOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("MaxPdaHistoryInDays", maxPdaHistoryInDaysOperator, maxPdaHistoryInDays);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where SupervisorTelephone is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>SupervisorTelephone</c>
        /// </remarks>
        public static ResourceCollection GetBySupervisorTelephone(string supervisorTelephone)
        {
            return AmxMobile.PanicButton.Server.Resource.GetBySupervisorTelephone(supervisorTelephone, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where SupervisorTelephone matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>SupervisorTelephone</c>
        /// </remarks>
        public static ResourceCollection GetBySupervisorTelephone(string supervisorTelephone, BootFX.Common.Data.SqlOperator supervisorTelephoneOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("SupervisorTelephone", supervisorTelephoneOperator, supervisorTelephone);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where SupervisorTelephone matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>SupervisorTelephone</c>
        /// </remarks>
        public static ResourceCollection GetBySupervisorTelephone(string supervisorTelephone, BootFX.Common.Data.SqlOperator supervisorTelephoneOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("SupervisorTelephone", supervisorTelephoneOperator, supervisorTelephone);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where PinCodeEnabled is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>PinCodeEnabled</c>
        /// </remarks>
        public static ResourceCollection GetByPinCodeEnabled(bool pinCodeEnabled)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByPinCodeEnabled(pinCodeEnabled, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where PinCodeEnabled matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>PinCodeEnabled</c>
        /// </remarks>
        public static ResourceCollection GetByPinCodeEnabled(bool pinCodeEnabled, BootFX.Common.Data.SqlOperator pinCodeEnabledOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("PinCodeEnabled", pinCodeEnabledOperator, pinCodeEnabled);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where PinCodeEnabled matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>PinCodeEnabled</c>
        /// </remarks>
        public static ResourceCollection GetByPinCodeEnabled(bool pinCodeEnabled, BootFX.Common.Data.SqlOperator pinCodeEnabledOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("PinCodeEnabled", pinCodeEnabledOperator, pinCodeEnabled);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Locale is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Locale</c>
        /// </remarks>
        public static ResourceCollection GetByLocale(string locale)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByLocale(locale, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Locale matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Locale</c>
        /// </remarks>
        public static ResourceCollection GetByLocale(string locale, BootFX.Common.Data.SqlOperator localeOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("Locale", localeOperator, locale);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Locale matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Locale</c>
        /// </remarks>
        public static ResourceCollection GetByLocale(string locale, BootFX.Common.Data.SqlOperator localeOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("Locale", localeOperator, locale);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowVersion is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static ResourceCollection GetByRowVersion(int rowVersion)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByRowVersion(rowVersion, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static ResourceCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static ResourceCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static ResourceCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByRowCreatedUtc(rowCreatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static ResourceCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static ResourceCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static ResourceCollection GetByRowCreatedUserId(int rowCreatedUserId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByRowCreatedUserId(rowCreatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static ResourceCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static ResourceCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static ResourceCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByRowUpdatedUtc(rowUpdatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static ResourceCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static ResourceCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static ResourceCollection GetByRowUpdatedUserId(int rowUpdatedUserId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByRowUpdatedUserId(rowUpdatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static ResourceCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static ResourceCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static ResourceCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByRowLastTransactionId(rowLastTransactionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static ResourceCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static ResourceCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where SecurityGroupId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>SecurityGroupId</c>
        /// </remarks>
        public static ResourceCollection GetBySecurityGroupId(int securityGroupId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetBySecurityGroupId(securityGroupId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where SecurityGroupId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>SecurityGroupId</c>
        /// </remarks>
        public static ResourceCollection GetBySecurityGroupId(int securityGroupId, BootFX.Common.Data.SqlOperator securityGroupIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("SecurityGroupId", securityGroupIdOperator, securityGroupId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where SecurityGroupId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>SecurityGroupId</c>
        /// </remarks>
        public static ResourceCollection GetBySecurityGroupId(int securityGroupId, BootFX.Common.Data.SqlOperator securityGroupIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("SecurityGroupId", securityGroupIdOperator, securityGroupId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ContractGroupId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ContractGroupId</c>
        /// </remarks>
        public static ResourceCollection GetByContractGroupId(int contractGroupId)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByContractGroupId(contractGroupId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ContractGroupId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ContractGroupId</c>
        /// </remarks>
        public static ResourceCollection GetByContractGroupId(int contractGroupId, BootFX.Common.Data.SqlOperator contractGroupIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ContractGroupId", contractGroupIdOperator, contractGroupId);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ContractGroupId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ContractGroupId</c>
        /// </remarks>
        public static ResourceCollection GetByContractGroupId(int contractGroupId, BootFX.Common.Data.SqlOperator contractGroupIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ContractGroupId", contractGroupIdOperator, contractGroupId);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientName is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>TargetMobileClientName</c>
        /// </remarks>
        public static ResourceCollection GetByTargetMobileClientName(string targetMobileClientName)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByTargetMobileClientName(targetMobileClientName, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TargetMobileClientName</c>
        /// </remarks>
        public static ResourceCollection GetByTargetMobileClientName(string targetMobileClientName, BootFX.Common.Data.SqlOperator targetMobileClientNameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("TargetMobileClientName", targetMobileClientNameOperator, targetMobileClientName);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TargetMobileClientName</c>
        /// </remarks>
        public static ResourceCollection GetByTargetMobileClientName(string targetMobileClientName, BootFX.Common.Data.SqlOperator targetMobileClientNameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("TargetMobileClientName", targetMobileClientNameOperator, targetMobileClientName);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientName is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientName</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileClientName(string currentMobileClientName)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByCurrentMobileClientName(currentMobileClientName, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientName</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileClientName(string currentMobileClientName, BootFX.Common.Data.SqlOperator currentMobileClientNameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentMobileClientName", currentMobileClientNameOperator, currentMobileClientName);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientName</c>
        /// </remarks>
        public static ResourceCollection GetByCurrentMobileClientName(string currentMobileClientName, BootFX.Common.Data.SqlOperator currentMobileClientNameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("CurrentMobileClientName", currentMobileClientNameOperator, currentMobileClientName);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ForceCodeCapture is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - Resource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ForceCodeCapture</c>
        /// </remarks>
        public static ResourceCollection GetByForceCodeCapture(bool forceCodeCapture)
        {
            return AmxMobile.PanicButton.Server.Resource.GetByForceCodeCapture(forceCodeCapture, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ForceCodeCapture matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ForceCodeCapture</c>
        /// </remarks>
        public static ResourceCollection GetByForceCodeCapture(bool forceCodeCapture, BootFX.Common.Data.SqlOperator forceCodeCaptureOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ForceCodeCapture", forceCodeCaptureOperator, forceCodeCapture);
            return ((ResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ForceCodeCapture matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ForceCodeCapture</c>
        /// </remarks>
        public static ResourceCollection GetByForceCodeCapture(bool forceCodeCapture, BootFX.Common.Data.SqlOperator forceCodeCaptureOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(Resource));
            filter.Constraints.Add("ForceCodeCapture", forceCodeCaptureOperator, forceCodeCapture);
            ResourceCollection results = ((ResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Searches for <see cref="Resource"/> items with the given terms.
        /// </summary>
        public static ResourceCollection Search(string terms)
        {
            BootFX.Common.Data.SqlSearcher searcher = new BootFX.Common.Data.SqlSearcher(typeof(Resource), terms);
            return ((ResourceCollection)(searcher.ExecuteEntityCollection()));
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
