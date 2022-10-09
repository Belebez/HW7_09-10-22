// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = new Random().Next(3, 8);
int columns = new Random().Next(4, 9);
Console.WriteLine($"Двумерный массив размером {rows}x{columns}");
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
AverageColumns(array);

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

void AverageColumns(int[,] array)  // метод вывода средней каждого столбца
{
    double sum = 0;
    double average = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        average = Math.Round((sum / array.GetLength(0)), 2);
        Console.Write($"{average}; ");
        sum = 0;
    }
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