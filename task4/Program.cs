int FindMax(int n1, int n2, int n3)
{
    if (n1 > n2)
    {
        if (n1 > n3) return n1;
        else return n3;
    }
    else
    {
        if (n2 > n3) return n2;
        else return n3;
    }
}

Console.WriteLine("Максимальное из чисел 2, 3, 7: " + FindMax(2, 3, 7));
Console.WriteLine("Максимальное из чисел 44, 5, 78: " + FindMax(44, 5, 78));
Console.WriteLine("Максимальное из чисел 22, 3, 9: " + FindMax(22, 3, 9));