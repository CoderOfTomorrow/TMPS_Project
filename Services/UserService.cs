using Bank.Models;
using Bank.Helpers;
using Bank.Views;
using System;
using System.Collections.Generic;

namespace Bank.Services
{
    public class UserService
    {
        private readonly WalletService walletService =  new WalletService();
        private readonly EmailService emailService = new EmailService();
        private readonly Database database = Database.GetInstance();
        
        public bool Register()
        {
            Console.WriteLine("Enter your email :");
            var email = Console.ReadLine();

            if (emailService.CheckEmail(email))
            {
                Console.WriteLine("\nThis email is already used.");
                Console.ReadKey();
                return false;
            }
            else
            {
                Console.WriteLine("Enter your password :");
                var password = Console.ReadLine();

                var newUser = new User
                {
                    Id = Guid.NewGuid(),
                    Email = email,
                    Password = password,
                    Wallets = new List<Wallet>()
                };

                var newWallet = walletService.CreateWallet();
                newUser.Wallets.Add(newWallet);

                database.UserContext.Add(newUser);
                database.SaveData();

                return true;
            }
        }

        public bool Login(User user)
        {
            foreach(var obj in database.UserContext)
            {
                if (user.Email == obj.Email && user.Password == obj.Password)
                    return true;
            }

            return false;
        }

        public void DeletAccount()
        {

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
