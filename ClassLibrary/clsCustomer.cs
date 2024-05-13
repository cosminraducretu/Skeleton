using System;

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
    }
}