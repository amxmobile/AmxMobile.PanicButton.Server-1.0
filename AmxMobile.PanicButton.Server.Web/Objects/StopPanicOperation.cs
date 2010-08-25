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
    internal class StopPanicOperation : PanicOperation
    {
        internal StopPanicOperation()
        {
        }

        internal override void Run(SimpleXmlPropertyBag input, SimpleXmlPropertyBag output)
        {
            this.HandlePanic(input, output, false);
        }
    }
}