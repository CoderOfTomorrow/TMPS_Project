using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Bank.Models;

namespace Bank.Helpers
{
    public class Database
    {
        private Database() { }

        private static Database _instance = null;
        private static readonly object _lock = new object();
        private static readonly string dbPath = @"database.txt";

        public List<User> UserContext { get; set; }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        if (!File.Exists(dbPath))
                        {
                            File.Create(dbPath);
                            _instance = new Database
                            {
                                UserContext = new List<User>()
                            };
                        }
                        else
                        {
                            _instance = new Database
                            {
                                UserContext = new List<User>()
                            };
                            if (new FileInfo("database.txt").Length != 0)
                            {
                                var jsonString = File.ReadAllText(dbPath);
                                _instance.UserContext = JsonSerializer.Deserialize<List<User>>(jsonString);
                            }
                        }
                    }
                }
            }
            return _instance;
        }

        public void SaveData()
        {
            var jsonString = JsonSerializer.Serialize(UserContext);
            File.WriteAllText(dbPath, jsonString);
        }
    }
}

