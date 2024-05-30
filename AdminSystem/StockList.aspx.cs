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
            DisplayCustomer();     
        }
    }
    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstStockList.DataSource = Customer.CustomerList;
        lstStockList.DataValueField = "ID";
        lstStockList.DataTextField = "FirstName";
        lstStockList.DataBind();
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
}