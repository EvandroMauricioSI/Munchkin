using Munchkin.Domain.Enums;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities.Cards
{
    public class Class : Card
    {
        public Class(string name, int effect) 
            :base(name, effect, CardType.Class) 
        {
        }
    }
}
