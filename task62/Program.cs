int[,] CreateSpirallyArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];

    int row = 0, col = 0; // Индексы элемента, с которого мы начинаем заполнение.
    int dx = 1, dy = 0; // Направление, в котором мы начинаем заполнение массива.
    int directionChanges = 0; // Количество поворотов, случившихся при заполнении массива.
    int NumberOfElBeforeRotation = cols; // Количество элементов до поворота.

    for (int i = 0; i < array.Length; i++)
    {
        array[row, col] = i + 1;
        if (--NumberOfElBeforeRotation == 0)
        {
            NumberOfElBeforeRotation = cols * (directionChanges % 2)
            + rows * ((directionChanges + 1) % 2) - (directionChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            directionChanges++;
        }
        col += dx;
        row += dy;
    }
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateSpirallyArray(7, 9);
PrintArray(array);