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
    Int32 StockID;

    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["ID"]);
        if (IsPostBack == false)
        {
            if (StockID != -1)
            {
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(StockID);
        txtStockid.Text = Stock.ThisStock.StockID.ToString();
        txtQuantity.Text = Stock.ThisStock.Quantity.ToString();
        txtDescription.Text = Stock.ThisStock.Description.ToString();
        txtPrice.Text = Stock.ThisStock.Price.ToString();
        txtSupplier.Text = Stock.ThisStock.Supplier.ToString();
        chkActive.Checked = Stock.ThisStock.Available;
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
            AnIPTV.StockID = StockID;
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
            //create a new instance of the address collection
            clsStockCollection StockList = new clsStockCollection();
            //if this is a new record i.e. ID = -1 then add the data
            if (StockID == -1)
            {
                StockList.ThisStock = AnIPTV;
                //add the new record
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(StockID);
                StockList.ThisStock = AnIPTV;
                StockList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }



    }
}