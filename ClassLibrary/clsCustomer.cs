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
            mID = 21;
            mFirstName = "Test First Name";
            mLastName = "Test Last Name";
            mEmail = "Test Email";
            mSubscriptionPlan = "Test Plan";
            mSubscriptionStatus = true;
            mAge = 1;
            return true;
        }
        public string Valid(string FirstName, string LastName, string Email, string SubscriptionPlan, int Age)
        {
            //create a string variable to store the error
            string Error = "";
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
            //if the Age is blank
            if (Age == 0)
            {

                //record the error
                Error = Error + "The Age may not be blank : ";
            }
            if (Age > 75)
            {
                Error = Error + "The Age must be less than 75 : ";
            }
            //return any error messages
            return Error;
        }

    }
}
    
 
    

