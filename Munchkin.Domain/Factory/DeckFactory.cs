using Munchkin.Domain.Entities.Cards;
using Munchkin.Domain.Entities.Decks;
using Munchkin.Domain.Shared.Abstractions;

namespace Munchkin.Domain.Factory
{
    public class DeckFactory
    {
        private CardFactory _cardFactory;
        private RandomCardFactory _randomCardFactory;       

        public DeckFactory()
        {
            _cardFactory = new CardFactory();
            _randomCardFactory = new RandomCardFactory();
        }

        public Door CreateDoorDeck()
        {
            var cards = new List<Card>();
            for (int i = 0; i < 30; i++)
            {
                var monsterInfos = _randomCardFactory.CreateMonsterCard();
                cards.Add(new Monster(monsterInfos.Name, monsterInfos.Power,  monsterInfos.Effect, monsterInfos.DamageEffect));
            }

            for (int i = 0; i < 30; i++)
            {
                var classInfos = _randomCardFactory.CreateClassCard();
               cards.Add(new Class(classInfos.Name, classInfos.Effect));
            }

            for (int i = 0; i < 30; i++)
            {
                var ranceInfos = _randomCardFactory.CreateRaceCard();
               cards.Add(new Race(ranceInfos.Name, ranceInfos.Effect));
            }

            for (int i = 0; i < 30; i++)
            {
                var curseInfos = _randomCardFactory.CreateCurseCard();
               cards.Add(new Curse(curseInfos.Name, curseInfos.Effect, curseInfos.DamageEffect));
            }

            return new Door(cards);
        }

        public Treasure CreateTreasureDeck()
        {
            var cards = new List<Card>();
            for (int i = 0; i < 30; i++)
            {
                var itemInfos = _randomCardFactory.CreateItemCard();
                cards.Add(new Item(itemInfos.Name, itemInfos.Effect));
            }

            for (int i = 0; i < 30; i++)
            {
                var goldInfos = _randomCardFactory.CreateGoldCard();
                cards.Add(new Gold(goldInfos.Name, goldInfos.Effect));
            }

            for (int i = 0; i < 30; i++)
            {
                var levelInfos = _randomCardFactory.CreateLevelCard();
                cards.Add(new Level(levelInfos.Name, effect: levelInfos.Effect));
            }

            return new Treasure(cards);
        }
    }
}
