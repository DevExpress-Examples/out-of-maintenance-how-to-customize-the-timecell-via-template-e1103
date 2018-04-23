using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxScheduler;
using System.Drawing;
using DevExpress.Web.Internal;
using DevExpress.XtraScheduler;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {
        DataHelper.SetupMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource);
        DataSource1.AttachTo(ASPxScheduler1);
    }
}
