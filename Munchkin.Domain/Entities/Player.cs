using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities
{
    public class Player
    {
        public Player(string username)
        {
            Username = username;
            Level = 1;
            Cards = new List<Card>();
            Backpack = new Backpack();
        }

        public string Username { get; private set; }
        public int Level { get; private set; }
        public List<Card> Cards { get; private set; }
        public int Power { get; private set; }
        public Backpack Backpack { get; private set; }
        
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void SetPower()
        {
            int totalPower = 0;

            foreach (var card in Cards)
            {
                if(card.Type != Enums.CardType.Monster)
                {
                    totalPower += card.Effect;
                }
            }

            Power = totalPower; ;
        }

        public void AddPower(int power)
        {
            Power += power;
        }
    }
}
