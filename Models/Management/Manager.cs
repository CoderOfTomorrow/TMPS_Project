using System.Collections.Generic;

namespace Bank.Models.Management
{
    public class Manager : Person
    {
        public List<Person> employersList = new List<Person>();
        public Manager(string name) : base(name) { 
        
        }

        public override string DoWork()
        {
            string data = "I Am working as a manager. My name is " + name + "\n";
            foreach(var obj in employersList)
            {
                data +=obj.DoWork();
            }
            return data;
        }
    }
}
