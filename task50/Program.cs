/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
*/
// 1. Предположим, что это массив целых чисел, находящихся в пределах от minValue до maxValue.

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

// 2. Для удобства восприятия, выведем этот массив на экран.
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

// 3. Напишем метод, выводящий на экран элемент массива с заданными индексами.
void PrintElementWithSpecifiedIndexes(int[,] array, int i, int j)
{
    if (i >= 0 && i < array.GetLength(0) && j >= 0 && j < array.GetLength(1))
    {
        Console.WriteLine($"Элемент с индексами {i} и {j} равен: {array[i, j]}");
    }
    else
    {
        Console.WriteLine($"В данном массиве не существует элемента с индексами {i} и {j}");
    }
}

try
{
    int[,] array = CreateTwoDimensionalArray(7, 10, -4, 18);
    PrintArray(array);
    PrintElementWithSpecifiedIndexes(array, 1, 8);
}
catch
{
    Console.WriteLine("Количество строк и количество столбцов в массиве должно быть положительным!");
}