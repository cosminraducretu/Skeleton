using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for this address
        clsCustomer mThisCustomer = new clsCustomer();

        // constructor for the class
        public clsCustomerCollection()
        {

            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current record
                AnCustomer.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                AnCustomer.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["ID"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.SubscriptionPlan = Convert.ToString(DB.DataTable.Rows[Index]["SubscriptionPlan"]);
                AnCustomer.SubscriptionStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["SubscriptionStatus"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;

            }
        }
       


        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
        clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@SubscriptionPlan", mThisCustomer.SubscriptionPlan);
            DB.AddParameter("@Age", mThisCustomer.Age);
            DB.AddParameter("@SubscriptionStatus", mThisCustomer.SubscriptionStatus);
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", mThisCustomer.ID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@SubscriptionPlan", mThisCustomer.SubscriptionPlan);
            DB.AddParameter("@Age", mThisCustomer.Age);
            DB.AddParameter("@SubscriptionStatus", mThisCustomer.SubscriptionStatus);
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
   

}
