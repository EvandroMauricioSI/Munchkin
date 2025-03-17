using Munchkin.Domain.Enums;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities.Cards
{
    public class Race : Card
    {
        public Race(string name, int effect) 
            : base(name, effect, CardType.Race)
        {
        }
    }
}
