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
    /// Defines the entity type for 'ShmResources'.
    /// </summary>
    [Serializable()]
    [Entity(typeof(ResourceCollection), "ShmResources")]
    [SortSpecification(new string[] {
            "Name"}, new BootFX.Common.Data.SortDirection[] {
            BootFX.Common.Data.SortDirection.Ascending})]
    public class Resource : ResourceBase
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public Resource()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected Resource(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
    }
}
