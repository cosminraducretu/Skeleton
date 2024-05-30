using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void instanceOk()
        {
            clsStockCollection AllIPTV = new clsStockCollection();
            Assert.IsNotNull(AllIPTV);
        }
        [TestMethod]
        public void StockListOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllIPTV = new clsStockCollection();
            //create some test data to assign to the property
            //in this cae the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = 1;
            TestItem.Quantity = 1;
            TestItem.Description = "Desc";
            TestItem.Supplier = "Supplier";
            TestItem.Price = 1;
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem);
            AllIPTV.StockList = TestList;
            Assert.AreEqual(AllIPTV.StockList, TestList);
        }
        [TestMethod]
        public void ThisStockPropertyOk()
        {
            clsStockCollection AllIPTV = new clsStockCollection();
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.StockID = 1;
            TestStock.Quantity = 1;
            TestStock.Description = "Desc";
            TestStock.Supplier = "Supplier";
            TestStock.Price = 1;
            TestStock.Available = true;
            //assign the data to the property
            AllIPTV.ThisStock = TestStock;
            //test to see that the two values are the same

        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsStockCollection AllIPTV = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = 1;
            TestItem.Quantity = 1;
            TestItem.Description = "Desc";
            TestItem.Supplier = "Supplier";
            TestItem.Price = 1;
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //ASSIGN THE DATA TO THE PROPERTY
            AllIPTV.StockList = TestList;
            Assert.AreEqual(AllIPTV.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOk()
        {
            clsStockCollection AllIPTV = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockID = 1;
            TestItem.Quantity = 1;
            TestItem.Description = "Desc";
            TestItem.Supplier = "Supplier";
            TestItem.Price = 1;
            TestItem.Available = true;          //set ThisCustomer to the test data
            AllIPTV.ThisStock = TestItem;
            //add the record 
            PrimaryKey = AllIPTV.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllIPTV.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllIPTV.ThisStock, TestItem);


        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStockCollection AllIPTV = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockID = 1;
            TestItem.Quantity = 1;
            TestItem.Description = "Desc";
            TestItem.Supplier = "Supplier";
            TestItem.Price = 1;
            TestItem.Available = true;
            AllIPTV.ThisStock = TestItem;
            PrimaryKey = AllIPTV.Add();
            TestItem.StockID = PrimaryKey;
            //modify the test record
            TestItem.StockID = 2;
            TestItem.Quantity = 3;
            TestItem.Description = "Description";
            TestItem.Supplier = "Suppliermehdi";
            TestItem.Price = 10;
            TestItem.Available = false;
            AllIPTV.ThisStock = TestItem;
            AllIPTV.Update();
            AllIPTV.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllIPTV.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            clsStockCollection AllIPTV = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockID = 1;
            TestItem.Quantity = 1;
            TestItem.Description = "Desc";
            TestItem.Supplier = "Supplier";
            TestItem.Price = 1;
            TestItem.Available = true;
            AllIPTV.ThisStock = TestItem;
            PrimaryKey = AllIPTV.Add();
            TestItem.StockID = PrimaryKey;
            //find the record
            AllIPTV.ThisStock.Find(PrimaryKey);
            //delete the record
            AllIPTV.Delete();
            //now find the record
            Boolean Found = AllIPTV.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found

            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByAvailableMethodOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            // Apply the filter for available items (true or false)
            FilteredStock.ReportByAvailable(true);
            // Test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByAvailableNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            // Apply a filter that should return no records (assuming false means not available)
            FilteredStock.ReportByAvailable(false);
            // Test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByAvailableTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByAvailable(true);
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].Available != true)
                {
                    OK = false;
                }

                if (FilteredStock.StockList[1].Available != true)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
