using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomer();
        }
        //create a new instance of clsUser
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from the session object
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }
    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "ID";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();
    }


    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ID;
        if(lstCustomerList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["ID"] = ID;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 ID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["ID"] = ID;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to be deleted";

        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        AnCustomer.ReportBySubscriptionPlan(txtEnter.Text);
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        lstCustomerList.DataValueField = "ID";
        lstCustomerList.DataTextField = "SubscriptionPlan";
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        AnCustomer.ReportBySubscriptionPlan("");
        txtEnter.Text = "";
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        lstCustomerList.DataValueField = "ID";
        lstCustomerList.DataTextField = "SubscriptionPlan";
        lstCustomerList.DataBind();
    }

    protected void btnApplyFilter_Click1(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //retrieve the value of post code from the presentation layer
        AnCustomer.ReportBySubscriptionPlan(txtEnter.Text);
        //set the data source to the list of address in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField= "ID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "SubscriptionPlan";
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click1(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //set any empty string
        AnCustomer.ReportBySubscriptionPlan("");
        //clear any existing filter to tidy up the interface
        txtEnter.Text = "";
        //set the data source to the list of address in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the field to display
        lstCustomerList.DataValueField = "ID";
        lstCustomerList.DataTextField = "SubscriptionPlan";
        lstCustomerList.DataBind();
    }

    protected void btnRTMM_Click(object sender, EventArgs e)
    {
        //redirect the user to the customer login page
        Response.Redirect("TeamMainMenu.aspx");
    }
}