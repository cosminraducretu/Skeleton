using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the StaffID collection class 
        clsStaffCollection StaffId = new clsStaffCollection();
        //find the record to delete 
        StaffId.ThisStaff.Find(StaffID);
        //delete the record
        StaffId.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}