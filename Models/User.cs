﻿using System;
using System.Collections.Generic;

namespace Bank.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Wallet> Wallets { get; set; }
    }
}
