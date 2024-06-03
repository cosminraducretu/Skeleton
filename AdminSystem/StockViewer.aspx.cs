using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //create a new instance of clsUser
            clsCustomerUser AnUser = new clsCustomerUser();
            //get data from the session object
            AnUser = (clsCustomerUser)Session["AnUser"];
            //display the user name
            Response.Write("Logged in as: " + AnUser.UserName);

            // Retrieve the staff object from session
            var AnIPTV = Session["AnIPTV"] as ClassLibrary.clsStock;

            if (AnIPTV != null)
            {
                //Display the supplier for this entry 
                Response.Write("StockID: " + AnIPTV.StockID + "<br/>");
                Response.Write("Quantity: " + AnIPTV.Quantity + "<br/>");
                Response.Write("Description: " + AnIPTV.Description + "<br/>");
                Response.Write("Price: " + AnIPTV.Price + "<br/>");
                Response.Write("Supplier: " + AnIPTV.Supplier + "<br/>");
                Response.Write("Available: " + AnIPTV.Available + "<br/>");
            }
            else
            {
                Response.Write("Stock details not found.");
            }
        }
    }
}