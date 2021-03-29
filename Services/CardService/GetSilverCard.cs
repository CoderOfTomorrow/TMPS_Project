using Bank.Interfaces;
using SilverVisa = Bank.Models.Cards.VisaCard.SilverCard;
using SilverMaster = Bank.Models.Cards.MasterCard.SilverCard;

namespace Bank.Services.CardService
{
    public class GetSilverCard : IGetCard
    {
        public IVisaCard GetVisaCard()
        {
            SilverVisa newSilverCard = new SilverVisa();

            return newSilverCard;
        }

        public IMasterCard GetMasterCard()
        {
            SilverMaster newSilverCard = new SilverMaster();

            return newSilverCard;
        }
    }
}
