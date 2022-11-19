double[,] CreateTwoDimensionalArray(int rows, int cols, double maxValue, double minValue)
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

double[,] array = CreateTwoDimensionalArray(5, 3, -10, 10);
PrintArray(array);