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
        //create a new instance of clsCustomerUser
        clsStockUser AnUser = new clsStockUser();
        //get data from the session object
        AnUser = (clsStockUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
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
        // Retrieve the selected value from the DropDownList
        int selectedStatus = Convert.ToInt32(Availability.SelectedValue);        
        // Call the ReportByAvailable method with the selected status
        AStock.ReportByAvailable(selectedStatus);
        // Set the data source to the list of stocks in the collection
        lstStockList.DataSource = AStock.StockList;
        // Set the name of the primary key
        lstStockList.DataValueField = "StockID";
        // Set the name of the field to display
        lstStockList.DataTextField = "Description";
        // Bind the data to the list control
        lstStockList.DataBind();
    }



    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the stock collection object
        clsStockCollection AStock = new clsStockCollection();
        // Call a method to reset the collection to show all items
        AStock.ReportByAll();
        // Set the data source to the list of stocks in the collection
        lstStockList.DataSource = AStock.StockList;
        // Set the name of the primary key
        lstStockList.DataValueField = "StockID";
        // Set the name of the field to display
        lstStockList.DataTextField = "Description";
        // Bind the data to the list control
        lstStockList.DataBind();
        // Optionally reset the DropDownList to "All"
        Availability.SelectedValue = "-1";
    }



    protected void btnRTN_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }


    protected void lstStockList_SelectedIndexChanged1(object sender, EventArgs e)
    {
        // Handle the event when the selected index of the list box changes
        Int32 StockID;
        if (lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockID"] = StockID;
            // You can add any additional logic here if needed
        }
        else
        {
            lblError.Text = "Please select a valid item from the list.";
        }
    }


}