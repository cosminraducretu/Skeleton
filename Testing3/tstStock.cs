using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        // Test data
        string description = "desc"; 
        string available = "1"; 
        string supplier = "Suplr";
        string quantity = "10";
        string price = "20";





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
            Int32 TestData = 1;
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
            Int32 StockID = 1092;
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
            Int32 StockID = 1092;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.StockID != 1092)
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
            Int32 StockID = 1079;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Quantity != 0)
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
            Int32 StockID = 1092;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Description != "IPTV Kids Channel Pack")
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
            Int32 StockID = 1092;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Available != 1)
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
            Int32 StockID = 1092;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Price != 40)
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
            Int32 StockID = 1092;
            //invoke the method
            Found = AnIPTV.Find(StockID);
            //check the address id property
            if (AnIPTV.Supplier != "KidsZone Media")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /******************Valid Method TEST******************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






        /******************Quantity Validation TESTS******************/

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string quantity = "";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string quantity = ""; //this should fail
            quantity = quantity.PadRight(500, 'a');
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string quantity = "500"; //this should pass
                                     //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string quantity = "499"; //this should pass
                                     //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPLusOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string quantity = "1001"; //this should fail
                                     //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string quantity = "250"; //this should pass
                                     //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string quantity = "1"; //this should pass
                                   //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string quantity = "2"; //this should pass
                                   //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        /******************Price Validation TESTS******************/

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string price = "";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string price = ""; //this should fail
            price = price.PadRight(500, 'a');
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string price = "100"; //this should pass
                                  //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string price = "99"; //this should pass
                                 //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPLusOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string price = "101"; //this should fail
                                  //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string price = "50"; //this should pass
                                 //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string price = "1"; //this should pass
                                //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string price = "2"; //this should pass
                                //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        /******************Supplier Validation TESTS******************/


        [TestMethod]
        public void supplierMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string supplier = "";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void supplierMin()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string supplier = "a";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void supplierMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string supplier = "aa";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string supplier = "";
            supplier = supplier.PadRight(49, 'a');
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void supplierMax()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string supplier = "";
            supplier = supplier.PadRight(50, 'a');
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void supplierMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string supplier = "";
            supplier = supplier.PadRight(51, 'a');
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void supplierMid()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string supplier = "";
            supplier = supplier.PadRight(25, 'a');
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        /******************Description Validation TESTS******************/


        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string description = "";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string description = "a";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string description = "aa";
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string description = "";
            description = description.PadRight(49, 'a'); //this should pass
                                                          //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string description = "";
            description = description.PadRight(50, 'a'); //this should pass
                                                          //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string description = "";
            description = description.PadRight(501, 'a');
            //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock AnIPTV = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string description = "";
            description = description.PadRight(50, 'a'); //this should pass
                                                          //invoke the method
            Error = AnIPTV.Valid(description, supplier, quantity, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
