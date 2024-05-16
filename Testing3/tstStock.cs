using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnIPTV);
        }

        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void StockIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnId = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnId.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnId.StockID, TestData);
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
            clsStock AnIPTV = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnIPTV.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIPTV.Available, TestData);
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

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockID = 21;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestStockIdFound()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 21;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.StockID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 21;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Quantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 21;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Description != "##")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 21;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 21;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Price != 33)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierFound()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 21;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Supplier != "name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
