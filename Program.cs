// Это Main работа. Версии при их наличии будут распределены в репозитории по соответствующим веткам.

int programm, num;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("2. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("3. Найдите разницу между максимальным и минимальным элементов массива.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2

            Console.WriteLine("Введите длину массива:  ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            RandonNumbers(numbers);
            Console.WriteLine("В этом массиве: ");
            PrintArray(numbers);

            void RandonNumbers(int[] numbers)
            {
                for(int i = 0; i < size; i++)
                {
                    numbers[i] = new Random().Next(100,1000);
                }
            }


            int count = 0;

            for (int x = 0; x < numbers.Length; x++)
            {
            if (numbers[x] % 2 == 0)
            count++;
            }
            Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


            void PrintArray(int[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
            break;

        case 2:
            //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
            //[3, 7, 23, 12] => 19
            //[-4, -6, 89, 6] => 0
            Console.WriteLine("Введите размер массива  ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine("массив: ");
            PrintArray(numbers);
            int sum = 0;

            for (int z = 0; z < numbers.Length; z+=2)
                sum = sum + numbers[z];

                Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

            void FillArrayRandomNumbers(int[] numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = new Random().Next(1,10);
                    }
            }
            void PrintArray(int[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                Console.Write("]");
                Console.WriteLine();
            }
            break;

        case 3:
            // Задача 38: Задайте с клавиатуры массив ыещественных (double) чисел.
            // Найдите разницу между максимальным и минимальным элементов массива.
            // Задать размер (int) массива с клавиатуры
            // [3.7; 7.2; 2.1; 7.8] -> 5.7

            Console.WriteLine("Введите размер массива  ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[size];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine("массив: ");
            PrintArray(numbers);
            double min = Int32.MaxValue;
            double max = Int32.MinValue;

            for (int z = 0; z < numbers.Length; z++)
            {
                if (numbers[z] > max)
                    {
                        max = numbers[z];
                    }
                if (numbers[z] < min)
                    {
                        min = numbers[z];
                    }
            }

            Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
            Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

            void FillArrayRandomNumbers(double[] numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
                    }
            }
            void PrintArray(double[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                Console.Write("]");
                Console.WriteLine();
            }
            break;

        default:
            begin = false;
            break;
    }
}
