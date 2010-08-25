using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BootFX.Common;
using BootFX.Common.Xml;
using BootFX.Common.Data;
using BootFX.Common.Services;
using BootFX.Common.Management;

namespace AmxMobile.PanicButton.Server.Web
{
    internal abstract class OperationBase
    {
        internal OperationBase()
        {
        }

        internal abstract void Run(SimpleXmlPropertyBag input, SimpleXmlPropertyBag output);
    }
}