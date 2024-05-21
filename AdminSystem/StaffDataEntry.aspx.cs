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
        // create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the inputs
        AStaff.StaffID = Convert.ToInt32(txtStaffID0.Text);
        AStaff.FirstName = txtFirstName0.Text;
        AStaff.LastName = txtLastName0.Text;
        AStaff.Address = txtAddress0.Text;
        AStaff.Age= Convert.ToInt32(txtSalary0.Text);
        AStaff.Active = chkActive0.Checked;
        //display the Firstname for this entry;
        Session["AStaff"] = AStaff;
        //navigate to the view page 
        Response.Redirect("StaffViewer.aspx");

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
        StaffID = Convert.ToInt32(txtStaffID0.Text);
        //find the record
        Found = AnStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
           // display the values of the properties in the form
            txtFirstName0.Text = AnStaff.FirstName;
            txtLastName0.Text = AnStaff.LastName;
            txtAddress0.Text = AnStaff.Address;
            txtSalary0.Text = AnStaff.Age.ToString();
            chkActive0.Checked = AnStaff.Active;
        }
    }
}