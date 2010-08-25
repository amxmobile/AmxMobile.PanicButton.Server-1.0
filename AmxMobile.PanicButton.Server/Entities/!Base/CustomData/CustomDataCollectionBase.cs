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
    /// Defines the base collection for entities of type <see cref="CustomData"/>.
    /// </summary>
    [Serializable()]
    public abstract class CustomDataCollectionBase : BootFX.Common.Entities.EntityCollection
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected CustomDataCollectionBase() : 
                base(typeof(CustomData))
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected CustomDataCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the item with the given index.
        /// </summary>
        public CustomData this[int index]
        {
            get
            {
                return ((CustomData)(this.GetItem(index)));
            }
            set
            {
                this.SetItem(index, value);
            }
        }
        
        /// <summary>
        /// Adds a <see cref="CustomData"/> instance to the collection.
        /// </summary>
        public int Add(CustomData item)
        {
            return base.Add(item);
        }
        
        /// <summary>
        /// Adds a range of <see cref="CustomData"/> instances to the collection.
        /// </summary>
        public void AddRange(CustomData[] items)
        {
            base.AddRange(items);
        }
        
        /// <summary>
        /// Adds a range of <see cref="CustomData"/> instances to the collection.
        /// </summary>
        public void AddRange(CustomDataCollection items)
        {
            base.AddRange(items);
        }
    }
}
