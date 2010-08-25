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
    /// Defines the base collection for entities of type <see cref="ShmResource"/>.
    /// </summary>
    [Serializable()]
    public abstract class ShmResourceCollectionBase : BootFX.Common.Entities.EntityCollection
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected ShmResourceCollectionBase() : 
                base(typeof(ShmResource))
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected ShmResourceCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the item with the given index.
        /// </summary>
        public ShmResource this[int index]
        {
            get
            {
                return ((ShmResource)(this.GetItem(index)));
            }
            set
            {
                this.SetItem(index, value);
            }
        }
        
        /// <summary>
        /// Adds a <see cref="ShmResource"/> instance to the collection.
        /// </summary>
        public int Add(ShmResource item)
        {
            return base.Add(item);
        }
        
        /// <summary>
        /// Adds a range of <see cref="ShmResource"/> instances to the collection.
        /// </summary>
        public void AddRange(ShmResource[] items)
        {
            base.AddRange(items);
        }
        
        /// <summary>
        /// Adds a range of <see cref="ShmResource"/> instances to the collection.
        /// </summary>
        public void AddRange(ShmResourceCollection items)
        {
            base.AddRange(items);
        }
    }
}
