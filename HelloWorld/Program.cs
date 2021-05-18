using System;
using HelloWorld;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarah = new Student();
            sarah.Firstname = "Sarah";
            sarah.Lastname = "George";
            sarah.SetHireDate(2017, 6, 26);

            var Charlie = new Student();
            Charlie.Firstname = "Charlie";
            Charlie.Lastname = "Traylor";

            var Mattea = new Student();
            Mattea.Firstname = "Mattea";
            Mattea.Lastname = "Swain";

            sarah.Print();
            Charlie.Print();
            Mattea.Print();
            
        }
    }
}
