void FillArray(double[] array)
{
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 2000 - 1000; // вещественные числа [-1000; 1000).
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.WriteLine(array[array.Length - 1] + "]");
}

double FindMinimum(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double FindMaximum(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double DifferenceBetweenMaxAndMinElementsOfArray(double[] array)
{
    return FindMaximum(array) - FindMinimum(array);
}

double[] array = new double[10];
FillArray(array);
PrintArray(array);
Console.WriteLine($"The difference between the maximum and minimum elements of the array is: {DifferenceBetweenMaxAndMinElementsOfArray(array)}");