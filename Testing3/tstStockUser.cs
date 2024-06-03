﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockUser AnUser = new clsStockUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "Cosmin";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "Cosmin123";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "Staff";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStockUser AnUser = new clsStockUser();
            Boolean Found = false;
            string UserName = "Cosmin";
            string Password = "Cosmin123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsStockUser AnUser = new clsStockUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Cosmin";
            string Password = "Cosmin123";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
