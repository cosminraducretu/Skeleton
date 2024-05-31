using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            DisplayStock();     
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "Description";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store  -1 into session  object to indicate this is a new record 
        Session["StockID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if (lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";

        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if (lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select an IPTV from the list to be deleted";

        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the stock collection object
        clsStockCollection AStock = new clsStockCollection();
        // Retrieve the value of the availability from the presentation layer
        // Check if the checkbox is checked
        bool isAvailable = Checkav.Checked;
        // Call the ReportByAvailable method with the boolean value
        AStock.ReportByAvailable(isAvailable);
        // Assuming you have a ListControl (like DropDownList, ListBox, etc.) to display the data
        ListControl listControl = lstStockList;
        // Set the data source to the list of stocks in the collection
        listControl.DataSource = AStock.StockList;
        // Set the name of the primary key
        listControl.DataValueField = "StockID";
        // Set the name of the field to display
        listControl.DataTextField = "IPTVDescription";
        // Bind the data to the list control
        listControl.DataBind();
    }


    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the stock collection object
        clsStockCollection AStock = new clsStockCollection();
        // Retrieve the value of the availability from the presentation layer
        // Check if the checkbox is checked
        bool isAvailable = Checkav.Checked;
        // Call the ReportByAvailable method with the boolean value
        AStock.ReportByAvailable(false); // Assuming false indicates that all items should be considered regardless of availability
        // Assuming you have a ListControl (like DropDownList, ListBox, etc.) to display the data
        ListControl listControl = lstStockList;
        // Set the data source to the list of stocks in the collection
        listControl.DataSource = AStock.StockList;
        // Set the name of the primary key
        listControl.DataValueField = "StockID";
        // Set the name of the field to display
        listControl.DataTextField = "IPTVDescription";
        // Bind the data to the list control
        listControl.DataBind();

    }

    protected void btnRTN_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}