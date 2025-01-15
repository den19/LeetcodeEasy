namespace GuessNumberHigherOrLower
{
    /*
     We are playing the Guess Game. The game is as follows:

    I pick a number from 1 to n. You have to guess which number I picked.

    Every time you guess wrong, I will tell you whether the number I picked is higher or lower than your guess.

    You call a pre-defined API int guess(int num), which returns three possible results:

    -1: Your guess is higher than the number I picked (i.e. num > pick).
    1: Your guess is lower than the number I picked (i.e. num < pick).
    0: your guess is equal to the number I picked (i.e. num == pick).

    Return the number that I picked.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int GeussNumber(int n)
        {
            // Инициализация границ поиска
            int left = 1;
            int right = n;

            while (left < right)
            {
                // Находим середину текущего диапазона
                // Деление с округлением вниз
                int mid = left - (right - left) / 2;

                // Предполложение
                int result = Guess(mid);

                if (result == 0)
                    return mid;
                else if (result < 0)
                    // Загаданное число больше, смещаемся вправо
                    left = mid + 1;
                else
                    // Загаданное число меньше, смещаемся влево
                    right = mid - 1;
            }

            // Не должно быть такого случая, но для полноты кода
            // возвращаем одну из границ
            return left;
        }

        // API
        public static int Guess(int guess)
        {
            return 0;
        }
    }
}
