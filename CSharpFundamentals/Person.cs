﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduction(string firstName, string lastName)
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
