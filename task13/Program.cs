void ThirdDigitOfNumber(int number)
{
    if (number < 100) Console.WriteLine("У числа нет третьей цифры");
    else
    {
        while (number > 1000)
        {
            number /= 10;
        }
        Console.WriteLine("Третья цифра числа равна " + number % 10);
    }
}

ThirdDigitOfNumber(645);
ThirdDigitOfNumber(78);
ThirdDigitOfNumber(32679);