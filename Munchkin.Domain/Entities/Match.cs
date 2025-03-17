using Munchkin.Domain.Entities.Decks;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities
{
    public class Match
    {
        public List<Player> Players { get; private set; }
        public List<Deck> Decks { get; private set; }

        private static Match? _instance;

        public List<Turn> Turns { get; private set; }
        
        private Match(List<Player> players)
        {
            Players = players;     
            Turns = new List<Turn>();
            Decks = new List<Deck>();
        }

        public static Match GetInstance(List<Player> players)
        {
            if (_instance == null)
            {
                _instance = new Match(players);
            }

            return _instance;
        }
               
        public void Initialize(Deck deck)
        {
            Decks.Add(deck);

            var random = new Random();

            foreach (var player in Players)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (deck.Cards.Count == 0) break;

                    int cardIndex = random.Next(deck.Cards.Count);
                    var card = deck.Cards[cardIndex];

                    player.AddCard(card);
                    deck.Cards.RemoveAt(cardIndex);
                }

                player.SetPower();
            }
        }
    }
}
