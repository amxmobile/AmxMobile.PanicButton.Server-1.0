using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Startup startup = new Startup(PanicRuntime.ProductCompany, PanicRuntime.ProductName, "Client", PanicRuntime.ProductVersion);
            startup.StartApplication += new EventHandler(startup_StartApplication);
            startup.Run();
        }

        static void startup_StartApplication(object sender, EventArgs e)
        {
            Application.Run(new Form1());
        }
    }
}
