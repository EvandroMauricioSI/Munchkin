using Munchkin.Domain.Entities.Cards;

namespace Munchkin.Domain.Factory
{
    public class CardFactory
    {
        public List<Monster> CreateMonsterCards()
        {
            return new List<Monster>
            {
                new Monster("Drakon", 20, 1, -2),
                new Monster("Gorgon", 15, 2, -3),
                new Monster("Cyclops", 25, 1, -3),
                new Monster("Behemoth", 29,2, -1),
                new Monster("Hydra", 50, 3, -2),
                new Monster("Griffin", 42, 1, -1),
                new Monster("Chimera", 35, 3, -3),
                new Monster("Manticore", 30, 2, -2)
            };
        }

        public List<Class> CreateClassCards()
        {
            return new List<Class>
            {
                new Class("Guerreiro", 1),
                new Class("Mago", 2),
                new Class("Ladrão", 3),
                new Class("Arqueiro", 2),
                new Class("Clérigo", 1),
                new Class("Bárbaro", 3),
                new Class("Assassino", 2),
                new Class("Necromante", 1)
            };
        }

        public List<Curse> CreateCurseCards()
        {
            return new List<Curse>
            {
                new Curse("Vento Sombrio", 1, -1),
                new Curse("Imortalidade", 2, -2),
                new Curse("Sombra", 3, -3),
                new Curse("Lua Sangrenta", 1, -2),
                new Curse("Lamento Eterno", 2, -1),
                new Curse("Olho Furtivo", 3, -1)
            };
        }

        public List<Race> CreateRaceCards()
        {
            return new List<Race>
            {
                new Race("Aetherian", 1),
                new Race("Drakonide", 2),
                new Race("Sylvaran", 3),
                new Race("Umbrovian", 1),
                new Race("Aquarion", 2),
                new Race("Pyrrhal", 3),
                new Race("Zykran", 1)
            };
        }

        public List<Gold> CreateGoldCards()
        {
            return new List<Gold>()
            {
                new Gold("Ouro Puro", 1),
                new Gold("Ouro Bruto", 2),
                new Gold("Ouro Enriquecido", 3),
                new Gold("Ouro Fino", 1),
                new Gold("Ouro Branco", 2),
                new Gold("Ouro Rosé", 3),
                new Gold("Ouro Mágico", 1)
            };
        }

        public List<Item> CreateItemCards()
        {
            return new List<Item>()
            {
                new Item("Espada Lendária", 1),
                new Item("Escudo Mágico", 2),
                new Item("Poção de Vida", 3),
                new Item("Armadura de Ferro", 1),
                new Item("Anel do Poder", 2),
                new Item("Cajado Arcano", 3),
                new Item("Cristal de Mana", 1)
            };
        }

        public List<Level> CreateLevelCards()
        {
            return new List<Level>()
            {
                  new Level("Iniciante", 1),
                  new Level("Intermediário", 2),
                  new Level("Avançado", 3),
                  new Level("Mestre", 1),
                  new Level("Lendário", 2),
                  new Level("Imortal", 3)
            };
        }
    }
}
