// курс "Знакомство с языками программирования" вебинар 4 домашнее задание

// Задача 25: Напишите цикл, который принимает
// на вход два числа (А и В) и возводит число
// А в натуральную степерь В.

// 1.   Функция возведения в степень
// 1.1  Проверка входных данных внутри функции
// 1.2  Основная логика
// 2.   Основное тело программы
// 2.1  Ввод данных c проверкой
// 2.2  Демонстрация работы функции, вывод в консоль
// 2.3  Немного интерфейса))


// 1. Функция возведения в степень
int RaiseNumberAToPowerB(int A, int B)
{
    // 1.1  Проверка входных данных внутри функции
    if (B < 0)
    {
        System.Console.WriteLine("Число В должно быть больше -1");
        return -1;
    }

    // 1.2  Основная логика
    if (A == 0) return 0;
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }

    return result;
}

// 2.  Основное тело программы
string exit_condition = String.Empty;
while (exit_condition != "n")
{
    System.Console.WriteLine("Программа принимает на вход два числа (A и B) "
                                + "и возводит число A в натуральную степерь B");

    // 2.1  Ввод данных c проверкой
    System.Console.Write("Введите число A: ");
    int.TryParse(Console.ReadLine(), out int A);
    int B = -1;
    while (B < 0)
    {
        System.Console.Write("Введите число B: ");
        int.TryParse(Console.ReadLine(), out B);
        if (B >= 0) break;
        System.Console.WriteLine("Число B должно быть больше -1");
    }

    // 2.3  Демонстрация работы функции, вывод в консоль
    System.Console.WriteLine($"{A} в степени {B} равно: {RaiseNumberAToPowerB(A, B)}");
    System.Console.WriteLine();
    // 2.4  Немного интерфейса))
    System.Console.Write("Хотите сделать это ещё раз? y / n  ");
    exit_condition = Console.ReadLine();
}

System.Console.WriteLine("Благодарим за использование программы!");