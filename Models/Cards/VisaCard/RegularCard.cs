using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models.Cards.VisaCard
{
    public class RegularCard : IVisaCard
    {
        public string Id { get; set; }
        public string Model { get; } = "Regular";
        public string Type { get; } = "Visa";
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
