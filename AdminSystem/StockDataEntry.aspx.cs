using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStock
        clsStock AnIPTV = new clsStock();
        // Capture the street
        string quantity = txtQuantity.Text;
        // Capture the town
        string price = txtPrice.Text;
        // Capture the post code
        string supplier = txtSupplier.Text;
        // Capture the date added
        string description = txtDescription.Text;
        // Capture active status
        bool Active = chkActive.Checked;
        // Variable to store any error messages
        string Error = "";
        // Validate the data
        Error = AnIPTV.Valid(description, supplier, Active, quantity, price);

        if (Error == "")
        {
            // Capture the house no
            AnIPTV.Description = description;
            // Capture the street
            AnIPTV.Supplier = supplier;
            // Capture the town
            AnIPTV.Quantity = Convert.ToInt32(quantity);
            // Capture the post code
            AnIPTV.Price = Convert.ToInt32(price);
            //capture the avilability
            AnIPTV.Available = chkActive.Checked;
            // Capture active status
            AnIPTV.Available = Active;
            //Store the IPTV in the session object
            Session["AnIPTV"] = AnIPTV;
            //Navigate to the view Page 
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }
    }
}