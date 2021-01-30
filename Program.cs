using System;
using Bank.Services;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            WalletService walletService = new WalletService();
            UserService userService = new UserService(walletService);

            Console.WriteLine("Do you want to create a new user <YES> or <NO> ?");
            var response = Console.ReadLine();

            if(response == "YES" || response == "yes" || response == "Yes")
            {
                Console.Clear();
                var newUser = userService.Register();
                Console.Clear();
                userService.ShowUserInfo(newUser);
            }
        }
    }
}
