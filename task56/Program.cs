/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
*/

// 1. Создадим двумерный целочисленный массив.
int[,] CreateArray(int length, int minValue, int maxValue)
{
    if (length <= 0)
    {
        throw new IndexOutOfRangeException();
    }
    else
    {
        int[,] array = new int[length, length];

        var rnd = new Random();

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
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

// 3. Сделаем из двумерного массива одномерный, элементами которого будут суммы 
// элементов строк двумерного массива.
int[] GetArrayOfSumElementsOfRows(int[,] array)
{
    int[] sumElementsOfRows = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElementsOfRows[i] += array[i, j];
        }
    }

    return sumElementsOfRows;
}

// 4. Нахождение индекса минимального элемента одномерного массива.
int FindIndexOfMinElement(int[] array)
{
    int indexOfMinElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[indexOfMinElement])
        {
            indexOfMinElement = i;
        }
    }
    return indexOfMinElement;
}

int[,] array = CreateArray(5, -4, 8);
PrintArray(array);
int[] RowsOf2DArray = GetArrayOfSumElementsOfRows(array);
int rowWithMinSumOfElements = FindIndexOfMinElement(RowsOf2DArray) + 1; // Нумерация начинается с 0, а не с 1.
Console.WriteLine($"Строка с минимальной суммой элементов для данного массива: {rowWithMinSumOfElements}");