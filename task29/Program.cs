// курс "Знакомство с языками программирования" вебинар 4 домашнее задание

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран
// 1, 2, 5, 7, 19  -> [1, 2, 5, 7, 19]
// 6, 1, 33        -> [6, 1, 33]   


// 1. Функция заполнения массива
// 2. Функция вывода массива в консоль
// 3. Ввод данных с проверкой
// 4. Демонстрация работы функций с выводом в консоль
// 5.  Немного интерфейса))

// 1. Функция заполнения массива
int[] FillArray(int arraySize)
{
    int[] result = new int[arraySize];
    Random tmp = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = tmp.Next(1, 99);
    }
    return result;
}

// 2. Функция вывода массива в консоль
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

string exit_condition = String.Empty;
while (exit_condition != "n")
{
    // 3. Ввод данных с проверкой
    Console.WriteLine("Программа задаёт массив из 8 элементов и выводит их на экран.");
    System.Console.Write("Но можно задать любую размерность массива, введите количество элементов массива:  ");
    int.TryParse(Console.ReadLine(), out int number);

    // 4. Демонстрация работы функций с выводом в консоль
    int[] result = FillArray(number);
    PrintArray(result);
    System.Console.WriteLine();
    // 5.  Немного интерфейса))
    System.Console.Write("Хотите сделать это ещё раз? y / n  ");
    exit_condition = Console.ReadLine();
}

System.Console.WriteLine("Благодарим за использование программы!");

