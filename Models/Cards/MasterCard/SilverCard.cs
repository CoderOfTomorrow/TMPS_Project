using System;
using System.Collections.Generic;
using System.Text;
using Bank.Interfaces;

namespace Bank.Models.Cards.MasterCard
{
    public class SilverCard : IMasterCard
    {
        public string Id { get; set; }
        public string Model { get; } = "Silver";
        public string Type { get; } = "Master";
        public string Password { get; set; }
        public string Cvv { get; set; }
        public string Owner { get; set; }
        public string ExpireDate { get; set; }
        public ICard Clone()
        {
            return MemberwiseClone() as ICard;
        }
    }
}
