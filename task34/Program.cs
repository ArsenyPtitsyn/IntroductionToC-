void FillArray(int[] array)
{
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

int CountOfEvenNumbersInArray(int[] array)
{
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
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

int[] array = new int[15];
FillArray(array);
PrintArray(array);
Console.WriteLine($"The number of even numbers in the array is: {CountOfEvenNumbersInArray(array)}");