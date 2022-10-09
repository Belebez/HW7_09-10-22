// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2



Console.Write($"Выберите способ решения 1 - ввод от пользоваеля, 2 - с помощью генератора случайных чисел --> ");

int answer = int.Parse(Console.ReadLine()!);

if (answer == 1)
{
    // получаем индексы для поиска элемента в массиве
    Console.Write($"Введите индекс строки i - ");
    int IndexI = int.Parse(Console.ReadLine()!);
    Console.Write($"Введите индекс столбца j - ");
    int IndexJ = int.Parse(Console.ReadLine()!);

    // получаем значения для размера массива
    int rows = new Random().Next(3, 11);
    int columns = new Random().Next(4, 11);
    Console.WriteLine();
    Console.WriteLine($"Двумерный массив размером {rows}x{columns}");
    Console.WriteLine();

    int[,] array = GetArray(rows, columns);
    Console.WriteLine("Полученный массив: ");
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    SearchElem(array, IndexI, IndexJ);

    void SearchElem(int[,] array, int i, int j)  // функция поска элемента по заданным индексам
    {
        int num = 0;

        if ((i <= array.GetLength(0)) && (j <= array.GetLength(1)))
        {
            num = array[i, j];
            Console.WriteLine($"Элемент который находиться по индексам [{IndexI}, {IndexJ}] равен - ({num})");
        }
        else
        {
            Console.WriteLine($"Элемента по индексам ({IndexI}, {IndexJ}) - нет");
        }
    }

    int[,] GetArray(int row, int column)  // функция заполнения массива
    {
        int[,] result = new int[row, columns];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = new Random().Next(-100, 101);
            }
        }
        return result;
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

else if (answer == 2)
{
    // получаем случайные значения для размера массива
    int rows = new Random().Next(3, 11);
    int columns = new Random().Next(4, 11);
    Console.WriteLine();
    Console.WriteLine($"Двумерный массив размером {rows}x{columns}");
    Console.WriteLine();


    // получаем индексы для поиска элемента в массиве
    int IndexI = new Random().Next(3, 18);
    int IndexJ = new Random().Next(4, 19);

    int[,] array = GetArray(rows, columns);
    Console.WriteLine("Полученный массив: ");
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    SearchElem(array, IndexI, IndexJ);

    void SearchElem(int[,] array, int i, int j)  // функция поска элемента по заданным индексам
    {
        int num = 0;

        if ((i <= array.GetLength(0)) && (j <= array.GetLength(1)))
        {
            num = array[i, j];
            Console.WriteLine($"Элемент который находиться по индексам [{IndexI}, {IndexJ}] равен - ({num})");
        }
        else
        {
            Console.WriteLine($"Элемента по индексам ({IndexI}, {IndexJ}) - нет");
        }
    }

    int[,] GetArray(int row, int column)  // функция заполнения массива
    {
        int[,] result = new int[row, columns];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = new Random().Next(-100, 101);
            }
        }
        return result;
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

else
{
    Console.WriteLine("Вы ввели отличную от 1 и 2 цифру");
}