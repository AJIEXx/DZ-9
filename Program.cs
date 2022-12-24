// Это Main работа. Версии при их наличии будут распределены в репозитории по соответствующим веткам.

int programm, num;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("2. Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("3. Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    Console.WriteLine("4. Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("5. Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("6. Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            /*
            Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            456 -> 5
            782 -> 8
            918 -> 1
            */

            int number = ReadInt("Введите трехзначное число: ");
            int amount = number.ToString().Length;

            if (amount < 3 || amount > 3)
            {
                Console.WriteLine("Вы ввели не трехзначное число");
            }
            else
            {
                Console.WriteLine(InCenter(number));
            }



            // ФУНКЦИИ------------------------------------------------------------------------------------------------------

            // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }

            // Функция вывода цифры стоящей в середине трехзначногно числа.
            int InCenter(int a)
            {
                
                int result = ((a / 10) % 10);
                return result;
            }
            break;

        case 2:
            /*
            Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            645 -> 5
            // 78 -> третьей цифры нет
            // 32679 -> 6
            */

            int number = ReadInt("Введите число: ");
            int count = number.ToString().Length;
            Console.Write(MakeArray(number, count));


            // ФУНКЦИИ------------------------------------------------------------------------------------------------------

            // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }

            // Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
            int MakeArray(int a, int b)
            {
            int result = 0;
                if (b < 3)
                {
                    Console.Write("Третьей цифры нет, держи: ");
                }
                else
                {
                    int c = 1;
                    for (int i = b; i > 3; i--)
                    {
                        c = c * 10;
                    }

                    result = (a / c) % 10;
                }
            return result;
            }
            break;

        case 3:
            /*
            Задача 15: 
            Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            6 -> да
            7 -> да
            1 -> нет
            */

            int dayNumber = ReadInt("Введите число от 1 до 7: ");
            Console.WriteLine(WorkHoliday(dayNumber));


            // ФУНКЦИИ------------------------------------------------------------------------------------------------------

            // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }

            // Функция принимает число от 1 до 7 и выводит сообщение - выходной день или нет.
            // *** Костыль, но я тренировал функции. проблема с return была. ***
            string WorkHoliday(int a)
            {
                if (a > 0 && a < 8)
                {
                    if (a == 7 || a == 6)
                    {
                        Console.Write("Под цифрой " + a + " - Выходной");
                    }
                    else
                    {
                        Console.Write("Под цифрой " + a + " - Рабочий");
                    }
                }
                else
                {
                    Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
                }
                return " день.";
            }
            break;

        case 4:
            /*
            Задача 19
            Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            14212 -> нет
            12821 -> да
            23432 -> да
            */

            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            int len = number.Length;

            if (len == 5)
            {
                if (number[0] == number[4] && number[1] == number[3])
                {
                    Console.WriteLine($"{number} - Палиндром");
                }
                else
                {
                    Console.WriteLine($"{number} - НЕ палиндром");
                }
            }
            else
            {
                Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
            }
            break;

        case 5:
            /*
            Задача 21 (branch task_2)
            Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            A (3,6,8); B (2,1,-7), -> 15.84
            A (7,-5, 0); B (1,-1,9) -> 11.53
            */

            int x1 = ReadInt("Введите координату X первой точки: ");
            int y1 = ReadInt("Введите координату Y первой точки: ");
            int z1 = ReadInt("Введите координату Z первой точки: ");
            int x2 = ReadInt("Введите координату X второй точки: ");
            int y2 = ReadInt("Введите координату Y второй точки: ");
            int z2 = ReadInt("Введите координату Z второй точки: ");

            int A = x2 - x1;
            int B = y2 - y1;
            int C = z1 - z2;

            double length = Math.Sqrt(A * A + B * B + C * C);
            Console.WriteLine($"Длинна отрезка {length}");


            // Функция ввода сообщения
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            break;

        case 6:
            /*
            Задача 23
            Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125
            */

            int number = ReadInt("Введите число N: ");

            for (int i = 1; i <= number; i++)
            { 
                Console.Write($"{i*i*i} ");
            }



            // Функция ввода сообщения
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            break;

        default:
            begin = false;
            break;
    }
}
