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
    /// Defines the entity type for 'CustomData'.
    /// </summary>
    [Serializable()]
    [Entity(typeof(CustomDataCollection), "CustomData")]
    public class CustomData : CustomDataBase
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public CustomData()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected CustomData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
    }
}
