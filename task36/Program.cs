void FillArray(int[] array)
{
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-999, 1000);
    }
}

int sumOfArrayElementsWithOddIndexes(int[] array)
{
    int result = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
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

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Sum of array elements with odd indexes is: {sumOfArrayElementsWithOddIndexes(array)}");