using Munchkin.Domain.Entities.Cards;
using Munchkin.Domain.Shared.Abstractions;
using System;

namespace Munchkin.Domain.Factory
{
    public class RandomCardFactory
    {
        private readonly CardFactory _cardFactory;
        
        public RandomCardFactory()
        {
            _cardFactory = new CardFactory();
        }

        public Monster CreateMonsterCard()
        {
            var random = new Random();

            var monsters = _cardFactory.CreateMonsterCards();

            return monsters[random.Next(monsters.Count)];
        }

        public Class CreateClassCard()
        {
            var random = new Random();

            var classes =  _cardFactory.CreateClassCards();

            return classes[random.Next(classes.Count)];
        }

        public Curse CreateCurseCard()
        {
            var random = new Random();

            var curses = _cardFactory.CreateCurseCards();

            return curses[random.Next(curses.Count)];
        }

        public Race CreateRaceCard()
        {
            var random = new Random();

            var curses =  _cardFactory.CreateRaceCards();

            return curses[random.Next(curses.Count)];
        }

        public Gold CreateGoldCard()
        {
            var random = new Random();

            var goldes = _cardFactory.CreateGoldCards();

            return goldes[random.Next(goldes.Count)];
        }

        public Item CreateItemCard()
        {
            var random = new Random();

            var items = _cardFactory.CreateItemCards();

            return items[random.Next(items.Count)];
        }

        public Level CreateLevelCard()
        {
            var random = new Random();

            var items = _cardFactory.CreateLevelCards();

            return items[random.Next(items.Count)];
        }
    }
}
