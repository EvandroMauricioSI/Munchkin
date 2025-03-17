using System.ComponentModel;

namespace Munchkin.Domain.Utils
{
    public static class EnumExtensions
    {
        public static string ToDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
