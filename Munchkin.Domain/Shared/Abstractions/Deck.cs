
namespace Munchkin.Domain.Shared.Abstractions
{
    public abstract class Deck
    {
        protected Deck(List<Card> cards)
        {
            Cards = cards;
        }

        public List<Card> Cards { get; private set; }

        public virtual Card ChooseCard()
        {
            Random random = new Random();

            int randomIndex = random.Next(Cards.Count);

            return Cards[randomIndex];
        }
    }
}
