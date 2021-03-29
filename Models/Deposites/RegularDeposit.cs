using Bank.Interfaces;

namespace Bank.Models.Deposites
{
    public class RegularDeposit : IDeposit
    {
        private Deposit deposit = new Deposit();
        
        public RegularDeposit()
        {
            this.NewDeposit();
        }

        public void NewDeposit()
        {
            this.deposit = new Deposit();
        }

        public void GetDepositType()
        {
            this.deposit.Type = "Regular Deposit";
        }
        public void GetCurrency()
        {
            this.deposit.Currency = "MD";
        }

        public void GetAmount()
        {
            this.deposit.Amount = 100;
        }

        public void GetPeriod()
        {
            this.deposit.Period = 6;
        }

        public void GetInterest()
        {
            this.deposit.Interest = (this.deposit.Amount * 3) / 100 * this.deposit.Period;
        }

        public Deposit GetDeposit()
        {
            Deposit newDeposit = this.deposit;
            this.NewDeposit();
            return newDeposit;
        }
    }
}
