using Bank.Interfaces;
using System;

namespace Bank.Services.CardService
{
    public class CardService
    {
        public void GetNewCard(IGetCard card)
        {
            Console.WriteLine("Ce tip de card doriti?");
            Console.WriteLine("1.Master");
            Console.WriteLine("2.Visa");
            Console.Write("--> ");
            var r = Console.ReadLine();
            if (r == "1")
            {
                IMasterCard newCard = card.GetMasterCard();
                GetNewMasterCard(newCard);

                var clonedCard = newCard.Clone() as IMasterCard;
                GetNewMasterCard(clonedCard);

            }
            else
            {
                var newCard = card.GetVisaCard();
                GetNewVisaCard(newCard);
            }
        }
        public void GetNewMasterCard(IMasterCard data)
        {
            Console.WriteLine("Aveti un card " + data.Type + data.Model);
        }

        public void GetNewVisaCard(IVisaCard data)
        {
            Console.WriteLine("Aveti un card " + data.Type + data.Model);
        }
    }
}
