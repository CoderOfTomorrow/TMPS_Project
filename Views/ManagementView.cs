using Bank.Models.Management;
using Bank.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Views
{
    public class ManagementView
    {
        public void GetView()
        {
            Console.Clear();
            Console.WriteLine("Welcome to our Management Service");

            Manager director = new Manager("Nicolae Sirbu");

            var managementService = new ManagePersonal(director);
            Employer employer1 = new Employer("Lucrator 1");
            Employer employer2 = new Employer("Lucrator 2");
            Manager manager = new Manager("Manager");

            managementService.AddPerson(employer1);
            managementService.AddPerson(employer2);
            managementService.AddPerson(manager);

            managementService = new ManagePersonal(manager);
            Employer employer3 = new Employer("Lucrator 3");
            Employer employer4 = new Employer("Lucrator 4");
            managementService.AddPerson(employer3);
            managementService.AddPerson(employer4);

            Console.WriteLine(director.DoWork());

            Console.ReadKey();
        }
    }
}
