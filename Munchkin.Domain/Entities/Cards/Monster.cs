using Munchkin.Domain.Enums;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Entities.Cards
{
    public class Monster : Card
    {
        public Monster(string name, int power, int effect, int damageEffect)
            : base(name, effect, CardType.Monster)
        {
            Power = power;  
            DamageEffect = damageEffect;
        }

        public int Power { get; private set; }
        public int DamageEffect { get; private set; }           
    }
}
