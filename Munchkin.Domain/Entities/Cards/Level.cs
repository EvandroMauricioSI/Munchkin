using Munchkin.Domain.Enums;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities.Cards
{
    public class Level : Card
    {
        public Level(string name, int effect) 
            : base(name, effect, CardType.Level)
        {
        }
    }
}
