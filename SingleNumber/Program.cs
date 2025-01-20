namespace SingleNumber
{
    /*
    Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    You must implement a solution with a linear runtime complexity and use only constant extra space.

    Описание задачи:
    Нам дан массив, состоящий из чисел, причем все числа, кроме одного, встречаются ровно два раза. Наша цель — найти это единственное число, которое встречается лишь однажды.

    Подход к решению:
    Мы можем решить эту задачу, используя свойства операции XOR (исключающее ИЛИ). Вспомним, что:

    a ⊕ a = 0
    a⊕0=a
    a⊕b⊕a=b
    Используя эти свойства, мы можем применить XOR ко всем элементам массива. 
    Повторяющиеся числа взаимно уничтожатся, оставив в результате единственное число, которое встретилось один раз.

    Объяснение решения:
    Инициализируем результат нулём. Начальное значение result равно нулю, потому что любое число XOR'ится с нулем само с собой: 
    a⊕0=a.
    Проходим по всему массиву. Для каждого числа в массиве мы применяем операцию XOR с текущим значением result: 
    result=result⊕num. Таким образом, повторяющиеся числа взаимно уничтожаются (a⊕a=0), а неповторяющееся число остается неизменным.
    Возвращаем результат. После завершения цикла в переменной result останется именно то число, которое встречалось один раз.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
