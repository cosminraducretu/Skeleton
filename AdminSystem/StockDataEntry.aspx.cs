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
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of the Staff collection
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        bool recordFound = Stock.ThisStock.Find(StockID);

        if (recordFound)
        {
            //display the data for the record
            txtStockid.Text = Stock.ThisStock.StockID.ToString();
            txtQuantity.Text = Stock.ThisStock.Quantity.ToString();
            txtDescription.Text = Stock.ThisStock.Description.ToString();
            txtPrice.Text = Stock.ThisStock.Price.ToString();
            txtSupplier.Text = Stock.ThisStock.Supplier.ToString();
            chkActive.Checked = Stock.ThisStock.Available;
        }
        else
        {
            // Handle the case when the record is not found
            Console.WriteLine("Stock record not found.");
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        try
        {
            // create a new instance of clsStock
            clsStock AStock = new clsStock();

            string quantity = txtQuantity.Text;
            string price = txtPrice.Text;
            string supplier = txtSupplier.Text;
            string description = txtDescription.Text;
            string available = chkActive.Text;

            string Error = "";

            Error = AStock.Valid(description, supplier, quantity, price);

            if (Error == "")
            {
                AStock.StockID = StockID;
                AStock.Supplier = txtSupplier.Text;
                AStock.Description = txtDescription.Text;
                AStock.Price = Convert.ToInt32(txtPrice.Text);
                AStock.Quantity = Convert.ToInt32(txtQuantity.Text);
                AStock.Available = chkActive.Checked;

                //create a new instance of the stock collection 
                clsStockCollection StockList = new clsStockCollection();
                //set the ThisStock property
                if (StockID == -1)
                {
                    StockList.ThisStock = AStock;
                    int result = StockList.Add();
                    lblError.Text = "record added.";
                    if (result == 0)
                    {
                        lblError.Text = "Failed to add the record.";
                    }
                }
                else
                {
                    StockList.ThisStock.Find(StockID);
                    StockList.ThisStock = AStock;
                    StockList.Update();
                }
                //navigate to the view page 
                Response.Redirect("StockList.aspx");
            }
            else
            {
                //display the error message 
                lblError.Text = Error;
            }
        }
        catch (Exception ex)
        {
            lblError.Text = "An error occurred: " + ex.Message;
            // Optionally, log the exception
            Console.WriteLine(ex);
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDataEntry.aspx");

    }





    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the address class
        clsStock AnIPTV = new clsStock();
        // Create a variable to store the primary key
        Int32 StockID;
        // Create a variable to store the result of the find operation
        Boolean Found = false;

        // Check if the input is a valid integer
        if (Int32.TryParse(txtStockid.Text, out StockID))
        {
            // Find the record
            Found = AnIPTV.Find(StockID);
            // If found
            if (Found == true)
            {
                // Display the values of the properties in the form
                txtDescription.Text = AnIPTV.Description;
                txtSupplier.Text = AnIPTV.Supplier;
                txtPrice.Text = AnIPTV.Price.ToString();
                txtQuantity.Text = AnIPTV.Quantity.ToString();
                chkActive.Checked = AnIPTV.Available;
            }
            else
            {
                // If not found, display an error message
                lblError.Text = "Stock ID not found.";
                // Clear the form fields
                ClearFormFields();
            }
        }
        else
        {
            // If input is not a valid integer, display an error message
            lblError.Text = "Please enter a valid Stock ID.";
            // Clear the form fields
            ClearFormFields();
        }
    
    }

    private void ClearFormFields()
    {
        txtDescription.Text = "";
        txtSupplier.Text = "";
        txtPrice.Text = "";
        txtQuantity.Text = "";
        chkActive.Checked = false;
    }



    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        //redirect the user to the customer StaffDataEntry page
        Response.Redirect("StockList.aspx");
    }

    protected void btnRTN_Click(object sender, EventArgs e)
    {
        //redirect the user to the customer login page
        Response.Redirect("TeamMainMenu.aspx");
    }
}