int NaturalPowerOfNaturalNumber(int basis, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result *= basis;
    }
    return result;
}

Console.WriteLine("3 в 5 степени -> " + NaturalPowerOfNaturalNumber(3, 5));
Console.WriteLine("2 в 4 степени -> " + NaturalPowerOfNaturalNumber(2, 4));