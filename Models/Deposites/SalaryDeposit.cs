using Bank.Interfaces;

namespace Bank.Models.Deposites
{
    public class SalaryDeposit : IDeposit
    {
        private Deposit deposit = new Deposit();
        public SalaryDeposit()
        {
            this.NewDeposit();
        }

        public void NewDeposit()
        {
            this.deposit = new Deposit();
        }

        public void GetDepositType()
        {
            this.deposit.Type = "Salary Deposit";
        }
        public void GetCurrency()
        {
            this.deposit.Currency = "MD";
        }

        public void GetAmount()
        {
            this.deposit.Amount = 200;
        }

        public void GetPeriod()
        {
            this.deposit.Period = 12;
        }

        public void GetInterest()
        {
            this.deposit.Interest = (this.deposit.Amount * 4) / 100 * this.deposit.Period;
        }

        public Deposit GetDeposit()
        {
            Deposit newDeposit = this.deposit;
            this.NewDeposit();
            return newDeposit;
        }
    }
}
