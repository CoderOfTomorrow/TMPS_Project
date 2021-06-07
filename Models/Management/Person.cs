using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models.Management
{
    public abstract class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }

        public abstract string DoWork();
    }
}
