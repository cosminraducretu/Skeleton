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
        AStaff.FirstName = txtFirstName.Text;
        AStaff.LastName = txtLastName.Text;
        AStaff.Department = txtDepartment.Text;
        AStaff.Salary= Convert.ToInt32(txtSalary.Text);
        AStaff.Availability = chkActive.Checked;
        //display the Firstname for this entry
        Session["AStaff"] = AStaff;
        //navigate to the view page 
        Response.Redirect("StaffViewer.aspx");

    }
}