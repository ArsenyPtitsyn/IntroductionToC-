/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
*/

// 1. Метод, создающий матрицы. Для разнообразия заполним их случайными вещественными числами.
double[,] CreateMatrix(int rows, int cols, double minValue, double maxValue)
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
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// 3. Метод, перемножающий две матрицы и возвращающий результирующую матрицу.
double[,] CompositionOfTwoMatrices(double[,] firstMatrix, double[,] secondMatrix)
{
    int rowsOfFirstMatrix = firstMatrix.GetLength(0);
    int colsOfFirstMatrix = firstMatrix.GetLength(1);
    int rowsOfSecondMatrix = secondMatrix.GetLength(0);
    int colsOfSecondMatrix = secondMatrix.GetLength(1);

    if (colsOfFirstMatrix != rowsOfSecondMatrix)
    {
        throw new Exception();
    }
    else
    {
        double[,] productMatrix = new double[rowsOfFirstMatrix, colsOfSecondMatrix];

        for (int i = 0; i < rowsOfFirstMatrix; i++)
        {
            for (int j = 0; j < colsOfSecondMatrix; j++)
            {
                for (int k = 0; k < colsOfFirstMatrix; k++)
                {
                    productMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
        return productMatrix;
    }
}

try
{
    double[,] firstMatrix = CreateMatrix(3, 1, -2, 5);
    PrintMatrix(firstMatrix);
    double[,] secondMatrix = CreateMatrix(1, 5, -2, 5);
    PrintMatrix(secondMatrix);
    double[,] productMatrix = CompositionOfTwoMatrices(firstMatrix, secondMatrix);
    PrintMatrix(productMatrix);
}
catch
{
    Console.WriteLine("Неверный ввод данных!");
}