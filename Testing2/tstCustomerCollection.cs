using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void instanceOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }
        [TestMethod]
        public void CustomerListOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this cae the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ID = 1;
            TestItem.FirstName = "Danny";
            TestItem.LastName = "Greenfield";
            TestItem.Email = "DannyGreenfield@gmail.com";
            TestItem.SubscriptionPlan = "Standard";
            TestItem.Age = 53;
            //add the item to the test list
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }
        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.ID = 1;
            TestCustomer.FirstName = "Danny";
            TestCustomer.LastName = "Greenfield";
            TestCustomer.Email = "DannyGreenfield@gmail.com";
            TestCustomer.SubscriptionPlan = "Standard";
            TestCustomer.Age = 53;
            //assign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ID = 1;
            TestItem.FirstName = "Danny";
            TestItem.LastName = "Greenfield";
            TestItem.Email = "DannyGreenfield@gmail.com";
            TestItem.SubscriptionPlan = "Standard";
            TestItem.Age = 53;
            //add the item to the test list
            TestList.Add(TestItem);
            //ASSIGN THE DATA TO THE PROPERTY
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.ID = 1;
            TestItem.FirstName = "Danny";
            TestItem.LastName = "Greenfield";
            TestItem.Email = "DannyGreenfield@gmail.com";
            TestItem.SubscriptionPlan = "Standard";
            TestItem.Age = 53;
            TestItem.SubscriptionStatus = true;           //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);


        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.FirstName = "Danny";
            TestItem.LastName = "Greenfield";
            TestItem.Email = "DannyGreenfield@gmail.com";
            TestItem.SubscriptionPlan = "Standard";
            TestItem.Age = 53;
            TestItem.SubscriptionStatus = true;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.ID = PrimaryKey;
            //modify the test record
            TestItem.FirstName = "Lisa";
            TestItem.LastName = "More";
            TestItem.Email = "Lisa@gmail.com";
            TestItem.SubscriptionPlan = "Free";
            TestItem.Age = 34;
            TestItem.SubscriptionStatus = false;
            AllCustomer.ThisCustomer = TestItem;
            AllCustomer.Update();
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.ID = 1;
            TestItem.FirstName = "Danny";
            TestItem.LastName = "Greenfield";
            TestItem.Email = "DannyGreenfield@gmail.com";
            TestItem.SubscriptionPlan = "Standard";
            TestItem.Age = 53;
            TestItem.SubscriptionStatus = true;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.ID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomer.Delete();
            //now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found

            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportBySubscriptionPlanMethodOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomerCollection FilterCustomer = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilterCustomer.ReportBySubscriptionPlan("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, FilterCustomer.Count);
        }
        [TestMethod]
        public void ReportBySubscriptionPlanNoneFound()
        {
            clsCustomerCollection FilterCustomer = new clsCustomerCollection();
            //apply a Plan that does not exist
            FilterCustomer.ReportBySubscriptionPlan("***");
            //test to see that there are no records
            Assert.AreEqual(0, FilterCustomer.Count);
        }
        [TestMethod]
        public void ReportBySubscriptionPlanTestDataFound()
        {
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomer.ReportBySubscriptionPlan("wwwww");
            if (FilteredCustomer.Count == 2)
            {
                if (FilteredCustomer.CustomerList[0].ID != 80)
                {
                    OK = false;
                }

                if (FilteredCustomer.CustomerList[1].ID != 82)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}



