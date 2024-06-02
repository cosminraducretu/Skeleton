using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Declare StaffID at the class level so it can be accessed by all methods
    Int32 StockID;

    protected void Page_Load(object sender, EventArgs e)
    {

        // Retrieve StaffID from the session and assign it to the class-level variable
        StockID = Convert.ToInt32(Session["StockID"]);

        //create a new instance of clsUser
        clsStockUser AnUser = new clsStockUser();
        //get data from the session object
        AnUser = (clsStockUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create a new instance of the clsStaffCollection class
        clsStockCollection StockCollection = new clsStockCollection();
        // Find the record to delete
        StockCollection.ThisStock.Find(StockID);
        // Delete the record
        StockCollection.Delete();
        // Redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

}