namespace DZ04collection
{
    internal class Program
    {

        public static void FindTripleSumUsingCollections()
        {
            // Исходный массив чисел
            int[] arr = { 1, 4, 2, 5, 3, 7, 8, 10, 0 };
            // Целевое число, сумма трёх чисел должна равняться ему
            int target = 10;

            bool found = false;

            // Преобразуем массив в список 
            List<int> numbers = new List<int>(arr);

            // Перебираем элементы списка, выбирая первое число тройки
            for (int i = 0; i < numbers.Count - 2; i++)
            {
                // Для каждого выбранного первого числа вычисляем оставшуюся сумму,
                // которую должны дать два других числа
                int currentTarget = target - numbers[i];

                // Создаём HashSet для быстрого поиска дополнений
                HashSet<int> complements = new HashSet<int>();

                // Ищем пару чисел, сумма которых равна currentTarget
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    int secondNumber = numbers[j];
                    int needed = currentTarget - secondNumber;

                    // Если нужное число уже встречалось в данной итерации,
                    // значит, найдена тройка чисел, сумма которых равна target
                    if (complements.Contains(needed))
                    {
                        Console.WriteLine($"We find next three numbers: {target} = {numbers[i]} + {needed} + {secondNumber}");
                        found = true;
                        // Если требуется найти только одну комбинацию, можно завершить выполнение:
                        // return;
                    }

                    // Добавляем текущее число в HashSet для поиска дополнения в следующих итерациях
                    complements.Add(secondNumber);
                }
            }

            if (!found)
            {
                Console.WriteLine($"We didn't find any three numbers with sum {target}");
            }
        }

        static void Main(string[] args)
        {

            FindTripleSumUsingCollections();


        }
    }
}
