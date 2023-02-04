using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
