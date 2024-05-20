using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {
         
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
    

    public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
            }
        }
        public clsCustomer ThisCustomer { get; set; }
    }
  
   
}
