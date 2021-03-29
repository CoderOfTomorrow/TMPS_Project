using Bank.Helpers;
using Bank.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Views
{
    public class DatabasePanelView
    {
        private static readonly UserService userService = new UserService();
        private static readonly Database database = Database.GetInstance();
        public void GetView()
        {
            //Console.Clear();
            //database.DatabaseInfo();
            //Console.WriteLine("\nChoose an option :");
            //Console.WriteLine("1.Delet all users");
            //Console.WriteLine("2.Delet an user by index");
            //Console.WriteLine("... Go to first view");
            //Console.Write("--> ");
            //var option = Console.ReadLine();
            //if (option == "1")
            //{
            //    if (database.GetUserCount() > 0)
            //    {
            //        database.DeletAllUsers();
            //        Console.WriteLine("\nYou deleted succesfull all users from database");
            //        Console.ReadKey();
            //        GetView();
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nThe database is empty");
            //        Console.ReadKey();
            //        GetView();
            //    }
            //}
            //else if (option == "2")
            //{
            //    Console.Write("\nEnter the index - ");
            //    var input = Console.ReadLine();
            //    var isNumeric = int.TryParse(input, out int index);
            //    if (isNumeric && database.GetUserCount() > index && index > -1)
            //    {
            //        database.DeleteUser(index);
            //        Console.WriteLine("You removed succesfull user on " + index + " index");
            //        Console.ReadKey();
            //        GetView();
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nThe index is invalid");
            //        Console.ReadKey();
            //        GetView();
            //    }
            //}
        }
    }
}
