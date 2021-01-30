using System;

namespace Bank.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public string Currency { get; set; }
        public decimal Amount {get; set;}
    }
}
