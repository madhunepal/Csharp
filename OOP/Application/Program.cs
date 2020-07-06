using System;
using oop.models;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            Staff staff = new Staff();
            obj.FistName = "Madhu";
            Console.WriteLine(obj.FirstName);
        }
    }
}
