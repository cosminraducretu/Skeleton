using System;
using System.Collections.Generic;
using System.Reflection;


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

        public clsStaffCollection()
        {

            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AnStaff = new clsStaff();
                //read in the fields for the current record
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;

            }
        }

    //    public int Add()
    //    {
    //        ////add a record to the database based on the values of mThisStaff
    //        ////connect to the database
    //        //clsStaffCollection DB = new clsStaffCollection();
    //        ////set the parameters for the stored procedure
    //        //DB.AddParameter("@StaffID", mThisStaff.StaffID);
    //        //DB.AddParameter("@FirstName", mThisStaff.FirstName);
    //        //DB.AddParameter("@LastName", mThisStaff.LastName);
    //        //DB.AddParameter("@Address", mThisStaff.Address);
    //        //DB.AddParameter("@Active", mThisStaff.Active);

    //    }
    }

}