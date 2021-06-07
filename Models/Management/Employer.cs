using System.Collections.Generic;

namespace Bank.Models.Management
{
    public class Employer : Person
    {
        public Employer(string name) : base(name)
        {

        }

        public override string DoWork()
        {

            return "I am a simple employer. My name is " + name +"\n";

        }
    }
}
