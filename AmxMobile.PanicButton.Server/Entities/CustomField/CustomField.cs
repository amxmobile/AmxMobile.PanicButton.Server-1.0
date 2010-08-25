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
    /// Defines the entity type for 'CustomFields'.
    /// </summary>
    [Serializable()]
    [Entity(typeof(CustomFieldCollection), "CustomFields")]
    [SortSpecification(new string[] {
            "Name"}, new BootFX.Common.Data.SortDirection[] {
            BootFX.Common.Data.SortDirection.Ascending})]
    public class CustomField : CustomFieldBase
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public CustomField()
        {
        }
        
        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        protected CustomField(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }

        public static CustomField GetByNameAndTableCatalogId(string name, int tableId)
        {
            SqlFilter filter = CreateFilter();
            filter.Constraints.Add("tablecatalogid", tableId);
            filter.Constraints.Add("name", name);

            // reeturn...
            return (CustomField)filter.ExecuteEntity();
        }
    }
}
