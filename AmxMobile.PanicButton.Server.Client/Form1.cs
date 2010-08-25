using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BootFX.Common;
using BootFX.Common.UI;
using BootFX.Common.UI.Desktop;
using BootFX.Common.Xml;
using BootFX.Common.Data;
using BootFX.Common.Services;
using BootFX.Common.Management;

namespace AmxMobile.PanicButton.Server.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // create a request...
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(this.textInput.Text.Trim());

                // send...
                HttpResult result = HttpHelper.PostXmlDocument(this.textUrl.Text.Trim(), doc, null, HttpResultType.Xml);
                if(result.ResultAsXml != null)
                {
                    // create...
                    string temp = Runtime.Current.GetTempXmlFilePath();
                    result.ResultAsXml.Save(temp);

                    // nav...
                    this.browser.Navigate("file://" + temp);
                }
                else
                    throw new InvalidOperationException(string.Format("Expected result '{0}'.", result.Status));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }
    }
}
