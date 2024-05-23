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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
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

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("ID", mThisCustomer.ID);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        //public void ReportBySubscriptionPlan(string v)
        //{

        //}

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
        public void ReportBySubscriptionPlan(string SubscriptionPlan)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SubscriptionPlan", SubscriptionPlan);
            DB.Execute("sproc_tblCustomer_FilterBySubscriptionPlan");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["ID"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.Email= Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.SubscriptionPlan = Convert.ToString(DB.DataTable.Rows[Index]["SubscriptionPlan"]);
                AnCustomer.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                AnCustomer.SubscriptionStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["SubscriptionStatus"]);
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }
    }
   

}
