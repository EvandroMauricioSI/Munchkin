namespace Munchkin.Domain.Utils
{
    public static class RandomNumberGenerator
    {
        public static int GenerateNumberFrom1To100()
        {
            Random random = new Random();

            return random.Next(1, 101);
        }

        public static int GenerateNumberFrom1To10()
        {
            Random random = new Random();

            return random.Next(1, 11);
        }

        public static int GenerateRandomNumberFromMinus1To3ExcludingZero()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(-3, 4);
            } while (randomNumber == 0);

            return randomNumber;
        }
    }
}
