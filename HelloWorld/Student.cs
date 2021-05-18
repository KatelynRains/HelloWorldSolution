using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Student
    {   //property
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Active { get; set; }
        private DateTime HireDate { get; set; } //private: no other classes can use - only the Student class

        //Methods

        public void SetHireDate(int year, int month, int day)
        { 
            if (year < 1950 || year > 2200)  // || is 'OR'
            {
                Console.WriteLine($"Year must be between 1950 and 2200"); //looking for error and will display this message
                return; //means to get out of the method if true
            }  
            if (month < 1 || month > 12) 
            { 
                Console.WriteLine($"Do you know what a calendar is??? 1 <= x <= 12");
                return;
            }
            if (day < 1 || day > 31) 
            { 
                Console.WriteLine($"Invalid day!");
                return;            
             }
            HireDate = new DateTime(year, month, day);
        }
        public void Print() // return type - void doesnt retun anything; methods always have ()
        {
            Console.WriteLine($"{Firstname} {Lastname} Hired: {HireDate.ToString("MM/dd/yyyy")}");
        }   

    }
}
