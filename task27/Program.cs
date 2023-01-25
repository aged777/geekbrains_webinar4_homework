// курс "Знакомство с языками программирования" вебинар 4 домашнее задание

// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452  -> 11
// 82   -> 10
// 9012 -> 12 


// 1. Логика функции
// 2. Ввод данных с проверкой
// 3. Демонстрация работы функции с выводом в консоль
// 4.  Немного интерфейса))

// 1. Логика функции
int SumOfInputNumberDigits(int number)
{
    int result = 0;
    if (number == 0) return 1;
    number = Math.Abs(number);
    while (number != 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

string exit_condition = String.Empty;
while (exit_condition != "n")
{
    // 2. Ввод данных с проверкой
    Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");
    System.Console.Write("Введите число: ");
    int.TryParse(Console.ReadLine(), out int number);

    // 3. Демонстрация работы функции с выводом в консоль
    int result = SumOfInputNumberDigits(number);
    System.Console.WriteLine($"Сумма цифр числа {number} равна: {result}");
    System.Console.WriteLine();
    // 4.  Немного интерфейса))
    System.Console.Write("Хотите сделать это ещё раз? y / n  ");
    exit_condition = Console.ReadLine();
}

System.Console.WriteLine("Благодарим за использование программы!");

