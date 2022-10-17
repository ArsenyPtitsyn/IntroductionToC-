void PrintEvenNumbersLessOrEqualN(int n)
{
    int index = 2;
    while (index <= n)
    {
        Console.Write(index + "|");
        index += 2;
    }
    Console.WriteLine();
}

PrintEvenNumbersLessOrEqualN(5);
PrintEvenNumbersLessOrEqualN(8);