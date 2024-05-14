using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }


        [TestMethod]
        public void CustomerIPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnId = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnId.ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnId.ID, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AEmail = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Some Email";
            //assign the data to the property
            AEmail.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEmail.Email, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AFirstName = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "A FirstName";
            //assign the data to the property
            AFirstName.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AFirstName.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ALastName = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "A LastName";
            //assign the data to the property
            ALastName.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ALastName.LastName, TestData);
        }
        [TestMethod]
        public void SubscriptionPlanPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ASubscriptionPlan = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "some Plans";
            //assign the data to the property
            ASubscriptionPlan.SubscriptionPlan = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASubscriptionPlan.SubscriptionPlan, TestData);
        }
        [TestMethod]
        public void SubscriptionStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ASubscriptionStatus = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ASubscriptionStatus.SubscriptionStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASubscriptionStatus.SubscriptionStatus, TestData);
        }
        [TestMethod]
        public void AgePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnAge = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAge.Age = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAge.Age, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create an boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int ID = 21;
            //invoke the method 
            Found = ACustomer.Find(ID);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create an boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ID = 21;
            //invoke the method
            Found = AnCustomer.Find(ID);
            //check the ID property
            if (AnCustomer.ID != 21)
            {
                OK = false;
            }

            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ID = 21;
            //invoke the method
            Found = AnCustomer.Find(ID);
            //check the FirstName property
            if (AnCustomer.FirstName != "Test First Name")
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ID = 21;
            //invoke the method
            Found = AnCustomer.Find(ID);
            //check the LastName property
            if (AnCustomer.LastName != "Test Last Name")
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ID = 21;
            //check the Email property
            Found = AnCustomer.Find(ID);
            if (AnCustomer.Email != "Test Email")
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestSubscriptionPlanFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ID = 21;
            //invoke the method
            Found = AnCustomer.Find(ID);
            //check the SubscriptionPlan property
            if (AnCustomer.SubscriptionPlan != "Test Plan")
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestAgeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ID = 21;
            //invoke the method
            Found = AnCustomer.Find(ID);
            //check the Age property
            if (AnCustomer.Age != 1)
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestSubscriptionStatusFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ID = 21;
            //invoke the method
            Found = AnCustomer.Find(ID);
            //check the SubscriptionStatus property
            if (AnCustomer.SubscriptionStatus != true)
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
    }
}
