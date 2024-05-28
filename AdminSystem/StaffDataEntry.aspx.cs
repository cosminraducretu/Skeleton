using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variabel to store the primary key with page level scope 
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsUser AnUser = new clsUser();
        //get data from the session object
        AnUser = (clsUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);

        //get the number of the Staff to be processed 
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            // if this is the not a new record
            if (StaffID != 1)
            {
                //display the currect data for the record
                DisplayStaff();
            }
        }

    }



    void DisplayStaff()
    {
        //create an instance of the Staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to update
        bool recordFound = Staff.ThisStaff.Find(StaffID);

        if (recordFound)
        {
            //display the data for the record
            txtStaffID.Text = Staff.ThisStaff.StaffID.ToString();
            txtFirstName.Text = Staff.ThisStaff.FirstName;
            txtLastName.Text = Staff.ThisStaff.LastName;
            txtAddress.Text = Staff.ThisStaff.Address;
            txtAge.Text = Staff.ThisStaff.Age.ToString();
            chkActive.Checked = Staff.ThisStaff.Active;
        }
        else
        {
            // Handle the case when the record is not found
            Console.WriteLine( "Staff record not found.");
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();


        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Address = txtAddress.Text;
        string Age = txtAge.Text;
        string Active = chkActive.Text;

        string Error = "";

        Error = AStaff.Valid(FirstName, LastName, Address, Age);
       
        if(Error ==  "")
        {
            //capture the StaffID
            AStaff.StaffID = StaffID;
            //capture the FirstName
            AStaff.FirstName = txtFirstName.Text;
            //capture the LastName
            AStaff.LastName = txtLastName.Text;
            //capture the Address
            AStaff.Address = txtAddress.Text;
            //capture the Age
            AStaff.Age = Convert.ToInt32(txtAge.Text);
            //capture the Active
            AStaff.Active = chkActive.Checked;


            //create a new instance of the address collection 
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the ThisStaff property
            if (StaffID ==-1) {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffID);
                StaffList.ThisStaff= AStaff;
                StaffList.Update();
            }
            //navigate to the view page 
            Response.Redirect("StaffList.aspx");
        }    
        else
        {
            //display the error message 
            lblError0.Text = Error;
        }
     
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStaff AnStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AnStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
           // display the values of the properties in the form
            txtFirstName.Text = AnStaff.FirstName;
            txtLastName.Text = AnStaff.LastName;
            txtAddress.Text = AnStaff.Address;
            txtAge.Text = AnStaff.Age.ToString();
            chkActive.Checked = AnStaff.Active;
        }
    }


    protected void btnRTN_Click(object sender, EventArgs e)
    {
        //redirect the user to the customer login page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        //redirect the user to the customer StaffDataEntry page
        Response.Redirect("StaffDataEntry.aspx");
    }
}