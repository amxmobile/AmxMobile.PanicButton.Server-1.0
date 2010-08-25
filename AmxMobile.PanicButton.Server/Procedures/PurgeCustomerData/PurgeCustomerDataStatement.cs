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
    /// Provides access to the <c>PurgeCustomerData</c> procedure.
    /// </summary>
    public class PurgeCustomerDataStatement : PurgeCustomerDataStatementBase
    {
        
        /// <summary>
        /// Creates a new instance of the object.
        /// </summary>
        public PurgeCustomerDataStatement()
        {
        }
    }
}
