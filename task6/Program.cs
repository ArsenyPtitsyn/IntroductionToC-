bool IsEven(int number)
{
    return number % 2 == 0;
}

Console.WriteLine("Число 4 " + (IsEven(4) ? "чётно" : "нечётно"));
Console.WriteLine("Число -3 " + (IsEven(-3) ? "чётно" : "нечётно"));
Console.WriteLine("Число 7 " + (IsEven(7) ? "чётно" : "нечётно"));