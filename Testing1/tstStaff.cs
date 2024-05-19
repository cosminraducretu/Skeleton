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
        string Department = "StaffManSalaryr";
        string Salary = "28000";


        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnId = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnId.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnId.StaffID, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff ADepartment = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Department";
            //assign the data to the property
            ADepartment.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADepartment.Department, TestData);
        }
        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Salary = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Salary.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Salary.Salary, TestData);
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
            clsStaff ALastName = new clsStaff();
            //create some test data to assign to the property
            string TestData = "A LastName";
            //assign the data to the property
            ALastName.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ALastName.LastName, TestData);
        }

        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAvailability = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAvailability.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAvailability.Availability, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 2;
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
            Int32 StaffID = 21;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the StaffID property
            if (AnStaff.StaffID != 21)
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
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the FirstName property
            if (AnStaff.FirstName != "Test First Name")
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
            Int32 StaffID = 21;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.LastName != "Test Last Name")
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDeparmentFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //check the Department property
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Department != "Test Department")
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the Salary property
            if (AnStaff.Salary != 1)
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create an boolean variable to store the results of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the Availability property
            if (AnStaff.Availability != true)
            {
                OK = false;
            }
            // test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string FirstName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string FirstName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should fail
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string LastName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string LastName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this shold fail
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void DepartmentMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should fail
            string Department = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string Department = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void DepartmentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string Department = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this shold fail
            string Department = "";
            Department = Department.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //create a variable to store the test Salary data
            int TestSalary;
            //set the Salary to today's Salary
            TestSalary = 0;
            //this should fail
            string Salary = TestSalary.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should fail
            int TestSalary;
            TestSalary = 17000;
            string Salary = TestSalary.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            int TestSalary;
            TestSalary = 18000;
            string Salary = TestSalary.ToString();
            //invoke the method;
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            int TestSalary;
            TestSalary = 19000;
            string Salary = TestSalary.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            int TestSalary;
            TestSalary = 74999;
            string Salary = TestSalary.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            int TestSalary;
            TestSalary = 75000;
            string Salary = TestSalary.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should fail
            int TestSalary;
            TestSalary = 75001;
            string Salary = TestSalary.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should pass
            int TestSalary;
            TestSalary = 35000;
            string Salary = TestSalary.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messSalary
            String Error = "";
            //this should Fail
            int TestSalary;
            TestSalary = 500000;
            string Salary = TestSalary.ToString();
            //invoke the method.
            Error = AnStaff.Valid(FirstName, LastName, Department, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}


