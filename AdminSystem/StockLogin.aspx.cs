using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

        // Create an instance of clsUser
        clsStockUser anUser = new clsStockUser();

        // Get the username and password entered by the user
        string userName = txtUserName.Text;
        string password = txtPassword.Text;

        // Check if username or password is empty
        if (string.IsNullOrEmpty(userName))
        {
            lblError.Text = "Please enter a username.";
        }
        else if (string.IsNullOrEmpty(password))
        {
            lblError.Text = "Please enter a password.";
        }
        else
        {
            // Attempt to find the user and validate credentials
            bool found = anUser.FindUser(userName, password);

            if (found)
            {
                // Add a session to capture the user details
                Session["AnUser"] = anUser;

                // Redirect to the appropriate page based on user role
                string userType = anUser.Department; // Assuming Department is the role
                switch (userType)
                {

                    case "Stock":
                        Response.Redirect("StockList.aspx");
                        break;

                    default:
                        lblError.Text = "User type is not recognized.";
                        break;
                }
            }
            else
            {
                lblError.Text = "Login details are incorrect. Please try again.";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

}