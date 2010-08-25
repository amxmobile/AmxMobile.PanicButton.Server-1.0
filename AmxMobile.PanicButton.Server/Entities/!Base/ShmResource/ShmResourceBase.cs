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
    public abstract class ShmResourceBase : BootFX.Common.Entities.Entity
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected ShmResourceBase()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected ShmResourceBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
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
        /// Creates an SqlFilter for an instance of 'ShmResource'.
        /// </summary>
        public static BootFX.Common.Data.SqlFilter CreateFilter()
        {
            return new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
        }
        
        /// <summary>
        /// Sets properties on an instance of 'ShmResource'.
        /// </summary>
        public static void SetProperties(int resourceId, string[] propertyNames, object[] propertyValues)
        {
            ShmResource entity = AmxMobile.PanicButton.Server.ShmResource.GetById(resourceId);
            entity.SetProperties(entity, propertyNames, propertyValues);
            entity.SaveChanges();
        }
        
        /// <summary>
        /// Get all <see cref="ShmResource"/> entities.
        /// </summary>
        public static ShmResourceCollection GetAll()
        {
            BootFX.Common.Data.SqlFilter filter = BootFX.Common.Data.SqlFilter.CreateGetAllFilter(typeof(ShmResource));
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets the <see cref="ShmResource"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        public static ShmResource GetById(int resourceId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetById(resourceId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets the <see cref="ShmResource"/> entity where the ID matches the given specification.
        /// </summary>
        public static ShmResource GetById(int resourceId, BootFX.Common.Data.SqlOperator resourceIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ResourceId", resourceIdOperator, resourceId);
            return ((ShmResource)(filter.ExecuteEntity()));
        }
        
        /// <summary>
        /// Gets the <see cref="ShmResource"/> entity with the given ID.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        public static ShmResource GetById(int resourceId, BootFX.Common.OnNotFound onNotFound)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetById(resourceId, BootFX.Common.Data.SqlOperator.EqualTo, onNotFound);
        }
        
        /// <summary>
        /// Gets the <see cref="ShmResource"/> entity where the ID matches the given specification.
        /// </summary>
        public static ShmResource GetById(int resourceId, BootFX.Common.Data.SqlOperator resourceIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ResourceId", resourceIdOperator, resourceId);
            ShmResource results = ((ShmResource)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets an entity where CustomerId and ExternalId are equal to the given values.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for index <c>IX_ShmResources</c>.
        /// </remarks>
        public static ShmResource GetByCustomerIdAndExternalId(int customerId, string externalId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByCustomerIdAndExternalId(customerId, externalId, BootFX.Common.OnNotFound.ReturnNull);
        }
        
        /// <summary>
        /// Gets an entity where CustomerId and ExternalId are equal to the given values.
        /// </summary>
        /// <remarks>
        /// Created for index <c>IX_ShmResources</c>.
        /// </remarks>
        public static ShmResource GetByCustomerIdAndExternalId(int customerId, string externalId, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CustomerId", BootFX.Common.Data.SqlOperator.EqualTo, customerId);
            filter.Constraints.Add("ExternalId", BootFX.Common.Data.SqlOperator.EqualTo, externalId);
            ShmResource results = ((ShmResource)(filter.ExecuteEntity()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CustomerId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CustomerId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCustomerId(int customerId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByCustomerId(customerId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CustomerId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CustomerId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCustomerId(int customerId, BootFX.Common.Data.SqlOperator customerIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CustomerId", customerIdOperator, customerId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CustomerId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CustomerId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCustomerId(int customerId, BootFX.Common.Data.SqlOperator customerIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CustomerId", customerIdOperator, customerId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ExternalId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ExternalId</c>
        /// </remarks>
        public static ShmResourceCollection GetByExternalId(string externalId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByExternalId(externalId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ExternalId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ExternalId</c>
        /// </remarks>
        public static ShmResourceCollection GetByExternalId(string externalId, BootFX.Common.Data.SqlOperator externalIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ExternalId", externalIdOperator, externalId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ExternalId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ExternalId</c>
        /// </remarks>
        public static ShmResourceCollection GetByExternalId(string externalId, BootFX.Common.Data.SqlOperator externalIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ExternalId", externalIdOperator, externalId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Name is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static ShmResourceCollection GetByName(string name)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByName(name, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Name matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static ShmResourceCollection GetByName(string name, BootFX.Common.Data.SqlOperator nameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("Name", nameOperator, name);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Name matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Name</c>
        /// </remarks>
        public static ShmResourceCollection GetByName(string name, BootFX.Common.Data.SqlOperator nameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("Name", nameOperator, name);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where IsActive is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static ShmResourceCollection GetByIsActive(bool isActive)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByIsActive(isActive, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where IsActive matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static ShmResourceCollection GetByIsActive(bool isActive, BootFX.Common.Data.SqlOperator isActiveOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("IsActive", isActiveOperator, isActive);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where IsActive matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>IsActive</c>
        /// </remarks>
        public static ShmResourceCollection GetByIsActive(bool isActive, BootFX.Common.Data.SqlOperator isActiveOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("IsActive", isActiveOperator, isActive);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where AutoAccept is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>AutoAccept</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutoAccept(bool autoAccept)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByAutoAccept(autoAccept, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where AutoAccept matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutoAccept</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutoAccept(bool autoAccept, BootFX.Common.Data.SqlOperator autoAcceptOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("AutoAccept", autoAcceptOperator, autoAccept);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where AutoAccept matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutoAccept</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutoAccept(bool autoAccept, BootFX.Common.Data.SqlOperator autoAcceptOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("AutoAccept", autoAcceptOperator, autoAccept);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where AutoRefresh is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>AutoRefresh</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutoRefresh(bool autoRefresh)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByAutoRefresh(autoRefresh, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where AutoRefresh matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutoRefresh</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutoRefresh(bool autoRefresh, BootFX.Common.Data.SqlOperator autoRefreshOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("AutoRefresh", autoRefreshOperator, autoRefresh);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where AutoRefresh matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutoRefresh</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutoRefresh(bool autoRefresh, BootFX.Common.Data.SqlOperator autoRefreshOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("AutoRefresh", autoRefreshOperator, autoRefresh);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where NumSentOk is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>NumSentOk</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumSentOk(int numSentOk)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByNumSentOk(numSentOk, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where NumSentOk matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumSentOk</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumSentOk(int numSentOk, BootFX.Common.Data.SqlOperator numSentOkOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("NumSentOk", numSentOkOperator, numSentOk);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where NumSentOk matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumSentOk</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumSentOk(int numSentOk, BootFX.Common.Data.SqlOperator numSentOkOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("NumSentOk", numSentOkOperator, numSentOk);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastSentOk is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastSentOk</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastSentOk(System.DateTime lastSentOk)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByLastSentOk(lastSentOk, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastSentOk matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastSentOk</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastSentOk(System.DateTime lastSentOk, BootFX.Common.Data.SqlOperator lastSentOkOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastSentOk", lastSentOkOperator, lastSentOk);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastSentOk matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastSentOk</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastSentOk(System.DateTime lastSentOk, BootFX.Common.Data.SqlOperator lastSentOkOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastSentOk", lastSentOkOperator, lastSentOk);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where NumBounced is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>NumBounced</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumBounced(int numBounced)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByNumBounced(numBounced, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where NumBounced matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumBounced</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumBounced(int numBounced, BootFX.Common.Data.SqlOperator numBouncedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("NumBounced", numBouncedOperator, numBounced);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where NumBounced matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumBounced</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumBounced(int numBounced, BootFX.Common.Data.SqlOperator numBouncedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("NumBounced", numBouncedOperator, numBounced);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastBounced is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastBounced</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastBounced(System.DateTime lastBounced)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByLastBounced(lastBounced, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastBounced matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastBounced</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastBounced(System.DateTime lastBounced, BootFX.Common.Data.SqlOperator lastBouncedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastBounced", lastBouncedOperator, lastBounced);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastBounced matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastBounced</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastBounced(System.DateTime lastBounced, BootFX.Common.Data.SqlOperator lastBouncedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastBounced", lastBouncedOperator, lastBounced);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where NumReceiveFailed is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>NumReceiveFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumReceiveFailed(int numReceiveFailed)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByNumReceiveFailed(numReceiveFailed, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where NumReceiveFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumReceiveFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumReceiveFailed(int numReceiveFailed, BootFX.Common.Data.SqlOperator numReceiveFailedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("NumReceiveFailed", numReceiveFailedOperator, numReceiveFailed);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where NumReceiveFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumReceiveFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumReceiveFailed(int numReceiveFailed, BootFX.Common.Data.SqlOperator numReceiveFailedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("NumReceiveFailed", numReceiveFailedOperator, numReceiveFailed);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastReceiveFailed is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastReceiveFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastReceiveFailed(System.DateTime lastReceiveFailed)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByLastReceiveFailed(lastReceiveFailed, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastReceiveFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastReceiveFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastReceiveFailed(System.DateTime lastReceiveFailed, BootFX.Common.Data.SqlOperator lastReceiveFailedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastReceiveFailed", lastReceiveFailedOperator, lastReceiveFailed);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastReceiveFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastReceiveFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastReceiveFailed(System.DateTime lastReceiveFailed, BootFX.Common.Data.SqlOperator lastReceiveFailedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastReceiveFailed", lastReceiveFailedOperator, lastReceiveFailed);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where NumSendFailed is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>NumSendFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumSendFailed(int numSendFailed)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByNumSendFailed(numSendFailed, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where NumSendFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumSendFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumSendFailed(int numSendFailed, BootFX.Common.Data.SqlOperator numSendFailedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("NumSendFailed", numSendFailedOperator, numSendFailed);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where NumSendFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>NumSendFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByNumSendFailed(int numSendFailed, BootFX.Common.Data.SqlOperator numSendFailedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("NumSendFailed", numSendFailedOperator, numSendFailed);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastSendFailed is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastSendFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastSendFailed(System.DateTime lastSendFailed)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByLastSendFailed(lastSendFailed, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastSendFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastSendFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastSendFailed(System.DateTime lastSendFailed, BootFX.Common.Data.SqlOperator lastSendFailedOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastSendFailed", lastSendFailedOperator, lastSendFailed);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastSendFailed matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastSendFailed</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastSendFailed(System.DateTime lastSendFailed, BootFX.Common.Data.SqlOperator lastSendFailedOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastSendFailed", lastSendFailedOperator, lastSendFailed);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentState is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentState</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentState(int currentState)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByCurrentState(currentState, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentState matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentState</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentState(int currentState, BootFX.Common.Data.SqlOperator currentStateOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentState", currentStateOperator, currentState);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentState matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentState</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentState(int currentState, BootFX.Common.Data.SqlOperator currentStateOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentState", currentStateOperator, currentState);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MaxToSignal is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MaxToSignal</c>
        /// </remarks>
        public static ShmResourceCollection GetByMaxToSignal(int maxToSignal)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByMaxToSignal(maxToSignal, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MaxToSignal matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MaxToSignal</c>
        /// </remarks>
        public static ShmResourceCollection GetByMaxToSignal(int maxToSignal, BootFX.Common.Data.SqlOperator maxToSignalOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MaxToSignal", maxToSignalOperator, maxToSignal);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MaxToSignal matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MaxToSignal</c>
        /// </remarks>
        public static ShmResourceCollection GetByMaxToSignal(int maxToSignal, BootFX.Common.Data.SqlOperator maxToSignalOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MaxToSignal", maxToSignalOperator, maxToSignal);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Active is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Active</c>
        /// </remarks>
        public static ShmResourceCollection GetByActive(bool active)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByActive(active, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Active matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Active</c>
        /// </remarks>
        public static ShmResourceCollection GetByActive(bool active, BootFX.Common.Data.SqlOperator activeOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("Active", activeOperator, active);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Active matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Active</c>
        /// </remarks>
        public static ShmResourceCollection GetByActive(bool active, BootFX.Common.Data.SqlOperator activeOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("Active", activeOperator, active);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ResourceSubCategoryId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ResourceSubCategoryId</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceSubCategoryId(int resourceSubCategoryId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByResourceSubCategoryId(resourceSubCategoryId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ResourceSubCategoryId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceSubCategoryId</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceSubCategoryId(int resourceSubCategoryId, BootFX.Common.Data.SqlOperator resourceSubCategoryIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ResourceSubCategoryId", resourceSubCategoryIdOperator, resourceSubCategoryId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ResourceSubCategoryId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceSubCategoryId</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceSubCategoryId(int resourceSubCategoryId, BootFX.Common.Data.SqlOperator resourceSubCategoryIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ResourceSubCategoryId", resourceSubCategoryIdOperator, resourceSubCategoryId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ResourceType is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ResourceType</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceType(int resourceType)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByResourceType(resourceType, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ResourceType matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceType</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceType(int resourceType, BootFX.Common.Data.SqlOperator resourceTypeOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ResourceType", resourceTypeOperator, resourceType);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ResourceType matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceType</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceType(int resourceType, BootFX.Common.Data.SqlOperator resourceTypeOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ResourceType", resourceTypeOperator, resourceType);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ProfileId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ProfileId</c>
        /// </remarks>
        public static ShmResourceCollection GetByProfileId(int profileId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByProfileId(profileId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ProfileId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ProfileId</c>
        /// </remarks>
        public static ShmResourceCollection GetByProfileId(int profileId, BootFX.Common.Data.SqlOperator profileIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ProfileId", profileIdOperator, profileId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ProfileId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ProfileId</c>
        /// </remarks>
        public static ShmResourceCollection GetByProfileId(int profileId, BootFX.Common.Data.SqlOperator profileIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ProfileId", profileIdOperator, profileId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Password is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Password</c>
        /// </remarks>
        public static ShmResourceCollection GetByPassword(string password)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByPassword(password, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Password matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Password</c>
        /// </remarks>
        public static ShmResourceCollection GetByPassword(string password, BootFX.Common.Data.SqlOperator passwordOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("Password", passwordOperator, password);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Password matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Password</c>
        /// </remarks>
        public static ShmResourceCollection GetByPassword(string password, BootFX.Common.Data.SqlOperator passwordOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("Password", passwordOperator, password);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ResourceCategoryId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ResourceCategoryId</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceCategoryId(int resourceCategoryId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByResourceCategoryId(resourceCategoryId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ResourceCategoryId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceCategoryId</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceCategoryId(int resourceCategoryId, BootFX.Common.Data.SqlOperator resourceCategoryIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ResourceCategoryId", resourceCategoryIdOperator, resourceCategoryId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ResourceCategoryId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ResourceCategoryId</c>
        /// </remarks>
        public static ShmResourceCollection GetByResourceCategoryId(int resourceCategoryId, BootFX.Common.Data.SqlOperator resourceCategoryIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ResourceCategoryId", resourceCategoryIdOperator, resourceCategoryId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where OrganisationalGroup is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>OrganisationalGroup</c>
        /// </remarks>
        public static ShmResourceCollection GetByOrganisationalGroup(string organisationalGroup)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByOrganisationalGroup(organisationalGroup, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where OrganisationalGroup matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>OrganisationalGroup</c>
        /// </remarks>
        public static ShmResourceCollection GetByOrganisationalGroup(string organisationalGroup, BootFX.Common.Data.SqlOperator organisationalGroupOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("OrganisationalGroup", organisationalGroupOperator, organisationalGroup);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where OrganisationalGroup matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>OrganisationalGroup</c>
        /// </remarks>
        public static ShmResourceCollection GetByOrganisationalGroup(string organisationalGroup, BootFX.Common.Data.SqlOperator organisationalGroupOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("OrganisationalGroup", organisationalGroupOperator, organisationalGroup);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentConfigurationReleaseId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentConfigurationReleaseId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentConfigurationReleaseId(int currentConfigurationReleaseId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByCurrentConfigurationReleaseId(currentConfigurationReleaseId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentConfigurationReleaseId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentConfigurationReleaseId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentConfigurationReleaseId(int currentConfigurationReleaseId, BootFX.Common.Data.SqlOperator currentConfigurationReleaseIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentConfigurationReleaseId", currentConfigurationReleaseIdOperator, currentConfigurationReleaseId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentConfigurationReleaseId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentConfigurationReleaseId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentConfigurationReleaseId(int currentConfigurationReleaseId, BootFX.Common.Data.SqlOperator currentConfigurationReleaseIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentConfigurationReleaseId", currentConfigurationReleaseIdOperator, currentConfigurationReleaseId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientVersionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>TargetMobileClientVersionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByTargetMobileClientVersionId(int targetMobileClientVersionId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByTargetMobileClientVersionId(targetMobileClientVersionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientVersionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TargetMobileClientVersionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByTargetMobileClientVersionId(int targetMobileClientVersionId, BootFX.Common.Data.SqlOperator targetMobileClientVersionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("TargetMobileClientVersionId", targetMobileClientVersionIdOperator, targetMobileClientVersionId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientVersionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TargetMobileClientVersionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByTargetMobileClientVersionId(int targetMobileClientVersionId, BootFX.Common.Data.SqlOperator targetMobileClientVersionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("TargetMobileClientVersionId", targetMobileClientVersionIdOperator, targetMobileClientVersionId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientVersionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientVersionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileClientVersionId(int currentMobileClientVersionId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByCurrentMobileClientVersionId(currentMobileClientVersionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientVersionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientVersionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileClientVersionId(int currentMobileClientVersionId, BootFX.Common.Data.SqlOperator currentMobileClientVersionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentMobileClientVersionId", currentMobileClientVersionIdOperator, currentMobileClientVersionId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientVersionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientVersionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileClientVersionId(int currentMobileClientVersionId, BootFX.Common.Data.SqlOperator currentMobileClientVersionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentMobileClientVersionId", currentMobileClientVersionIdOperator, currentMobileClientVersionId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastConnectivityUpdateUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastConnectivityUpdateUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastConnectivityUpdateUtc(System.DateTime lastConnectivityUpdateUtc)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByLastConnectivityUpdateUtc(lastConnectivityUpdateUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastConnectivityUpdateUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastConnectivityUpdateUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastConnectivityUpdateUtc(System.DateTime lastConnectivityUpdateUtc, BootFX.Common.Data.SqlOperator lastConnectivityUpdateUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastConnectivityUpdateUtc", lastConnectivityUpdateUtcOperator, lastConnectivityUpdateUtc);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastConnectivityUpdateUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastConnectivityUpdateUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastConnectivityUpdateUtc(System.DateTime lastConnectivityUpdateUtc, BootFX.Common.Data.SqlOperator lastConnectivityUpdateUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastConnectivityUpdateUtc", lastConnectivityUpdateUtcOperator, lastConnectivityUpdateUtc);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentMasterDataReleaseId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentMasterDataReleaseId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMasterDataReleaseId(int currentMasterDataReleaseId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByCurrentMasterDataReleaseId(currentMasterDataReleaseId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentMasterDataReleaseId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMasterDataReleaseId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMasterDataReleaseId(int currentMasterDataReleaseId, BootFX.Common.Data.SqlOperator currentMasterDataReleaseIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentMasterDataReleaseId", currentMasterDataReleaseIdOperator, currentMasterDataReleaseId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentMasterDataReleaseId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMasterDataReleaseId</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMasterDataReleaseId(int currentMasterDataReleaseId, BootFX.Common.Data.SqlOperator currentMasterDataReleaseIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentMasterDataReleaseId", currentMasterDataReleaseIdOperator, currentMasterDataReleaseId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where AutomaticReleaseUpdateOn is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>AutomaticReleaseUpdateOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutomaticReleaseUpdateOn(bool automaticReleaseUpdateOn)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByAutomaticReleaseUpdateOn(automaticReleaseUpdateOn, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where AutomaticReleaseUpdateOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutomaticReleaseUpdateOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutomaticReleaseUpdateOn(bool automaticReleaseUpdateOn, BootFX.Common.Data.SqlOperator automaticReleaseUpdateOnOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("AutomaticReleaseUpdateOn", automaticReleaseUpdateOnOperator, automaticReleaseUpdateOn);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where AutomaticReleaseUpdateOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>AutomaticReleaseUpdateOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByAutomaticReleaseUpdateOn(bool automaticReleaseUpdateOn, BootFX.Common.Data.SqlOperator automaticReleaseUpdateOnOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("AutomaticReleaseUpdateOn", automaticReleaseUpdateOnOperator, automaticReleaseUpdateOn);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where LastTransactionUpdateUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>LastTransactionUpdateUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastTransactionUpdateUtc(System.DateTime lastTransactionUpdateUtc)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByLastTransactionUpdateUtc(lastTransactionUpdateUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where LastTransactionUpdateUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastTransactionUpdateUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastTransactionUpdateUtc(System.DateTime lastTransactionUpdateUtc, BootFX.Common.Data.SqlOperator lastTransactionUpdateUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastTransactionUpdateUtc", lastTransactionUpdateUtcOperator, lastTransactionUpdateUtc);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where LastTransactionUpdateUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>LastTransactionUpdateUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByLastTransactionUpdateUtc(System.DateTime lastTransactionUpdateUtc, BootFX.Common.Data.SqlOperator lastTransactionUpdateUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("LastTransactionUpdateUtc", lastTransactionUpdateUtcOperator, lastTransactionUpdateUtc);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MobileControllerLoggingOn is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MobileControllerLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileControllerLoggingOn(bool mobileControllerLoggingOn)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByMobileControllerLoggingOn(mobileControllerLoggingOn, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MobileControllerLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileControllerLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileControllerLoggingOn(bool mobileControllerLoggingOn, BootFX.Common.Data.SqlOperator mobileControllerLoggingOnOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MobileControllerLoggingOn", mobileControllerLoggingOnOperator, mobileControllerLoggingOn);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MobileControllerLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileControllerLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileControllerLoggingOn(bool mobileControllerLoggingOn, BootFX.Common.Data.SqlOperator mobileControllerLoggingOnOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MobileControllerLoggingOn", mobileControllerLoggingOnOperator, mobileControllerLoggingOn);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationGeneralLoggingOn is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MobileApplicationGeneralLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileApplicationGeneralLoggingOn(bool mobileApplicationGeneralLoggingOn)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByMobileApplicationGeneralLoggingOn(mobileApplicationGeneralLoggingOn, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationGeneralLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileApplicationGeneralLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileApplicationGeneralLoggingOn(bool mobileApplicationGeneralLoggingOn, BootFX.Common.Data.SqlOperator mobileApplicationGeneralLoggingOnOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MobileApplicationGeneralLoggingOn", mobileApplicationGeneralLoggingOnOperator, mobileApplicationGeneralLoggingOn);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationGeneralLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileApplicationGeneralLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileApplicationGeneralLoggingOn(bool mobileApplicationGeneralLoggingOn, BootFX.Common.Data.SqlOperator mobileApplicationGeneralLoggingOnOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MobileApplicationGeneralLoggingOn", mobileApplicationGeneralLoggingOnOperator, mobileApplicationGeneralLoggingOn);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationUpdateLoggingOn is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MobileApplicationUpdateLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileApplicationUpdateLoggingOn(bool mobileApplicationUpdateLoggingOn)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByMobileApplicationUpdateLoggingOn(mobileApplicationUpdateLoggingOn, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationUpdateLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileApplicationUpdateLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileApplicationUpdateLoggingOn(bool mobileApplicationUpdateLoggingOn, BootFX.Common.Data.SqlOperator mobileApplicationUpdateLoggingOnOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MobileApplicationUpdateLoggingOn", mobileApplicationUpdateLoggingOnOperator, mobileApplicationUpdateLoggingOn);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MobileApplicationUpdateLoggingOn matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileApplicationUpdateLoggingOn</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileApplicationUpdateLoggingOn(bool mobileApplicationUpdateLoggingOn, BootFX.Common.Data.SqlOperator mobileApplicationUpdateLoggingOnOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MobileApplicationUpdateLoggingOn", mobileApplicationUpdateLoggingOnOperator, mobileApplicationUpdateLoggingOn);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileControllerVersion is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentMobileControllerVersion</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileControllerVersion(string currentMobileControllerVersion)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByCurrentMobileControllerVersion(currentMobileControllerVersion, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileControllerVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileControllerVersion</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileControllerVersion(string currentMobileControllerVersion, BootFX.Common.Data.SqlOperator currentMobileControllerVersionOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentMobileControllerVersion", currentMobileControllerVersionOperator, currentMobileControllerVersion);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileControllerVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileControllerVersion</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileControllerVersion(string currentMobileControllerVersion, BootFX.Common.Data.SqlOperator currentMobileControllerVersionOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentMobileControllerVersion", currentMobileControllerVersionOperator, currentMobileControllerVersion);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MobileClientInitialization is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MobileClientInitialization</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileClientInitialization(int mobileClientInitialization)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByMobileClientInitialization(mobileClientInitialization, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MobileClientInitialization matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileClientInitialization</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileClientInitialization(int mobileClientInitialization, BootFX.Common.Data.SqlOperator mobileClientInitializationOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MobileClientInitialization", mobileClientInitializationOperator, mobileClientInitialization);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MobileClientInitialization matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MobileClientInitialization</c>
        /// </remarks>
        public static ShmResourceCollection GetByMobileClientInitialization(int mobileClientInitialization, BootFX.Common.Data.SqlOperator mobileClientInitializationOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MobileClientInitialization", mobileClientInitializationOperator, mobileClientInitialization);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where MaxPdaHistoryInDays is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>MaxPdaHistoryInDays</c>
        /// </remarks>
        public static ShmResourceCollection GetByMaxPdaHistoryInDays(int maxPdaHistoryInDays)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByMaxPdaHistoryInDays(maxPdaHistoryInDays, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where MaxPdaHistoryInDays matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MaxPdaHistoryInDays</c>
        /// </remarks>
        public static ShmResourceCollection GetByMaxPdaHistoryInDays(int maxPdaHistoryInDays, BootFX.Common.Data.SqlOperator maxPdaHistoryInDaysOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MaxPdaHistoryInDays", maxPdaHistoryInDaysOperator, maxPdaHistoryInDays);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where MaxPdaHistoryInDays matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>MaxPdaHistoryInDays</c>
        /// </remarks>
        public static ShmResourceCollection GetByMaxPdaHistoryInDays(int maxPdaHistoryInDays, BootFX.Common.Data.SqlOperator maxPdaHistoryInDaysOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("MaxPdaHistoryInDays", maxPdaHistoryInDaysOperator, maxPdaHistoryInDays);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where SupervisorTelephone is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>SupervisorTelephone</c>
        /// </remarks>
        public static ShmResourceCollection GetBySupervisorTelephone(string supervisorTelephone)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetBySupervisorTelephone(supervisorTelephone, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where SupervisorTelephone matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>SupervisorTelephone</c>
        /// </remarks>
        public static ShmResourceCollection GetBySupervisorTelephone(string supervisorTelephone, BootFX.Common.Data.SqlOperator supervisorTelephoneOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("SupervisorTelephone", supervisorTelephoneOperator, supervisorTelephone);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where SupervisorTelephone matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>SupervisorTelephone</c>
        /// </remarks>
        public static ShmResourceCollection GetBySupervisorTelephone(string supervisorTelephone, BootFX.Common.Data.SqlOperator supervisorTelephoneOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("SupervisorTelephone", supervisorTelephoneOperator, supervisorTelephone);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where PinCodeEnabled is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>PinCodeEnabled</c>
        /// </remarks>
        public static ShmResourceCollection GetByPinCodeEnabled(bool pinCodeEnabled)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByPinCodeEnabled(pinCodeEnabled, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where PinCodeEnabled matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>PinCodeEnabled</c>
        /// </remarks>
        public static ShmResourceCollection GetByPinCodeEnabled(bool pinCodeEnabled, BootFX.Common.Data.SqlOperator pinCodeEnabledOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("PinCodeEnabled", pinCodeEnabledOperator, pinCodeEnabled);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where PinCodeEnabled matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>PinCodeEnabled</c>
        /// </remarks>
        public static ShmResourceCollection GetByPinCodeEnabled(bool pinCodeEnabled, BootFX.Common.Data.SqlOperator pinCodeEnabledOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("PinCodeEnabled", pinCodeEnabledOperator, pinCodeEnabled);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where Locale is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>Locale</c>
        /// </remarks>
        public static ShmResourceCollection GetByLocale(string locale)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByLocale(locale, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where Locale matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Locale</c>
        /// </remarks>
        public static ShmResourceCollection GetByLocale(string locale, BootFX.Common.Data.SqlOperator localeOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("Locale", localeOperator, locale);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where Locale matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>Locale</c>
        /// </remarks>
        public static ShmResourceCollection GetByLocale(string locale, BootFX.Common.Data.SqlOperator localeOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("Locale", localeOperator, locale);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowVersion is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowVersion(int rowVersion)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByRowVersion(rowVersion, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowVersion matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowVersion</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowVersion(int rowVersion, BootFX.Common.Data.SqlOperator rowVersionOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowVersion", rowVersionOperator, rowVersion);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByRowCreatedUtc(rowCreatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowCreatedUtc(System.DateTime rowCreatedUtc, BootFX.Common.Data.SqlOperator rowCreatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowCreatedUtc", rowCreatedUtcOperator, rowCreatedUtc);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowCreatedUserId(int rowCreatedUserId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByRowCreatedUserId(rowCreatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowCreatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowCreatedUserId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowCreatedUserId(int rowCreatedUserId, BootFX.Common.Data.SqlOperator rowCreatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowCreatedUserId", rowCreatedUserIdOperator, rowCreatedUserId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByRowUpdatedUtc(rowUpdatedUtc, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUtc matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUtc</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowUpdatedUtc(System.DateTime rowUpdatedUtc, BootFX.Common.Data.SqlOperator rowUpdatedUtcOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowUpdatedUtc", rowUpdatedUtcOperator, rowUpdatedUtc);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowUpdatedUserId(int rowUpdatedUserId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByRowUpdatedUserId(rowUpdatedUserId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowUpdatedUserId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowUpdatedUserId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowUpdatedUserId(int rowUpdatedUserId, BootFX.Common.Data.SqlOperator rowUpdatedUserIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowUpdatedUserId", rowUpdatedUserIdOperator, rowUpdatedUserId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByRowLastTransactionId(rowLastTransactionId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where RowLastTransactionId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>RowLastTransactionId</c>
        /// </remarks>
        public static ShmResourceCollection GetByRowLastTransactionId(System.Guid rowLastTransactionId, BootFX.Common.Data.SqlOperator rowLastTransactionIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("RowLastTransactionId", rowLastTransactionIdOperator, rowLastTransactionId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where SecurityGroupId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>SecurityGroupId</c>
        /// </remarks>
        public static ShmResourceCollection GetBySecurityGroupId(int securityGroupId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetBySecurityGroupId(securityGroupId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where SecurityGroupId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>SecurityGroupId</c>
        /// </remarks>
        public static ShmResourceCollection GetBySecurityGroupId(int securityGroupId, BootFX.Common.Data.SqlOperator securityGroupIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("SecurityGroupId", securityGroupIdOperator, securityGroupId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where SecurityGroupId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>SecurityGroupId</c>
        /// </remarks>
        public static ShmResourceCollection GetBySecurityGroupId(int securityGroupId, BootFX.Common.Data.SqlOperator securityGroupIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("SecurityGroupId", securityGroupIdOperator, securityGroupId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ContractGroupId is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ContractGroupId</c>
        /// </remarks>
        public static ShmResourceCollection GetByContractGroupId(int contractGroupId)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByContractGroupId(contractGroupId, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ContractGroupId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ContractGroupId</c>
        /// </remarks>
        public static ShmResourceCollection GetByContractGroupId(int contractGroupId, BootFX.Common.Data.SqlOperator contractGroupIdOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ContractGroupId", contractGroupIdOperator, contractGroupId);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ContractGroupId matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ContractGroupId</c>
        /// </remarks>
        public static ShmResourceCollection GetByContractGroupId(int contractGroupId, BootFX.Common.Data.SqlOperator contractGroupIdOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ContractGroupId", contractGroupIdOperator, contractGroupId);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientName is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>TargetMobileClientName</c>
        /// </remarks>
        public static ShmResourceCollection GetByTargetMobileClientName(string targetMobileClientName)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByTargetMobileClientName(targetMobileClientName, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TargetMobileClientName</c>
        /// </remarks>
        public static ShmResourceCollection GetByTargetMobileClientName(string targetMobileClientName, BootFX.Common.Data.SqlOperator targetMobileClientNameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("TargetMobileClientName", targetMobileClientNameOperator, targetMobileClientName);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where TargetMobileClientName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>TargetMobileClientName</c>
        /// </remarks>
        public static ShmResourceCollection GetByTargetMobileClientName(string targetMobileClientName, BootFX.Common.Data.SqlOperator targetMobileClientNameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("TargetMobileClientName", targetMobileClientNameOperator, targetMobileClientName);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientName is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientName</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileClientName(string currentMobileClientName)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByCurrentMobileClientName(currentMobileClientName, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientName</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileClientName(string currentMobileClientName, BootFX.Common.Data.SqlOperator currentMobileClientNameOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentMobileClientName", currentMobileClientNameOperator, currentMobileClientName);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where CurrentMobileClientName matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>CurrentMobileClientName</c>
        /// </remarks>
        public static ShmResourceCollection GetByCurrentMobileClientName(string currentMobileClientName, BootFX.Common.Data.SqlOperator currentMobileClientNameOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("CurrentMobileClientName", currentMobileClientNameOperator, currentMobileClientName);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Gets entities where ForceCodeCapture is equal to the given value.
        /// </summary>
        /// <bootfx>
        /// CreateEntityFilterEqualToMethod - ShmResource
        /// </bootfx>
        /// <remarks>
        /// Created for column <c>ForceCodeCapture</c>
        /// </remarks>
        public static ShmResourceCollection GetByForceCodeCapture(bool forceCodeCapture)
        {
            return AmxMobile.PanicButton.Server.ShmResource.GetByForceCodeCapture(forceCodeCapture, BootFX.Common.Data.SqlOperator.EqualTo);
        }
        
        /// <summary>
        /// Gets entities where ForceCodeCapture matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ForceCodeCapture</c>
        /// </remarks>
        public static ShmResourceCollection GetByForceCodeCapture(bool forceCodeCapture, BootFX.Common.Data.SqlOperator forceCodeCaptureOperator)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ForceCodeCapture", forceCodeCaptureOperator, forceCodeCapture);
            return ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
        }
        
        /// <summary>
        /// Gets entities where ForceCodeCapture matches the given specification.
        /// </summary>
        /// <remarks>
        /// Created for column <c>ForceCodeCapture</c>
        /// </remarks>
        public static ShmResourceCollection GetByForceCodeCapture(bool forceCodeCapture, BootFX.Common.Data.SqlOperator forceCodeCaptureOperator, BootFX.Common.OnNotFound onNotFound)
        {
            BootFX.Common.Data.SqlFilter filter = new BootFX.Common.Data.SqlFilter(typeof(ShmResource));
            filter.Constraints.Add("ForceCodeCapture", forceCodeCaptureOperator, forceCodeCapture);
            ShmResourceCollection results = ((ShmResourceCollection)(filter.ExecuteEntityCollection()));
            return results;
        }
        
        /// <summary>
        /// Searches for <see cref="ShmResource"/> items with the given terms.
        /// </summary>
        public static ShmResourceCollection Search(string terms)
        {
            BootFX.Common.Data.SqlSearcher searcher = new BootFX.Common.Data.SqlSearcher(typeof(ShmResource), terms);
            return ((ShmResourceCollection)(searcher.ExecuteEntityCollection()));
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
