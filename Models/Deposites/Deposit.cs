using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models.Deposites
{
    public class Deposit
    {
        public string Type { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public int Period { get; set; }
        public decimal Interest { get; set; }
    }
}
