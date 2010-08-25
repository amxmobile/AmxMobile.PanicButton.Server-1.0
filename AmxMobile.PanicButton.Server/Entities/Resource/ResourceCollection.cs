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
    /// Defines the collection for entities of type <see cref="Resource"/>.
    /// </summary>
    [Serializable()]
    public class ResourceCollection : ResourceCollectionBase
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public ResourceCollection()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected ResourceCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
    }
}
