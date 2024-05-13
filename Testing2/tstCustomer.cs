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
    }
}
