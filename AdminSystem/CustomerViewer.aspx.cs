using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the ID for this entry
        Response.Write(AnCustomer.ID + "<br>");
        //display the FirstName for this entry
        Response.Write(AnCustomer.FirstName + "<br/>");
        //display the LastName for this entry
        Response.Write(AnCustomer.LastName + "<br/>");
        //display the Email for this entry
        Response.Write(AnCustomer.Email + "<br/>");
        //display the SubscriptionPlane for this entry
        Response.Write(AnCustomer.SubscriptionPlan + "<br/>");
        //display the Age for this entry
        Response.Write(AnCustomer.Age + "<br/>");
        //display the SubscriptionStatus for this entry
        Response.Write(AnCustomer.SubscriptionStatus + "<br/>");
    }
}