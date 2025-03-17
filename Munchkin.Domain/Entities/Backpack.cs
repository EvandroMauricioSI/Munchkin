using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities
{
    public class Backpack
    {
        public Backpack()
        {
            NewCards = new List<Card>();
        }

        public List<Card> NewCards { get; private set; }

        public void AddNewCard(Card card)
        {
            NewCards.Add(card);
        }
    }
}
