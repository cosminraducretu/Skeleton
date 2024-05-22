﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (!IsPostBack == false)
        {
            //update the list box 
            DisplayStaff();
        }

    }
    void DisplayStaff()
    {
        //create and instance of the Address collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list of staff in the collection 
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "Address";
        //set the data field to display
        lstStaffList.DataTextField = "FirstName";
        //bind the data to the list
        lstStaffList.DataBind();

    }
}