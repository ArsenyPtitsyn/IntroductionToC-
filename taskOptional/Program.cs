int FindIndexOfArrayElementWithDesiredValue(int[] array, int value)
{
    int index = -1;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            index = i;
            break;
        }
    }
    return index;
}

void FillArray(int[] array)
{
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-999, 1000); // целые числа [-999; 1000).
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.WriteLine(array[array.Length - 1] + "]");
}

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
int[] array1 = { 25, 303, -24562, 2645, 5834561, 4, 274352, 4, 4 };
PrintArray(array1);
Console.WriteLine($"Find the index of an array element with the desired value is:{FindIndexOfArrayElementWithDesiredValue(array1, 4)}");