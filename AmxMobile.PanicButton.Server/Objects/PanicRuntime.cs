using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootFX.Common;
using BootFX.Common.Xml;
using BootFX.Common.Data;
using BootFX.Common.Services;
using BootFX.Common.Management;

namespace AmxMobile.PanicButton.Server
{
    public sealed class PanicRuntime
    {
        public const string ProductCompany = "AMX Mobile";
        public const string ProductName = "Panic Button Server";

        public static void Start(string module)
        {
            Runtime.Start(ProductCompany, ProductName, module, ProductVersion);
        }

        public static Version ProductVersion
        {
            get
            {
                return typeof(PanicRuntime).Assembly.GetName().Version;
            }
        }
    }
}
