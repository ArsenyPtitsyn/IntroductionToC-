/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/

int[,] CreateTwoDimensionalArray(int rows, int cols, int minValue, int maxValue)
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

void PrintAveragesOfArrayColumns(int[,] array)
{
    Console.Write("Среднее арифметическое элементов в каждом столбце, равны соответственно: ");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average /= array.GetLength(0);
        Console.Write(average + "\t");
    }
}

int[,] array = CreateTwoDimensionalArray(5, 7, -7, 7);
PrintArray(array);
PrintAveragesOfArrayColumns(array);