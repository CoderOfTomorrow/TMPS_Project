using Bank.Services.CardService;
using Bank.Interfaces;
using System;

namespace Bank.Views
{
    public class CardView
    {
        private static readonly CardService cardService = new CardService();
        public void GetView()
        {
            Console.WriteLine("Welcome to our Card Service");
            IGetCard newCard = new GetRegularCard();
            cardService.GetNewCard(newCard);
            Console.ReadKey();

            newCard = new GetSilverCard();
            cardService.GetNewCard(newCard);
            Console.ReadKey();
        }
    }
}
