/*
Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
*/

// 1. Пусть наш массив будет целочисленным.
int[,] CreateArray(int rows, int cols, int minValue, int maxValue)
{
    if (rows <= 0 || cols <= 0)
    {
        throw new IndexOutOfRangeException();
    }
    else
    {
        int[,] array = new int[rows, cols];

        var rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rnd.Next(minValue, maxValue + 1);
            }
        }
        return array;
    }
}

// 2. Распечатаем массив в консоли для наглядности.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// 3. Сделаем метод, сортирующий строки двумерного массива по убыванию.
void SortRowsOf2DArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            int max = j;
            for (int k = j + 1; k < cols; k++)
            {
                if (array[i, k] > array[i, max])
                {
                    max = k;
                }
            }
            int temp = array[i, max];
            array[i, max] = array[i, j];
            array[i, j] = temp;
        }
    }
}

int[,] array = CreateArray(3, 3, -10, 10);
PrintArray(array);
Console.WriteLine();
SortRowsOf2DArray(array);
PrintArray(array);