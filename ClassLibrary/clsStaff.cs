using System;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace ClassLibrary
{
    public class clsStaff
    {

        private int mStaffID;
        private string mDepartment;
        private int mSalary;
        private string mFirstName;
        private string mLastName;
        private bool mAvailability;

        public int StaffID { get { return mStaffID; } set { mStaffID = value; }  }
        public string Department { get { return mDepartment; } set { mDepartment = value; } }
        public int Salary { get { return mSalary; } set { mSalary = value; } }
        public string FirstName { get { return mFirstName; } set { mFirstName = value; } }
        public string LastName { get { return mLastName; } set { mLastName = value; } }
        public bool Availability { get { return mAvailability; } set { mAvailability = value; } }

        public bool Find(int StaffID)
            {
                //create an insance of the data connection
                clsDataConnection DB = new clsDataConnection();
                //add the parameter for the address id to search for 
                DB.AddParameter("@ID", StaffID);
                //execute the stored procedure
                DB.Execute("sproc_tblStaff_FilterByID");
                //if one record is found (there should be either one or zero
                if (DB.Count == 1)
                {
                    //copy the data from the database to the private data members
                    mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                    mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                    mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                    mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                    mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                    mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                    return true;
                }
                //if no record was found
                else
                {
                    //return false indicating there is a problem
                    return false;

                }
        }

        public string Valid(string FirstName, string LastName, string Department, string Salary)
        {
            //create a string variable to store the error
            string Error = "";
            int SSalary;
            SSalary = Convert.ToInt32(Salary);
            //if the FirstName is blank
            if (FirstName.Length == 0)
            {

                //record the error
                Error = Error + "The FirstName may not be blank : ";
            }
            if (FirstName.Length > 50)
            {
                Error = Error + "The FirstName must be less than 50 : ";
            }
            //if the LastName is blank
            if (LastName.Length == 0)
            {

                //record the error
                Error = Error + "The LastName may not be blank : ";
            }
            if (LastName.Length > 50)
            {
                Error = Error + "The LastName must be less than 50 : ";
            }
            //if the Department is blank
            if (Department.Length == 0)
            {

                //record the error
                Error = Error + "The department may not be blank : ";
            }
            if (Department.Length > 50)
            {
                Error = Error + "The department must be less than 50 : ";
            }
            // Check if salary is less than the minimum salary
            if (SSalary < 18000)
            {
                Error = Error + "The age must be 18000 or higher. ";
            }

            // Check if salary is greater than the maximum salary
            if (SSalary > 75000)
            {
                Error = Error + "The salary must be 75000 or lower. ";
            }
            //return any error messages
            return Error;
        }


    }

}
