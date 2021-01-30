using Bank.Models;
using System;
using System.Collections.Generic;

namespace Bank.Services
{
    public class UserService
    {
        private readonly WalletService walletService;
        public UserService(WalletService walletService)
        {
            this.walletService = walletService;
        }
        public User Register()
        {
            Console.WriteLine("Enter your email :");
            var email = Console.ReadLine();
            Console.WriteLine("Enter your password :");
            var password = Console.ReadLine();

            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Email = email,
                Password = password,
                Wallets = new List<Wallet>()
            };

            //Single Responsibility Principle(SRP) in action 
            //we create a new wallet using walletService methode CreateWallet.
            //in this way every service has his own job to do 
            var newWallet = walletService.CreateWallet();
            newUser.Wallets.Add(newWallet);

            return newUser;
        }

        public void ShowUserInfo(User user)
        {
            Console.WriteLine("User credentials :");
            Console.WriteLine("UserName - " + user.UserName);
            Console.WriteLine("Email - " + user.Email);
            Console.WriteLine("Id - " + user.Id);
            Console.WriteLine("Password - " + user.Password);
            Console.WriteLine("Wallets count - " + user.Wallets.Count);
            Console.WriteLine("\nWallets info : ");
            foreach (var wallet in user.Wallets)
            {
                Console.WriteLine("Wallet id - " + wallet.Id);
                Console.WriteLine("Wallet currency - " + wallet.Currency);
                Console.WriteLine("Wallet amount - " + wallet.Amount + "\n");
                
            }
        }
    }
}
