using System.Collections.Generic;
using Bank.Models;

namespace Bank.Helpers
{
    class SingletonDatabase
    {
        private SingletonDatabase() { }

        private static SingletonDatabase _instance = null;
        private static readonly object _lock = new object();
        public List<User> UserContext { get; set; }

        public static SingletonDatabase GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonDatabase {
                            UserContext = new List<User>()
                        };
                    }
                }
            }
            return _instance;
        }

        public void AddUser(User newUser)
        {
            UserContext.Add(newUser);
        }
    }
}

