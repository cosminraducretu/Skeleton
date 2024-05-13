using System;

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
            mStaffID = 21;
            mFirstName = "Test First Name";
            mLastName = "Test Last Name";
            mSalary = 1;
            mDepartment = "Test Department";
            mAvailability = true;
            return true;
        }

    }
}