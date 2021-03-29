using Bank.Helpers;
using Bank.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Views
{
    public class UserPanelView
    {
        private static readonly UserService userService = new UserService();
        private static readonly Database database = Database.GetInstance();

        public void GetView()
        {
            Console.Clear();
            var status = true;
            while (status)
            {
                Console.WriteLine("User Panel :");
                Console.WriteLine("1.User Info");
                Console.WriteLine("2.Make a deposit");
                Console.WriteLine("...Log Out");
                var option = Console.ReadLine();
                if (option == "1")
                {

                }
                else
                {
                    status = false;
                }

            }

            Console.ReadKey();
        }
    }
}
