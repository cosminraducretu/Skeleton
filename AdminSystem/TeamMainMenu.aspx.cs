using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCMS_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnSMS_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffLogin.aspx");
    }

    protected void btnStockMS_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockLogin.aspx");
    }
}