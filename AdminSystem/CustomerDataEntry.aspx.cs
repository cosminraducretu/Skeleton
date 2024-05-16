using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the FirstName
        string FirstName = txtFirstName.Text;
        //capture the LastName
        string LastName = txtLastName.Text;
        //capture the Email
        string Email = txtEmail.Text;
        //capture the SubscriptionPlan
        string SubscriptionPlan = txtSubscriptionPlan.Text;
        //capture the CheckBox
        string Age = txtAge.Text;
        //capture the CheckBox
        string SubscriptionStatus = ChkSubscriptionStatus.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(FirstName, LastName, Email, SubscriptionPlan, Age);
        if (Error == "")
        {
            //capture the FirstName
            AnCustomer.FirstName = FirstName;
            //capture the LastName
            AnCustomer.LastName = LastName;
            //capture the Email
            AnCustomer.Email = Email;
            //capture the SubscriptionPlan
            AnCustomer.SubscriptionPlan = SubscriptionPlan;
            //capture the Age
            AnCustomer.Age = Convert.ToInt32(Age);
            //store in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
    }

}
