using System;
using System.Collections.Generic;

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
            mStockList = new List<clsStock>();
            for (int Index = 0; Index < DB.Count; Index++)
            {
                clsStock AStock = new clsStock
                {
                    StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]),
                    Description = Convert.ToString(DB.DataTable.Rows[Index]["IPTVDescription"]),
                    Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]),
                    Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]),
                    Available = Convert.ToInt32(DB.DataTable.Rows[Index]["Available"]),
                    Supplier = Convert.ToString(DB.DataTable.Rows[Index]["Supplier"])
                };
                mStockList.Add(AStock);
            }
        }

        public void ReportByAll()
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure to get all records
            DB.Execute("sproc_tblStock_SelectAll");
            // Populate the array list with the data table
            PopulateArray(DB);
        }


        public void ReportByAvailable(int status)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AvailableStatus", status);
            DB.Execute("sproc_tblStock_FilterByAvailableStatus");
            PopulateArray(DB);
        }
    }
}