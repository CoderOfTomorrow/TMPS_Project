using System;
using Bank.Views;

namespace Bank.Views
{
    public class StartView
    {
        public void GetView()
        {
            string option = null;

            while (option != "exit")
            {
                Console.Clear();
                Console.WriteLine("Choose an option :");
                Console.WriteLine("1.Register");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Card Service");
                Console.WriteLine("4.management Service");

                Console.WriteLine("To close our aplication pres X or type \"exit\"");
                Console.Write("--> ");
                option = Console.ReadLine();

                if (option == "1")
                {
                    var registerView = new RegisterView();
                    registerView.GetView();
                }
                else if (option == "2")
                {
                    var loginView = new LoginView();
                    loginView.GetView();
                }
                else if (option == "3")
                {
                    var cardView = new CardView();
                    cardView.GetView();
                }
                else if (option == "4")
                {
                    var managementView = new ManagementView();
                    managementView.GetView();
                }
            }
        }
    }
}
