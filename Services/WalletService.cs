using System;
using Bank.Models;

namespace Bank.Services
{
    public class WalletService
    {
        public Wallet CreateWallet()
        {
            Console.WriteLine("Choose a currency :");
            var currency = Console.ReadLine();
            var newWallet = new Wallet
            {
                Id = Guid.NewGuid(),
                Currency = currency,
                Amount = 0
            };

            return newWallet;
        }
    }
}
