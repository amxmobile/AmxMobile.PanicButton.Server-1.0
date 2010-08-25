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
    /// Base class for providing access to the <c>PurgeCustomerData</c> procedure.
    /// </summary>
    /// <remarks>
    /// SQL: CREATE PROCEDURE PurgeCustomerData
    ///	@CustomerId int
    ///AS
    ///BEGIN
    ///
    ///	/* surveys */
    ///	delete from shmsurveyresults where surveytemplateid in
    ///		(select surveytemplateid from shmsurveytemplates where customerid = @customerid);
    ///
    ///	/* mobile surveys */
    ///	delete from shmmobilesurveyanswerlines where mobilesuveryanswersetid in 
    ///		(select mobilesurveyanswersetid from shmmobilesurveyanswersets where mobilesurveytemplateid in 
    ///			(select mobilesurveytemplateid from shmmobilesurveytemplates where customerid = @customerid));
    ///
    ///	delete from shmmobilesurveyanswersets where mobilesurveytemplateid in 
    ///			(select mobilesurveytemplateid from shmmobilesurveytemplates where customerid = @customerid);
    ///
    ///	/* audit data */
    ///	delete from shmmessagereceiveaudit where resourceid in 
    ///			(select resourceid from shmresources where customerid = @customerid);
    ///
    ///	delete from shmmessagesendaudit where resourceid in 
    ///			(select resourceid from shmresources where customerid = @customerid);
    ///
    ///	/* visit data */
    ///	delete from shmcomments where visitid in 
    ///		(select visitid from shmvisits where requestid in 
    ///			(select requestid from shmrequests where EndPointId IN 
    ///				(select CustomerEndPointId from ShmEndPoints where SiteId IN 
    ///					(select SiteId from ShmSites where customerid = @customerid))));
    ///
    ///	delete from shmjoblines where visitid in 
    ///		(select visitid from shmvisits where requestid in 
    ///			(select requestid from shmrequests where EndPointId IN 
    ///				(select CustomerEndPointId from ShmEndPoints where SiteId IN 
    ///					(select SiteId from ShmSites where customerid = @customerid))));
    ///
    ///	delete from shmmateriallines where visitid in 
    ///		(select visitid from shmvisits where requestid in 
    ///			(select requestid from shmrequests where EndPointId IN 
    ///				(select CustomerEndPointId from ShmEndPoints where SiteId IN 
    ///					(select SiteId from ShmSites where customerid = @customerid))));
    ///
    ///	delete from shmresourcesignals where visitid in 
    ///		(select visitid from shmvisits where requestid in 
    ///			(select requestid from shmrequests where EndPointId IN 
    ///				(select CustomerEndPointId from ShmEndPoints where SiteId IN 
    ///					(select SiteId from ShmSites where customerid = @customerid))));
    ///
    ///	delete from shmvisitresources where visitid in 
    ///		(select visitid from shmvisits where requestid in 
    ///			(select requestid from shmrequests where EndPointId IN 
    ///				(select CustomerEndPointId from ShmEndPoints where SiteId IN 
    ///					(select SiteId from ShmSites where customerid = @customerid))));
    ///
    ///	delete from shmvisits where visitid in 
    ///		(select visitid from shmvisits where requestid in 
    ///			(select requestid from shmrequests where EndPointId IN 
    ///				(select CustomerEndPointId from ShmEndPoints where SiteId IN 
    ///					(select SiteId from ShmSites where customerid = @customerid))));
    ///
    ///	delete from shmpassthroughmessages where customerid = @customerid;
    ///
    ///	delete from shmrequests where EndPointId IN 
    ///		(select CustomerEndPointId from ShmEndPoints where SiteId IN 
    ///			(select SiteId from ShmSites where customerid = @customerid));
    ///
    ///	delete from shmreturnxmessages where EndPointId IN 
    ///		(select CustomerEndPointId from ShmEndPoints where SiteId IN 
    ///			(select SiteId from ShmSites where customerid = @customerid));
    ///
    ///	/* resource data */
    ///	delete from shmmobiledevicelogons where mobiledeviceid in 
    ///		(select mobiledeviceid from shmmobiledevices where resourceid in 
    ///			(select resourceid from shmresources where customerid = @customerid));
    ///
    ///	delete from shmpairingrequests where mobiledeviceid in 
    ///		(select mobiledeviceid from shmmobiledevices where resourceid in 
    ///			(select resourceid from shmresources where customerid = @customerid));
    ///
    ///	delete from shmmobiledevices where resourceid in 
    ///			(select resourceid from shmresources where customerid = @customerid);
    ///
    ///	delete from shmresourcelogons where resourceid in 
    ///		(select resourceid from shmresources where customerid = @customerid);
    ///
    ///	delete from shmresourcedevices where resourceid in 
    ///		(select re
    /// </remarks>
    public class PurgeCustomerDataStatementBase : BootFX.Common.Data.SqlStatement
    {
        
        /// <summary>
        /// Constructs the object and configures parameters for the procedure.
        /// </summary>
        protected PurgeCustomerDataStatementBase() : 
                base("[PurgeCustomerData]", System.Data.CommandType.StoredProcedure)
        {
            // set up the parameters...
            this.Parameters.Add(new BootFX.Common.Data.SqlStatementParameter("CustomerId", System.Data.DbType.Int32, System.DBNull.Value, System.Data.ParameterDirection.Input));
        }
        
        /// <summary>
        /// Provides access to the <c>CustomerId</c> parameter, type=<c>Int32</c>, default=<c></c>, direction=<c>Input</c>.
        /// </summary>
        public BootFX.Common.Data.SqlStatementParameter CustomerId
        {
            get
            {
                return this.Parameters["CustomerId"];
            }
        }
    }
}
