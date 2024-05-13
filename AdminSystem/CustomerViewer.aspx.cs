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
        Response.Write(AnCustomer.ID);
        //display the FirstName for this entry
        Response.Write(AnCustomer.FirstName);
        //display the LastName for this entry
        Response.Write(AnCustomer.LastName);
        //display the Email for this entry
        Response.Write(AnCustomer.Email);
        //display the SubscriptionPlane for this entry
        Response.Write(AnCustomer.SubscriptionPlan);
        //display the Age for this entry
        Response.Write(AnCustomer.Age);
        //display the SubscriptionStatus for this entry
        Response.Write(AnCustomer.SubscriptionStatus);
    }
}