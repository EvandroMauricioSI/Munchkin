using Munchkin.Domain.Entities;

namespace Munchkin.Domain.Factory
{
    public class PlayerFactory
    {
        public List<Player> CreatePlayers()
        {
            return new List<Player>()
            {
                new Player("Myself"),
                new Player("Player1"),
                new Player("Player2"),
                new Player("Player3")
            };
        }
    }
}
