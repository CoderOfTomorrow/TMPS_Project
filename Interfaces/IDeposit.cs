using Bank.Models.Deposites;

namespace Bank.Interfaces
{
    public interface IDeposit
    {
        public void GetDepositType();
        public void GetCurrency();
        public void GetAmount();
        public void GetPeriod();
        public void GetInterest();
        public Deposit GetDeposit();
    }
}
