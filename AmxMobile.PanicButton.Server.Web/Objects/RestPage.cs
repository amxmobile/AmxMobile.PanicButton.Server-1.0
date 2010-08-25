using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BootFX.Common;
using BootFX.Common.Xml;
using BootFX.Common.Data;
using BootFX.Common.Services;
using BootFX.Common.Management;

namespace AmxMobile.PanicButton.Server.Web
{
    public class RestPage : Page
    {
        public RestPage()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // load...
            SimpleXmlPropertyBag bag = SimpleXmlPropertyBag.Load(this.Request.InputStream, typeof(SimpleXmlPropertyBag));
            if (bag == null)
                throw new InvalidOperationException("'bag' is null.");

            // op...
            string opName = bag.GetStringValue("operation", null, Cultures.System, OnNotFound.ThrowException);
            OperationBase operation = null;
            if (string.Compare(opName, "startpanic", true, Cultures.System) == 0)
                operation = new PanicOperation();
            else
                throw new NotSupportedException(string.Format("Cannot handle '{0}'.", opName));

            // run...
            operation.Run(bag);
        }
    }
}