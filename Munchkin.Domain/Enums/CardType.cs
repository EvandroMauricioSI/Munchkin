using System.ComponentModel;

namespace Munchkin.Domain.Enums
{
    public enum CardType
    {
        [Description("Monstro")]
        Monster = 0,
        [Description("Classe")]
        Class = 1,
        [Description("Malidação")]
        Curse = 2,
        [Description("Raça")]
        Race = 3,
        [Description("Ouro")]
        Gold = 4,
        [Description("Item")]
        Item = 5,
        [Description("Nível")]
        Level = 6
    }
}
