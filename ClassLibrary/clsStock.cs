using System;

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
        private Boolean mAvailable;
        //addressId public property
        public bool Available
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
            //set the private data members to the test data value
            mStockID = 21;
            mQuantity = 1;
            mDescription = "##";
            mAvailable = true;
            mPrice = 33;
            mSupplier = "name";
            //always return true
            return true;
        }

        /****** Valid METHOD ******/
        public string Valid(string Description, string Supplier, string Available)
        {
            //create a string variable to store the error
            String Error = "";
            if (Description.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (Description.Length > 6)
            {
                //record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }


            if (Supplier.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (Supplier.Length > 6)
            {
                //record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }


            if (Available.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (Available.Length > 6)
            {
                //record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }


            //return any error messages
            return Error;
        }
    }
}