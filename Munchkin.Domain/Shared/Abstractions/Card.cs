using Munchkin.Domain.Enums;

namespace Munchkin.Domain.Shared.Abstractions
{
    public abstract class Card
    {
        public string Name { get; private set; }
        public int Effect { get; private set; }
        public CardType Type { get; private set; }  

        protected Card(string name, int effect, CardType type) 
        {
            Name = name;
            Effect = effect;
            Type = type;
        }
    }
}
