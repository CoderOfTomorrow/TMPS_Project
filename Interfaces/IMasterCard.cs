using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Interfaces
{
    public interface IMasterCard : ICard
    {
        public string Id { get; set; }
        public string Model { get; }
        public string Type { get; }
        public string Password { get; set; }
        public string Cvv { get; set; }
        public string Owner { get; set; }
        public string ExpireDate { get; set; }
    }
}
