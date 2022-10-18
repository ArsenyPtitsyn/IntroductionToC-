int CountOfDigits(int number)
{
    int counter = 0;
    while (number - number % Math.Pow(10, counter) != 0)
    {
        counter++;
    }
    return counter;
}

void ThirdDigitOfNumber(int number)
{
    if (CountOfDigits(number) < 3)
    {
        Console.WriteLine("У этого числа нет третьей цифры");
    }
    else
    {
        int countOfDigits = CountOfDigits(number);
        Console.WriteLine("Третья цифра числа: " + number / (int)Math.Pow(10, countOfDigits - 3) % 10);
    }
}

ThirdDigitOfNumber(645);
ThirdDigitOfNumber(78);
ThirdDigitOfNumber(32679);