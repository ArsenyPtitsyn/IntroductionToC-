int[] CreateAnArrayOfIntegersFromUserEnteredData()
{
    Console.Write("Введите целые числа через запятую без пробела: ");
    string stringOfIntegers = Console.ReadLine();
    string[] arrayOfStringsOfIntegers = stringOfIntegers.Split(",");

    int[] arrayOfIntegers = new int[arrayOfStringsOfIntegers.Length];
    for (int i = 0; i < arrayOfIntegers.Length; i++)
    {
        arrayOfIntegers[i] = Convert.ToInt32(arrayOfStringsOfIntegers[i]);
    }
    return arrayOfIntegers;
}

int NumberOfPositiveNumbersInArray(int[] array)
{
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

int[] array = CreateAnArrayOfIntegersFromUserEnteredData();
Console.WriteLine($"Количество положительных чисел, введённых пользователем равно: {NumberOfPositiveNumbersInArray(array)}");