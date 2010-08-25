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
    internal abstract class PanicOperation : OperationBase
    {
        internal PanicOperation()
        {
        }

        protected void HandlePanic(SimpleXmlPropertyBag input, SimpleXmlPropertyBag output, bool start)
        {
            // get the resource...
            string resourceId = input.GetStringValue("resourceid", null, Cultures.System, OnNotFound.ThrowException);

            // find it...
            ResourceCollection resources = Resource.GetByExternalId(resourceId);
            if (resources.Count == 0)
                throw new InvalidOperationException(string.Format("A resource with ID '{0}' was not found.", resourceId));

            // we've got the one that we want...
            Resource resource = resources[0];

            // find the custom field...
            TableCatalogItem table = TableCatalogItem.GetByName("Resource");
            if (table == null)
                throw new InvalidOperationException("'table' is null.");
            CustomField field = CustomField.GetByNameAndTableCatalogId("Panic", table.TableCatalogId);
            if (field == null)
                throw new InvalidOperationException("'field' is null.");

            // get the data item...
            CustomData item = CustomData.GetByCustomFieldIdAndObjectId(field.CustomFieldId, resource.ResourceId);
            if (item == null)
            {
                item = new CustomData();
                item.CustomField = field;
                item.ObjectId = resource.ResourceId;
            }

            // set...
            if (start)
                item.Value = string.Format("Entered alert state at '{0}'", DateTime.Now);
            else
                item.Value = string.Empty;

            // save...
            item.SaveChanges();

            // set...
            output["NowPanicking"] = start;
        }
    }
}