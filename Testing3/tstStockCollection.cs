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
            clsStockCollection allIPTV = new clsStockCollection();
            Assert.IsNotNull(allIPTV);
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
            TestItem.Available = 1;
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
            TestStock.Available = 1;
            //assign the data to the property
            AllIPTV.ThisStock = TestStock;
            //test to see that the two values are the same 
            Assert.AreEqual(AllIPTV.ThisStock, TestStock);
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
            TestItem.Description = "IPTV Premium Package";
            TestItem.Supplier = "Lifestyle Media";
            TestItem.Price = 1;
            TestItem.Available = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //ASSIGN THE DATA TO THE PROPERTY
            AllIPTV.StockList = TestList;
            Assert.AreEqual(AllIPTV.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOk()
        {
            clsStockCollection allIPTV = new clsStockCollection();
            clsStock testItem = new clsStock();
            int primaryKey = 0;
            // Set properties of the test item
            testItem.Description = "IPTV Premium Package";
            testItem.Supplier = "Lifestyle Media";
            testItem.Price = 1;
            testItem.Available = 1;
            allIPTV.ThisStock = testItem;
            // Add the record
            primaryKey = allIPTV.Add();
            // Set the primary key of the test data
            testItem.StockID = primaryKey;
            // Find the record
            allIPTV.ThisStock.Find(primaryKey);
            // Test to see that the two values are the same
            Assert.AreEqual(allIPTV.ThisStock.Quantity, testItem.Quantity);
            Assert.AreEqual(allIPTV.ThisStock.Description, testItem.Description);
            Assert.AreEqual(allIPTV.ThisStock.Supplier, testItem.Supplier);
            Assert.AreEqual(allIPTV.ThisStock.Price, testItem.Price);
            Assert.AreEqual(allIPTV.ThisStock.Available, testItem.Available);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStockCollection AllIPTV = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Quantity = 1;
            TestItem.Description = "IPTV Premium Package";
            TestItem.Supplier = "Lifestyle Media";
            TestItem.Price = 1;
            TestItem.Available = 1;
            AllIPTV.ThisStock = TestItem;
            PrimaryKey = AllIPTV.Add();
            TestItem.StockID = PrimaryKey;
            //modify the test record
            TestItem.Quantity = 3;
            TestItem.Description = "Test Update Method";
            TestItem.Supplier = "Test Update Method";
            TestItem.Price = 10;
            TestItem.Available = 1;
            AllIPTV.ThisStock = TestItem;
            AllIPTV.Update();
            AllIPTV.ThisStock.Find(PrimaryKey);
            // Assert equality of the updated record
            Assert.AreEqual(AllIPTV.ThisStock.Quantity, TestItem.Quantity);
            Assert.AreEqual(AllIPTV.ThisStock.Description, TestItem.Description);
            Assert.AreEqual(AllIPTV.ThisStock.Supplier, TestItem.Supplier);
            Assert.AreEqual(AllIPTV.ThisStock.Available, TestItem.Available);
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
            TestItem.Description = "Test Delete Method";
            TestItem.Supplier = "Test DeleteMethod";
            TestItem.Price = 1;
            TestItem.Available = 1;
            //set ThisStaff to the test data
            AllIPTV.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllIPTV.Add();
            //set the primary key of the test data 
            TestItem.StockID = PrimaryKey;
            //find the record
            AllIPTV.ThisStock.Find(PrimaryKey);
            //delete the record
            AllIPTV.Delete();
            //now find the record 
            Boolean Found = AllIPTV.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllIPTV.ThisStock, TestItem);
        }
        [TestMethod]
        public void ReportByAvailableMethodOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();

            // Apply the filter for available items (true or false)
            FilteredStock.ReportByAvailable(true);

            // Check if all items in FilteredStock are available1
            bool allAvailable = FilteredStock.StockList.TrueForAll(stock => stock.Available == 1);

            // Test to see that the condition holds true
            Assert.IsTrue(allAvailable);
        }


        [TestMethod]
        public void ReportByAvailableNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            // Apply a filter that should return no records (assuming 2 means some status with no records)
            FilteredStock.ReportByAvailable(-1);
            // Test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByAvailableTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            bool OK = true;

            FilteredStock.ReportByAvailable(true);

            if (FilteredStock.Count > 0)
            {
                if (FilteredStock.StockList[0].StockID != 1089 || FilteredStock.StockList[1].StockID != 1090)
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
