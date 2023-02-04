using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";

            john.Introduction();

            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
