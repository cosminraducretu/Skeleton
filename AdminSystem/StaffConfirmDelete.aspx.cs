using ClassLibrary;
using System;
using System.Web.UI;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Declare StaffID at the class level so it can be accessed by all methods
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        
         // Retrieve StaffID from the session and assign it to the class-level variable
         StaffID = Convert.ToInt32(Session["StaffID"]);

        //create a new instance of clsUser
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from the session object
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create a new instance of the clsStaffCollection class
        clsStaffCollection StaffCollection = new clsStaffCollection();
        // Find the record to delete
        StaffCollection.ThisStaff.Find(StaffID);
        // Delete the record
        StaffCollection.Delete();
        // Redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}
