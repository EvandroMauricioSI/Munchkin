using Munchkin.Domain.Entities;
using Munchkin.Domain.Factory;

namespace Munchkin.ApplicationService
{
    public class GameApplicationService
    {
        public readonly PlayerFactory _playerFactory;
        public readonly DeckFactory _deckFactory;

        public GameApplicationService()
        {
            _playerFactory = new PlayerFactory();
            _deckFactory = new DeckFactory();
        }

        public Match InitializeGame()
        {            
            var match =  Match.GetInstance(_playerFactory.CreatePlayers());

            match.Initialize(_deckFactory.CreateDoorDeck());
            match.Initialize(_deckFactory.CreateTreasureDeck());

            return match;
        }        
    }
}
