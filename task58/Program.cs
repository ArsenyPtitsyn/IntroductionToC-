/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
*/

// 1. Метод, создающий матрицы. Для разнообразия заполним их случайными вещественными числами.
double[,] CreateArray(int rows, int cols, double minValue, double maxValue)
{
    if (rows <= 0 || cols <= 0)
    {
        throw new IndexOutOfRangeException();
    }
    else
    {
        double[,] array = new double[rows, cols];

        var rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
            }
        }
        return array;
    }
}

// 2. Вывод в консоль матриц для наглядности.
void PrintArray(double[,] array)
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

// 3. Метод, перемножающий две матрицы и возвращающий результирующую матрицу.
double[,] CompositionOfTwoMatrices(double[,] firstMatrix, double[,] secondMatrix)
{

}