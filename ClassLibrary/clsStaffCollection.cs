using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //privare data member for the list 
        List<clsStaff> mStaffList = new List<clsStaff>();


        public clsStaff ThisStaff { get; set; }



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


            //create  he items of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Cosmin";
            TestItem.LastName = "Cretu";
            TestItem.Address = "Leicester";
            //add the test item to the test list
            mStaffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem= new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffID = 2;
            TestItem.FirstName = "Mioara";
            TestItem.LastName = "Luca";
            TestItem.Address = "Roma";
            //add the item to the test list 
            mStaffList.Add(TestItem);
        }

    }

    

}