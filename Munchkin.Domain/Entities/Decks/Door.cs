using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities.Decks
{
    public class Door : Deck
    {
        public Door(List<Card> cards) 
            : base(cards)
        {

        }

        public override Card ChooseCard()
        {
            Random random = new Random();

            int randomIndex = random.Next(Cards.Count);

            return Cards[randomIndex];
        }
    }
}
