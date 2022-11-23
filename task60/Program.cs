/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

// 1. Создадим одномерный целочисленный массив из неповторяющихся двузначных чисел.
int[] CreateArrayWithNoRepitingElements(int length, int minValue, int maxValue)
{
    if (length > 90)
    {
        throw new Exception();
    }
    else
    {
        var rnd = new Random();
        minValue = 10;
        maxValue = 100;
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            bool duplicate;
            int next;
            do
            {
                next = rnd.Next(minValue, maxValue);
                duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    int el = array[j];
                    if (el == next)
                    {
                        duplicate = true;
                        break;
                    }
                }
            } while (duplicate);
            array[i] = next;
        }
        return array;
    }
}

// 2. Создадим трёхмерный целочисленный массив из неповторяющихся двузначных чисел.
int[,,] Create3DArray(int dim1, int dim2, int dim3)
{
    int[] supportArray = CreateArrayWithNoRepitingElements(dim1 * dim2 * dim3, 10, 100);

    int[,,] resultArray = new int[dim1, dim2, dim3];

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                resultArray[i, j, k] = supportArray[i * dim1 + j * dim2 + k * dim3];
            }
        }
    }
    return resultArray;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

try
{
    int[,,] array = Create3DArray(3, 5, 7);
    Print3DArray(array);
}
catch
{
    Console.WriteLine("Невозможно заполнить массив различными двузначными числами так как количество элементов больше, чем количество различных двузначных чисел!");
}