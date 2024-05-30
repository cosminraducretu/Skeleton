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
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Description", mThisStock.Description);
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
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Supplier", mThisStock.Supplier);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.Execute("sproc_tblStock_Update");
        }
        public void ReportByAvailable(bool Available)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Available", Available);
            DB.Execute("sproc_tblStock_FilterByAvailable");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsStock AnIPTTV = new clsStock();
                //read in the fields from the current record
                AnIPTTV.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AnIPTTV.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnIPTTV.Description = Convert.ToString(DB.DataTable.Rows[Index]["IPTVDescription"]);
                AnIPTTV.Supplier = Convert.ToString(DB.DataTable.Rows[Index]["Supplier"]);
                AnIPTTV.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnIPTTV.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                mStockList.Add(AnIPTTV);
                //point at the next record
                Index++;
            }
        }



    }
}