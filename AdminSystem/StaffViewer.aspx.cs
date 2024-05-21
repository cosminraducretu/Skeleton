using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Retrieve the staff object from session
            var AStaff = Session["AStaff"] as ClassLibrary.clsStaff;

            if (AStaff != null)
            {
                // Display staff details
                Response.Write("First Name: " + AStaff.FirstName + "<br/>");
                Response.Write("Last Name: " + AStaff.LastName + "<br/>");
                Response.Write("Age: " + AStaff.Age + "<br/>");
                Response.Write("Department: " + AStaff.Address + "<br/>");
                Response.Write("Availability: " + AStaff.Active + "<br/>");
            }
            else
            {
                Response.Write("Staff details not found.");
            }
        }
    }
}