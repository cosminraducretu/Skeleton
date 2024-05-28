using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsUser AnUser = new clsUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsUser AnUser = new clsUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsUser AnUser = new clsUser();
            string TestData = "Danny";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsUser AnUser = new clsUser();
            string TestData = "Lebitcoinlasvegas44";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsUser AnUser = new clsUser();
            string TestData = "Customer";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            string UserName = "Danny";
            string Password = "Lebitcoinlasvegas44";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsUser AnUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Danny";
            string Password = "Lebitcoinlasvegas44";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
