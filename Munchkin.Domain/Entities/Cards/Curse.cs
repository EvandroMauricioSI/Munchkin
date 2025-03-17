using Munchkin.Domain.Enums;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities.Cards
{
    public class Curse : Card
    {
        public Curse(string name, int effect, int damageEffect) 
            :base(name, effect, CardType.Curse) 
        {
            DamageEffect = damageEffect;
        }

        public int DamageEffect { get; private set; }
    }
}
