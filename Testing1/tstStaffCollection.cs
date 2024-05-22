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
            Assert.AreEqual(AllStaff.StaffList,TestList);

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
            tstStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 1;
            TestItem.FirstName = "Cosmin";
            TestItem.LastName = "Cretu";
            TestItem.Address = "Leicester";
            TestItem.Age = 29;
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
            Assert.AreEqual(AllStaff.ThisStaff,TestItem);
        }
    }


}
