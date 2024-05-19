using System;
using System.Collections.Generic;
using System.Linq;
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
        //Capture the Supplier name
        AnIPTV.StockID = Convert.ToInt32(txtStockid.Text);
        AnIPTV.Quantity = Convert.ToInt32(txtQuantity.Text);
        AnIPTV.Price = Convert.ToInt32(txtPrice.Text);
        AnIPTV.Available = chkActive.Checked;
        AnIPTV.Supplier = txtSupplier.Text;
        AnIPTV.Description = txtDescription.Text;
        //Store the IPTV in the session object
        Session["AnIPTV"] = AnIPTV;
        //Navigate to the view Page 
        Response.Redirect("StockViewer.aspx");
    }
}