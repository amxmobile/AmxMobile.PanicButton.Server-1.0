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
    /// Defines the collection for entities of type <see cref="TableCatalogItem"/>.
    /// </summary>
    [Serializable()]
    public class TableCatalogItemCollection : TableCatalogItemCollectionBase
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public TableCatalogItemCollection()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected TableCatalogItemCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
    }
}
