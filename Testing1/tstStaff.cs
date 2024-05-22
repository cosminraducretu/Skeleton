using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //create some test data to pass the methods
        
        string FirstName = "Cosmin-Radu";
        string LastName = "Cretu";
        string Address = "Leicester";
        string Age = "28";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnID = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnID.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnID.StaffID, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AFirstName = new clsStaff();
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
            clsStaff AnLastName = new clsStaff();
            //create some test data to assign to the property
            string TestData = "An LastName";
            //assign the data to the property
            AnLastName.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnLastName.LastName, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            string TestData = "some Plans";
            //assign the data to the property
            AnAddress.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Address, TestData);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnActive = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnActive.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnActive.Active, TestData);
        }
        [TestMethod]
        public void AgePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAge = new clsStaff();
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
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int StaffID = 3;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the ID property
            if (AnStaff.StaffID != 3)
            {
                OK = false;
            }

            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the FirstName property
            if (AnStaff.FirstName != "Cosmin")
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
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.LastName != "Cretu")
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //check the Address property
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Address != "Leicester")
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
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the Age property
            if (AnStaff.Age != 29)
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
           clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
           clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
           clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
           clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "a";
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aa";
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Address = "";
            Address = Address.PadRight(51, 'a');
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(500, 'a');
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void AgeExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            int TestAge;
            //set the age to today's age
            TestAge = 0;
            //this should fail
            string Age = TestAge.ToString();
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void AgeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            int TestAge;
            TestAge = 17;
            string Age = TestAge.ToString();
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AgeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            int TestAge;
            TestAge = 18;
            string Age = TestAge.ToString();
            //invoke the method;
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AgeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            int TestAge;
            TestAge = 19;
            string Age = TestAge.ToString();
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AgeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            int TestAge;
            TestAge = 74;
            string Age = TestAge.ToString();
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AgeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            int TestAge;
            TestAge = 75;
            string Age = TestAge.ToString();
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AgeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            int TestAge;
            TestAge = 76;
            string Age = TestAge.ToString();
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AgeMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            int TestAge;
            TestAge = 38;
            string Age = TestAge.ToString();
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AgeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should Fail
            int TestAge;
            TestAge = 500;
            string Age = TestAge.ToString();
            //invoke the method
             Error = AnStaff.Valid(FirstName,LastName,Address,Age);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}


