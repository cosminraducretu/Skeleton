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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();

        
        string StaffID = txtStaffID.Text;
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Address = txtAddress.Text;
        string Age = txtAge.Text;
        string Active = chkActive0.Text;

        string Error = "";

        Error = AStaff.Valid(StaffID ,FirstName, LastName, Address, Age);
       
        if(Error ==  "")
        {
            //capture the inputs
            AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
            AStaff.FirstName = txtFirstName.Text;
            AStaff.LastName = txtLastName.Text;
            AStaff.Address = txtAddress.Text;
            AStaff.Age = Convert.ToInt32(txtAge.Text);
            AStaff.Active = chkActive0.Checked;


            //display the Firstname for this entry;
            Session["AStaff"] = AStaff;
            //navigate to the view page 
            Response.Redirect("StaffViewer.aspx");
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
            chkActive0.Checked = AnStaff.Active;
        }
    }
}