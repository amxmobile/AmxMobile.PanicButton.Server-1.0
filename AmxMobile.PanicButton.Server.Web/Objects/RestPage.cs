using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BootFX.Common;
using BootFX.Common.UI;
using BootFX.Common.UI.Web;
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

            try
            {
                // load...
                SimpleXmlPropertyBag input = SimpleXmlPropertyBag.Load(this.Request.InputStream, typeof(SimpleXmlPropertyBag));
                if (input == null)
                    throw new InvalidOperationException("'bag' is null.");

                // op...
                string opName = input.GetStringValue("operation", null, Cultures.System, OnNotFound.ThrowException);
                OperationBase operation = null;
                if (string.Compare(opName, "startpanicking", true, Cultures.System) == 0)
                    operation = new StartPanicOperation();
                else if (string.Compare(opName, "stoppanicking", true, Cultures.System) == 0)
                    operation = new StopPanicOperation();
                else
                    throw new NotSupportedException(string.Format("Cannot handle '{0}'.", opName));

                // run...
                SimpleXmlPropertyBag output = new SimpleXmlPropertyBag();
                operation.Run(input, output);

                // send...
                SendSuccess(output);
            }
            catch (Exception ex)
            {
                SendError(ex);
            }
        }

        private void SendSuccess(SimpleXmlPropertyBag output)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("RestResponse");
            doc.AppendChild(root);

            // set...
            foreach (string key in output.Keys)
            {
                XmlElement element = doc.CreateElement(key);
                root.AppendChild(element);
                XmlHelper.SetElementValue(element, output[key]);
            }

            // send...
            WebRuntime.Current.TransmitDocument(doc, MimeTypes.Xml, null, this.Response, TransmitDocumentFlags.Normal);
        }

        private void SendError(Exception ex)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("RestResponse");
            doc.AppendChild(root);

            // set...
            XmlHelper.AddElement(root, "HasError", true);
            XmlHelper.AddElement(root, "Error", ex.ToString());

            // send...
            WebRuntime.Current.TransmitDocument(doc, MimeTypes.Xml, null, this.Response, TransmitDocumentFlags.Normal);
        }
    }
}