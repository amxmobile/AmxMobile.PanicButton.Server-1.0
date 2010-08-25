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
    /// Defines the base collection for entities of type <see cref="TableCatalogItem"/>.
    /// </summary>
    [Serializable()]
    public abstract class TableCatalogItemCollectionBase : BootFX.Common.Entities.EntityCollection
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected TableCatalogItemCollectionBase() : 
                base(typeof(TableCatalogItem))
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected TableCatalogItemCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the item with the given index.
        /// </summary>
        public TableCatalogItem this[int index]
        {
            get
            {
                return ((TableCatalogItem)(this.GetItem(index)));
            }
            set
            {
                this.SetItem(index, value);
            }
        }
        
        /// <summary>
        /// Adds a <see cref="TableCatalogItem"/> instance to the collection.
        /// </summary>
        public int Add(TableCatalogItem item)
        {
            return base.Add(item);
        }
        
        /// <summary>
        /// Adds a range of <see cref="TableCatalogItem"/> instances to the collection.
        /// </summary>
        public void AddRange(TableCatalogItem[] items)
        {
            base.AddRange(items);
        }
        
        /// <summary>
        /// Adds a range of <see cref="TableCatalogItem"/> instances to the collection.
        /// </summary>
        public void AddRange(TableCatalogItemCollection items)
        {
            base.AddRange(items);
        }
    }
}
