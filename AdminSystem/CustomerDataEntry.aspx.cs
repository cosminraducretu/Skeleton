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
        AnCustomer.ID = Convert.ToInt16(txtID.Text);
        //capture the FirstName
        AnCustomer.FirstName = txtFirstName.Text;
        //capture the LastName
        AnCustomer.LastName = txtLastName.Text;
        //capture the Email
        AnCustomer.Email = txtEmail.Text;
        //capture the SubscriptionPlan
        AnCustomer.SubscriptionPlan = txtSubscriptionPlan.Text;
        //capture the CheckBox
        AnCustomer.Age = Convert.ToInt32(txtAge.Text);
        //capture the CheckBox
        AnCustomer.SubscriptionStatus = ChkSubscriptionStatus.Checked;
        //store in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

}
