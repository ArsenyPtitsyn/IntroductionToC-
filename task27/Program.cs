int CountOfTheDigitsOfTheNumber(int num)
{
    int countOfDigits = 0;

    while (num != 0)
    {
        countOfDigits++;
        num /= 10;
    }
    return countOfDigits;
}

int SumOfTheDigitsOfTheNumber(int number)
{
    int result = 0;
    int countOfDigits = CountOfTheDigitsOfTheNumber(number);
    for (int i = 0; i < countOfDigits; i++)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

Console.WriteLine("Сумма цифр числа 452 -> " + SumOfTheDigitsOfTheNumber(452));
Console.WriteLine("Сумма цифр числа 82 -> " + SumOfTheDigitsOfTheNumber(82));
Console.WriteLine("Сумма цифр числа 9012 -> " + SumOfTheDigitsOfTheNumber(9012));