using Munchkin.Domain.Enums;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities.Cards
{
    public class Gold : Card
    {
        public Gold(string name, int effect) 
            : base(name, effect, CardType.Gold)
        {
        }
    }
}
