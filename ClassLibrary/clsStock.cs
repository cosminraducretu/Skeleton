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
        public string Valid(string houseNo, string street, string town, string postCode,string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (houseNo.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (houseNo.Length > 6)
            {
                //record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }
            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (postCode.Length > 9)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }
            //is the street blank
            if (street.Length == 0)
            {
                //record the error
                Error = Error + "The street may not be blank : ";
            }
            //if the street is too long
            if (street.Length > 50)
            {
                //record the error
                Error = Error + "The street must be less than 50 characters : ";
            }
            //is the town blank
            if (town.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the town is too long
            if (town.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}