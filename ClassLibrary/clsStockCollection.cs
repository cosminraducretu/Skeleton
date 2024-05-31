using System;
using System.Collections.Generic;
using System.Net;
namespace ClassLibrary
{
    public class clsStockCollection
    {


        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for this address
        clsStock mThisStock = new clsStock();



        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll"); 
            PopulateArray(DB);
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@IPTVDescription", mThisStock.Description);
            DB.AddParameter("@Supplier", mThisStock.Supplier);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StockID", mThisStock.StockID);
            DB.Execute("sproc_tblStock_Delete");
        }

        //public void ReportBySubscriptionPlan(string v)
        //{

        //}

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@IPTVDescription", mThisStock.Description);
            DB.AddParameter("@Supplier", mThisStock.Supplier);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.Execute("sproc_tblStock_Update");
        }
        public void ReportByAvailable(bool isAvailable)
        {
            //filters the records base on a full or partial address
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the Address parameter to the database
            DB.AddParameter("@Available", isAvailable);
            //execute the store procedure
            DB.Execute("sproc_tblStock_FilterByAvailable");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB 
            //variable for the index 
            Int32 index = 0;
            //variable to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private list to process
            mStockList = new List<clsStock>();
            while (index < RecordCount)
            {
                //create a blank stock object
                clsStock AnStock = new clsStock();
                //read in the fields from the current record
                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[index]["StockID"]);
                AnStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[index]["Quantity"]);
                AnStock.Description = Convert.ToString(DB.DataTable.Rows[index]["IPTVDescription"]); // Ensure this matches your database column name
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[index]["Price"]);
                AnStock.Supplier = Convert.ToString(DB.DataTable.Rows[index]["Supplier"]);
                AnStock.Available = Convert.ToBoolean(DB.DataTable.Rows[index]["Available"]);
                //add the record to the private data member
                mStockList.Add(AnStock);
                //point at the next record 
                index++;
            }
        }



    }
}