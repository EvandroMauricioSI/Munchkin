using Munchkin.Domain.Enums;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities.Cards
{
    public class Item : Card
    {
        public Item(string name, int effect) 
            : base(name, effect, CardType.Item)
        {
        }
    }
}
