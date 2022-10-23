int[] FillArray()
{
    Console.Write("Введите любое количество целых чисел через зяапятую: ");

    string integersString = Console.ReadLine();
    string[] integers = integersString.Split(",");

    int[] ints = new int[integers.Length];
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = Convert.ToInt32(integers[i]);
    }
    return ints;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

int[] array = FillArray();
PrintArray(array);