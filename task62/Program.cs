int[,] Fill4x4ArraySpirally()
{
    int[,] array = {{1, 2, 3, 4},
                    {12, 13, 14, 5},
                    {11, 16, 15, 6},
                    {10, 9, 8, 7}};
    return array;
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

int[,] array = Fill4x4ArraySpirally();
PrintArray(array);