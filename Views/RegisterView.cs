using System;
using Bank.Services;

namespace Bank.Views
{
    public class RegisterView
    {
        private static readonly UserService userService = new UserService();
        public void GetView()
        {
            Console.Clear();
            if (userService.Register())
            {
                Console.Clear();
                Console.WriteLine("\nDo you want to loging with this account ?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("...No");
                var option = Console.ReadLine();
                if (option == "1")
                {
                    var loginView = new LoginView();
                    loginView.GetView();
                }
            }
        }
    }
}
