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
    /// Defines the base collection for entities of type <see cref="Resource"/>.
    /// </summary>
    [Serializable()]
    public abstract class ResourceCollectionBase : BootFX.Common.Entities.EntityCollection
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        protected ResourceCollectionBase() : 
                base(typeof(Resource))
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected ResourceCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
        
        /// <summary>
        /// Gets or sets the item with the given index.
        /// </summary>
        public Resource this[int index]
        {
            get
            {
                return ((Resource)(this.GetItem(index)));
            }
            set
            {
                this.SetItem(index, value);
            }
        }
        
        /// <summary>
        /// Adds a <see cref="Resource"/> instance to the collection.
        /// </summary>
        public int Add(Resource item)
        {
            return base.Add(item);
        }
        
        /// <summary>
        /// Adds a range of <see cref="Resource"/> instances to the collection.
        /// </summary>
        public void AddRange(Resource[] items)
        {
            base.AddRange(items);
        }
        
        /// <summary>
        /// Adds a range of <see cref="Resource"/> instances to the collection.
        /// </summary>
        public void AddRange(ResourceCollection items)
        {
            base.AddRange(items);
        }
    }
}
