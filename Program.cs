using System;
using Bank.Services;
using Bank.Helpers;

namespace Bank
{
    class Program
    {
        static void Main()
        {
            WalletService walletService = new WalletService();
            UserService userService = new UserService(walletService);

            string option = null;

            while (option != "0")
            {
                Console.Clear();
                Console.WriteLine("Choose a task :");
                Console.WriteLine("1. Single Responsibility Principle");
                Console.WriteLine("2. Singleton Patter");
                Console.WriteLine("0. Exit");
                Console.Write("\nChoose - ");
                option = Console.ReadLine();
                Console.Clear();

                //Single Responsability Principle
                if (option == "1")
                {
                    Console.WriteLine("Do you want to create a new user ? <YES> or <NO>");
                    var respons = Console.ReadLine();
                    if(respons == "yes" || respons == "YES" || respons == "Yes")
                    {
                        Console.Clear();
                        var newUser = userService.Register();
                        Console.Clear();
                        userService.ShowUserInfo(newUser);
                        Console.ReadKey();
                    }

                }
                //Singleton Pattern
                else if (option == "2")
                {
                    Console.WriteLine("Do you want to create a new user ? <YES> or <NO>");
                    var respons = Console.ReadLine();
                    if (respons == "yes" || respons == "YES" || respons == "Yes")
                    {
                        Console.Clear();
                        var newUser = userService.Register();
                        
                        //we will add the new user to a first instante of SingletonDatabase class
                        var firstContext = SingletonDatabase.GetInstance();
                        firstContext.AddUser(newUser);

                        //then we will try to create a second instance
                        var secondContext = SingletonDatabase.GetInstance();
                        Console.Clear();

                        //if firstContext is the same as secondContext then our SingeltonDatabase works fine
                        if(firstContext == secondContext)
                        { 
                            Console.WriteLine("Singleton works, both variables contain the same instance.");
                        }
                        else
                        {
                            Console.WriteLine("Singleton failed, variables contain different instances.");
                        }
                        Console.ReadKey();
                    }
                }
                else
                    break;
            }
        }
    }
}
