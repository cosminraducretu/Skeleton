using System;
using System.IO;

namespace ClassLibrary
{
    public class clsCustomer
    {

        private int mID;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private string mSubscriptionPlan;
        private bool mSubscriptionStatus;
        private int mAge;

        public int ID { get { return mID; } set { mID = value; } }
        public string Email { get { return mEmail; } set { mEmail = value; } }
        public string FirstName { get { return mFirstName; } set { mFirstName = value; } }
        public string LastName { get { return mLastName; } set { mLastName = value; } }
        public bool SubscriptionStatus { get { return mSubscriptionStatus; } set { mSubscriptionStatus = value; } }
        public string SubscriptionPlan { get { return mSubscriptionPlan; } set { mSubscriptionPlan = value; } }
        public int Age { get { return mAge; } set { mAge = value; } }

        public bool Find(int ID)
        {
            //create an insance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@ID", ID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByID");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["ID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mSubscriptionPlan = Convert.ToString(DB.DataTable.Rows[0]["SubscriptionPlan"]);
                mSubscriptionStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["SubscriptionStatus"]);
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
        public string Valid(string FirstName, string LastName, string Email, string SubscriptionPlan, string Age)
        {
            //create a string variable to store the error
            string Error = "";
            int Agee;
            Agee = Convert.ToInt32(Age);
            //if the FirstName is blank
            if (FirstName.Length == 0)
            {

                //record the error
                Error = Error + "The FirstName may not be blank : ";
            }
            if (FirstName.Length > 50)
            {
                Error = Error + "The FisrtName must be less than 50 : ";
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
            //if the Email is blank
            if (Email.Length == 0)
            {

                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            if (Email.Length > 50)
            {
                Error = Error + "The Email must be less than 50 : ";
            }
            //if the subscriptionPlan is blank
            if (SubscriptionPlan.Length == 0)
            {

                //record the error
                Error = Error + "The ScriptionPlan may not be blank : ";
            }
            if (SubscriptionPlan.Length > 50)
            {
                Error = Error + "The SubscriptionPlan must be less than 50 : ";
            }
            // Check if age is less than the minimum age
            if (Agee < 18)
            {
                Error = Error + "The age must be 18 or older. ";
            }

            // Check if age is greater than the maximum age
            if (Agee > 75)
            {
                Error = Error + "The age must be 75 or younger. ";
            }
            //return any error messages
            return Error;
        }

     
    }
}
    
 
    

