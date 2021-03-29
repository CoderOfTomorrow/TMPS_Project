using Bank.Interfaces;
using RegularVisa = Bank.Models.Cards.VisaCard.RegularCard;
using RegularMaster = Bank.Models.Cards.MasterCard.RegularCard;

namespace Bank.Services.CardService
{
    public class GetRegularCard : IGetCard
    {
        public IVisaCard GetVisaCard()
        {
            RegularVisa newRegularCard = new RegularVisa();

            return newRegularCard;
        }

        public IMasterCard GetMasterCard()
        {
            RegularMaster newRegularCard = new RegularMaster();

            return newRegularCard;
        }
    }
}
