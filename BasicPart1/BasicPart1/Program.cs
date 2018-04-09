using System;

namespace BasicPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1995;
            string name = "Chanchira";
            double points = 3.50;
            bool status = false;
            year = year + 543;
            Console.WriteLine("My name is :" + name);
            Console.WriteLine("Grade :" + points);
            Console.WriteLine("Years :" + year);
            Console.WriteLine("Status :" + status);
            Console.ReadKey();
        }
    }
}
