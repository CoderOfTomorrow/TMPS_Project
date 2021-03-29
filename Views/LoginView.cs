using System;
using Bank.Services;
using Bank.Models;

namespace Bank.Views
{
    public class LoginView
    {
        private static readonly UserService userService = new UserService();

        public void GetView()
        {
            Console.Clear();
            var user = new User();
            Console.WriteLine("Enter your email :");
            Console.Write("--> ");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter your password :");
            Console.Write("--> ");
            user.Password = Console.ReadLine();

            if (userService.Login(user))
            {
                Console.WriteLine("\nSucces ! Your credentials are correct.");
                Console.ReadKey();
                //UserView();
            }
            else
            {
                Console.WriteLine("\nFail ! Your credentials are incorrect.");
                Console.ReadKey();
                //UserView();
            }
        }

    }
}
