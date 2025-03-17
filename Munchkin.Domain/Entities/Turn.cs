namespace Munchkin.Domain.Entities
{
    public class Turn
    {
        public Turn(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }
    }
}
