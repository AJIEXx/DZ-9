// Это Main работа. Версии при их наличии будут распределены в репозитории по соответствующим веткам.

int programm, num;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("2. Упрощенный вариант 1 задачи.");
    Console.WriteLine("3. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
           //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
           //0, 7, 8, -2, -2 -> 2
            //1, -7, 567, 89, 223-> 3

            Console.Write("Введите числа через запятую: ");
            int[] numbers = StringToNum(Console.ReadLine());
            PrintArray(numbers);
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    sum++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"количество значений больше 0 = {sum}");


            int[] StringToNum(string input)
            {
                int count = 1;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ',')
                    {
                        count++;
                    }
                }

                int[] numbers = new int [count];
                int index = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    string temp = "";

                    while (input [i] != ',')
                    {
                    if(i != input.Length - 1)
                    {
                        temp += input [i].ToString();
                        i++;
                    }
                    else
                    {
                        temp += input [i].ToString();
                        break;
                    }
                    }
                    numbers[index] = Convert.ToInt32(temp);
                    index++;
                }
                return numbers;
            }


            void PrintArray(int[] array)
            {
                Console.Write("[ ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.Write("]");
            }
            break;

        case 2:
            // Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию 
            // (не используем Enter). Числа разделены пробелами. 
            //Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //0 7 8 -2 -2 -> 2
            //1 -7 567 89 223-> 4


            Console.Write("Введите элементы(через пробел): ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = arr.Count(x => x > 0);
            Console.WriteLine($"Кол-во элементов > 0: {count}");
            break;

        case 3:
            // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
            // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
            // задаются пользователем.
            // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

            Console.Write("Введите k1: ");
            var k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b1: ");
            var b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k2: ");
            var k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2: ");
            var b2 = Convert.ToDouble(Console.ReadLine());
            
            
            var x = -(b1 - b2) / (k1 - k2);
            var y = k1 * x + b1;
            
            x = Math.Round(x, 3);
            y = Math.Round(y, 3);
            
            Console.WriteLine($"Пересечение в точке: ({x};{y})");
            break;

        default:
            begin = false;
            break;
    }
}
