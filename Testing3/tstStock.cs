using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
        }
        [TestMethod]
        public void StockIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnId = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnId.Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnId.Id, TestData);
        }
        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock ADescription = new clsStock();
            //create some test data to assign to the property
            string TestData = "Some Description";
            //assign the data to the property
            ADescription.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADescription.Description, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Quantity = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Quantity.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Quantity.Quantity, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock APrice = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            APrice.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APrice.Price, TestData);
        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Available, TestData);
        }
        [TestMethod]
        public void SupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock ASupplier = new clsStock();
            //create some test data to assign to the property
            string TestData = "Some Supplier";
            //assign the data to the property
            ASupplier.Supplier = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.Supplier, TestData);
        }
    }
}
