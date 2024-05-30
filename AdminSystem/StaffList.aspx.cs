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
        //if this is the first time the page is displayed
        if (!IsPostBack)
        {
            //update the list box 
            DisplayStaff();
        }
        //create a new instance of clsCustomerUser
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from the session object
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }
    void DisplayStaff()
    {
        //create and instance of the Address collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list of staff in the collection 
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffList.DataTextField = "FirstName";
        //bind the data to the list
        lstStaffList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store  -1 into session  object to indicate this is a new record 
        Session["StaffID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffID;

        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the sessions object
            Session["StaffID"]=StaffID;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else // if no record has been seleted 
        {
            //display and error message
            lblError.Text = "Please select a record from the list to delete"; 

        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        int StaffId;
        //if a record has been seleted from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }

    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrive the value of address from the presentation layer
        AnStaff.ReportByAddress(txtFilterAddress.Text);
        //set the data source to the list of addresses in the collection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "Address";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrive the value of address from the presentation layer
        AnStaff.ReportByAddress("");
        //clear any exiting filter to dity up the interface
        txtFilterAddress.Text = "";
        //data source 
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the data source to the list of addresses in the collection
        lstStaffList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "Address";
        //bind the data to the list
        lstStaffList.DataBind();

    }

    protected void btnRTN_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}