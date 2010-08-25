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
    /// Defines the base collection for entities of type <see cref="CustomField"/>.
    /// </summary>
    [Serializable()]
    public abstract class CustomFieldCollectionBase : BootFX.Common.Entities.EntityCollection
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected CustomFieldCollectionBase() : 
                base(typeof(CustomField))
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected CustomFieldCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the item with the given index.
        /// </summary>
        public CustomField this[int index]
        {
            get
            {
                return ((CustomField)(this.GetItem(index)));
            }
            set
            {
                this.SetItem(index, value);
            }
        }
        
        /// <summary>
        /// Adds a <see cref="CustomField"/> instance to the collection.
        /// </summary>
        public int Add(CustomField item)
        {
            return base.Add(item);
        }
        
        /// <summary>
        /// Adds a range of <see cref="CustomField"/> instances to the collection.
        /// </summary>
        public void AddRange(CustomField[] items)
        {
            base.AddRange(items);
        }
        
        /// <summary>
        /// Adds a range of <see cref="CustomField"/> instances to the collection.
        /// </summary>
        public void AddRange(CustomFieldCollection items)
        {
            base.AddRange(items);
        }
    }
}
