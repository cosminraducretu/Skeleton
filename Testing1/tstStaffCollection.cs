using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an Item to the List
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Cosmin";
            TestItem.LastName = "Cretu";
            TestItem.Address = "Leicester";
            TestItem.Age = 29;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the tes object
            TestStaff.Active = true;
            TestStaff.StaffID = 1;
            TestStaff.FirstName = "Cosmin";
            TestStaff.LastName = "Cretu";
            TestStaff.Address = "Leicester";
            TestStaff.Age = 29;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add the item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 1;
            TestItem.FirstName = "Cosmin";
            TestItem.LastName = "Cretu";
            TestItem.Address = "Leicester";
            TestItem.Age = 29;
            TestItem.Active = true;
            //add the item to the test list 
            TestList.Add(TestItem);
            //add the item to the test list
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 1;
            TestItem.FirstName = "Cosmin";
            TestItem.LastName = "Cretu";
            TestItem.Address = "Leicester";
            TestItem.Age = 21;
            TestItem.Active = true;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 1;
            TestItem.FirstName = "Cosmin";
            TestItem.LastName = "Cretu";
            TestItem.Address = "Leicester";
            TestItem.Age = 29;
            TestItem.Active = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;

            // Modify the test record
            TestItem.FirstName = "Mioara";
            TestItem.LastName = "Luca";
            TestItem.Address = "Rome";
            TestItem.Age = 34;
            TestItem.Active = false; // Ensure this line sets the Active property
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();

            // Find the updated record
            AllStaff.ThisStaff.Find(PrimaryKey);

            // Assert equality of the updated record
            Assert.AreEqual(AllStaff.ThisStaff.FirstName, TestItem.FirstName);
            Assert.AreEqual(AllStaff.ThisStaff.LastName, TestItem.LastName);
            Assert.AreEqual(AllStaff.ThisStaff.Address, TestItem.Address);
            Assert.AreEqual(AllStaff.ThisStaff.Age, TestItem.Age);
            Assert.AreEqual(AllStaff.ThisStaff.Active, TestItem.Active);
        }
        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 1;
            TestItem.FirstName = "Cosmin";
            TestItem.LastName = "Cretu";
            TestItem.Address = "Leicester";
            TestItem.Age = 21;
            TestItem.Active = true;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record 
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

            [TestMethod]
            public void ReportByAddressMethodOK()
            {
                // Create an instance of the class we want to create
                clsStaffCollection AllStaff = new clsStaffCollection();
                // Create an instance of the filtered data
                clsStaffCollection FilteredStaff = new clsStaffCollection();
                // Apply a blank string (should return all records)
                FilteredStaff.ReportByAddress("");
                // Test to see that the two values are the same
                Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
            }

            [TestMethod]
            public void ReportByAddressNotFound()
            {
                // Create an instance of the class we want to create
                clsStaffCollection FilteredStaff = new clsStaffCollection();
                // Apply an address that doesn't exist
                FilteredStaff.ReportByAddress("xxxxxxx");
                // Test to see that there are no records
                Assert.AreEqual(0, FilteredStaff.Count);
            }

            [TestMethod]
            public void ReportByAddressTestDataFound()
            {
                // Create an instance of the class we want to create
                clsStaffCollection FilteredStaff = new clsStaffCollection();
                // Variable to store the outcome
                Boolean OK = true;
                // Apply an address that is expected to return specific records
                FilteredStaff.ReportByAddress("Known Address");
                // Check that the correct number of records are found
                if (FilteredStaff.Count == 2)
                {
                    // Check to see that the first record is 10
                    if (FilteredStaff.StaffList[0].StaffID != 25)
                    {
                        OK = false;
                    }
                    // Check to see that the second record is 11
                    if (FilteredStaff.StaffList[1].StaffID != 26)
                    {
                        OK = false;
                    }
                }
                else
                {
                    OK = false;
                }
                // Test to see that the outcome is as expected
                Assert.IsTrue(OK);
            }
        
        
    }
}

    
