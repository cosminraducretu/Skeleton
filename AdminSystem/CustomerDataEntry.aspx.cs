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
        //capture the ID
        string ID = txtID.Text;
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
            //capture the subscriptionStatus
            AnCustomer.SubscriptionStatus = ChkSubscriptionStatus.Checked;
            //create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the ThisCustomer property
            CustomerList.ThisCustomer = AnCustomer;
            //add the new record
            CustomerList.Add();
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 ID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ID = Convert.ToInt32(txtID.Text);
        //find the record
        Found = AnCustomer.Find(ID);
        //if found
        if (Found == true) {
            //display the values of the properties in the form
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtEmail.Text = AnCustomer.Email;
            txtSubscriptionPlan.Text = AnCustomer.SubscriptionPlan;
            txtAge.Text = AnCustomer.Age.ToString();
            ChkSubscriptionStatus.Checked = AnCustomer.SubscriptionStatus;
        }
    }
}
