using System;
using System.Collections.Generic;



namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //privare data member for the list 
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for this address
        clsStaff mThisStaff = new clsStaff();
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        //public property for the staff list 
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }



        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list 
                return mStaffList.Count;
            }
            set
            {
                //Later
            }
        }



        //contructor for the class 
        public clsStaffCollection()
        {

            
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);

        }

        public int Add()
        {
            //add a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Age", mThisStaff.Age);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the query and return the new record's ID
            return DB.Execute("sproc_tblStaff_Insert");


        }

        public void Update()
        {
            //add a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Age", mThisStaff.Age);
            DB.AddParameter("@Active", mThisStaff.Active);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }


        public void Delete()
        {
            //delete the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the store procedure 
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByAddress(string Address)
        {
            //filters the records base on a full or partial address
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the Address parameter to the database
            DB.AddParameter("@Address", Address);
            //execute the store procedure
            DB.Execute("sproc_tblStaff_FilterByAddress");
            //populate the array list with the data table 
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB 
            //variable for the index 
            Int32 index = 0;
            //variable to store the record count 
            Int32 RecordCount;
            //get tje cpimd pf records
            RecordCount= DB.Count;
            //clear the private record to process
            mStaffList = new List<clsStaff>();
            while (index < RecordCount)
            {   
                //create a blank address object
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[index]["StaffID"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[index]["LastName"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[index]["Address"]);
                AnStaff.Age = Convert.ToInt32(DB.DataTable.Rows[index]["Age"]);
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[index]["Active"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record 
                index++;
            }
        }


    }
}