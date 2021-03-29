using System;
using Bank.Interfaces;
using Bank.Models.Deposites;

namespace Bank.Services
{
    public class DepositService
    {
        public Deposit GetNewDeposit(IDeposit deposit)
        {
            deposit.GetDepositType();
            deposit.GetCurrency();
            deposit.GetAmount();
            deposit.GetPeriod();
            deposit.GetInterest();

            return deposit.GetDeposit();
        }

        public void ShowDepositInfo(Deposit deposit)
        {
            Console.WriteLine("Deposit info :");
            Console.WriteLine("Deposit type - " + deposit.Type);
            Console.WriteLine("Deposit currency - " + deposit.Currency);
            Console.WriteLine("Deposit amount - " + deposit.Amount);
            Console.WriteLine("Deposit period - " + deposit.Period);
            Console.WriteLine("Deposit interest - " + deposit.Interest);
        }
    }
}
