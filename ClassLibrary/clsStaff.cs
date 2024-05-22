using System;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace ClassLibrary
{
    public class clsStaff
    {

        private int mStaffID;
        private string mAddress;
        private int mAge;
        private string mFirstName;
        private string mLastName;
        private bool mActive;

        public int StaffID { get { return mStaffID; } set { mStaffID = value; }  }
        public string FirstName { get { return mFirstName; } set { mFirstName = value; } }
        public string LastName { get { return mLastName; } set { mLastName = value; } }
        public string Address { get { return mAddress; } set { mAddress = value; } }
        public int Age { get { return mAge; } set { mAge = value; } }
        public bool Active { get { return mActive; } set { mActive = value; } }

        public bool Find(int StaffID)
            {
                //create an insance of the data connection
                clsDataConnection DB = new clsDataConnection();
                //add the parameter for the address id to search for 
                DB.AddParameter("@StaffID", StaffID);
                //execute the stored procedure
                DB.Execute("sproc_tblStaff_FilterByID");
                //if one record is found (there should be either one or zero
                if (DB.Count == 1)
                {
                    //copy the data from the database to the private data members
                    mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                    mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                    mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                    mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                    mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                    mAge = Convert.ToInt32(DB.DataTable.Rows[0]["Age"]);
                    return true;
                }
                //if no record was found
                else
                {
                    //return false indicating there is a problem
                    return false;

                }
        }

        public string Valid(string FirstName, string LastName, string Address, string Age)
        {
            //create a string variable to store the error
            string Error = "";
            int aAge;
            

            // Validate StaffID input to ensure it's an integer and greater than 0
            
            //if the FirstName is blank
            if (FirstName.Length == 0)
            {
                //record the error
                Error = Error + "The First name may not be blank.<br/>";
            }
            if (FirstName.Length > 50)
            {
                Error = Error + "The First name  must be less than 50.<br/>";
            }
            //if the LastName is blank
            if (LastName.Length == 0)
            {
                //record the error
                Error = Error + "The Last name may not be blank.<br/>";
            }
            if (LastName.Length > 50)
            {
                Error = Error + "The Last name must be less than 50.<br/> ";
            }

            // If the Address is blank
            if (string.IsNullOrWhiteSpace(Address))
            {
                // Record the error
                Error += "The Address may not be blank.<br/>";
            }
            if (Address.Length > 50)
            {
                Error += "The Address must be less than 50 characters.<br/>";
            }

            // Validate Age input to ensure it's an integer
            if (string.IsNullOrWhiteSpace(Age))
            {
                Error += "The Age may not be blank.<br/>";
            }
            else
            {
                try
                {
                    aAge = Convert.ToInt32(Age);
                    // Check if age is less than 18
                    if (aAge < 18)
                    {
                        Error += "The Age must be 18 or higher.<br/>";
                    }
                    // Check if age is greater than 75
                    if (aAge > 75)
                    {
                        Error += "The Age must be 75 or lower.<br/>";
                    }
                }
                catch
                {
                    Error += "The Age must be a valid integer.<br/>";
                }
            }
               
            //return any error messages
            return Error;
        }


    }

}
