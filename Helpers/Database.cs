using System.Collections.Generic;
using Bank.Models;

namespace Bank.Helpers
{
    class Database
    {
        private Database() { }

        private static Database _instance = null;
        private static readonly object _lock = new object();
        public List<User> UserContext { get; set; }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Database {
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

