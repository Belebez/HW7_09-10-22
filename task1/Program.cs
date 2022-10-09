// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// m = 3, n = 4.

// 1 7 -2 -85

// 1 -3 8 -9

// 8 7 -7 9

// получаем случайным образом количество строк и столбцов

int rows = new Random().Next(3, 11);
int columns = new Random().Next(4, 11);
Console.WriteLine($"Двумерный массив размером {rows}x{columns}");
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);

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