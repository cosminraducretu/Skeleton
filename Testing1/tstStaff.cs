using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
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
            AnId.Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnId.Id, TestData);
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
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //test to see if the result is true 
            Assert.IsTrue(Found);

        }
    }
}



