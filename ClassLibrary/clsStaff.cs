using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Availability { get; set; }

        public bool Find(int staffID)
        {
            return true;
        }
    }
}