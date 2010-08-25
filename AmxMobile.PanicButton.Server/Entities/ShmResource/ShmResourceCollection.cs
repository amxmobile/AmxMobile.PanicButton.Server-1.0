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
    /// Defines the collection for entities of type <see cref="ShmResource"/>.
    /// </summary>
    [Serializable()]
    public class ShmResourceCollection : ShmResourceCollectionBase
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public ShmResourceCollection()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected ShmResourceCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
    }
}
