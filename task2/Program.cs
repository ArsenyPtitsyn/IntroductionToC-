int FindMax(int a, int b)
{
    if (a > b) return a;
    else return b;
}

Console.WriteLine("Большее из чисел 5 и 7: " + FindMax(5, 7));
Console.WriteLine("Большее из чисел 2 и 10: " + FindMax(2, 10));
Console.WriteLine("Большее из чисел -9 и -3: " + FindMax(-9, -3));