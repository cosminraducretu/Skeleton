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
        //Create a new instance of clsStock
        clsStock AnIPTV = new clsStock();
        //Capture the Supplier name
        AnIPTV = (clsStock)Session["AnIPTV"];
        //Display the supplier for this entry 
        Response.Write("StockID: " + AnIPTV.StockID + "<br/>");
        Response.Write("Quantity: " + AnIPTV.Quantity + "<br/>");
        Response.Write("Description: " + AnIPTV.Description + "<br/>");
        Response.Write("Price: " + AnIPTV.Price + "<br/>");
        Response.Write("Supplier: " + AnIPTV.Supplier + "<br/>");
        Response.Write("Available: " + AnIPTV.Available + "<br/>");
    }
}