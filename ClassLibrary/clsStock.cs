using System;
using static System.Net.Mime.MediaTypeNames;
using System.Net;

namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for the address id property
        private Int32 mStockID;
        //addressId public property
        public int StockID
        {
            get
            {
                //this line of code sends data out of the property
                return mStockID;
            }
            set
            {
                //this line of code allows data into the property
                mStockID = value;
            }
        }

        //private data member for the address id property
        private Int32 mQuantity;
        //addressId public property
        public int Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }
        }

        //private data member for the address id property
        private string mDescription;
        //addressId public property
        public string Description
        {
            get
            {
                //this line of code sends data out of the property
                return mDescription;
            }
            set
            {
                //this line of code allows data into the property
                mDescription = value;
            }
        }

        //private data member for the address id property
        private Int32 mAvailable;
        //addressId public property
        public int Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }

        //private data member for the address id property
        private Int32 mPrice;
        //addressId public property
        public int Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }

        //private data member for the address id property
        private string mSupplier;
        //addressId public property
        public string Supplier
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplier;
            }
            set
            {
                //this line of code allows data into the property
                mSupplier = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int StockID)
        {

            //create an insance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByID");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["IPTVDescription"]);
                mSupplier = Convert.ToString(DB.DataTable.Rows[0]["Supplier"]);
                mAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["Available"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;

            }
        }


        /****** Valid METHOD ******/

        public string Valid(string description, string supplier, string quantity, string price)
        {
            //create a string variable to store the error
            String Error = "";

            // Create temporary variables to store numeric values
            int quantityTemp;
            int priceTemp;

            // Validate description
            if (string.IsNullOrEmpty(description))
            {
                Error += "The description may not be blank. ";
            }
            else if (description.Length > 50)
            {
                Error += "The description must be less than or equal to 50 characters. ";
            }

            // Validate quantity
            if (!int.TryParse(quantity, out quantityTemp))
            {
                Error += "The quantity must be a numeric value. ";
            }
            else
            {
                if (quantityTemp < 1)
                {
                    Error += "The quantity must be 1 or more. ";
                }
                if (quantityTemp > 1000)
                {
                    Error += "The quantity must be less than or equal to 1000. ";
                }
            }

            // Validate price
            if (!int.TryParse(price, out priceTemp))
            {
                Error += "The price must be a numeric value. ";
            }
            else
            {
                if (priceTemp < 1)
                {
                    Error += "The price must be 1 or more. ";
                }
                if (priceTemp > 100)
                {
                    Error += "The price must be less than or equal to 100. ";
                }
            }

            // Validate supplier
            if (string.IsNullOrEmpty(supplier))
            {
                Error += "The supplier may not be blank. ";
            }
            else if (supplier.Length > 50)
            {
                Error += "The supplier must be less than or equal to 50 characters. ";
            }
            //return any error messages
            return Error;
        }
    }
}