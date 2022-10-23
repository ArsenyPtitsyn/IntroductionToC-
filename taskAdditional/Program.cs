bool IsPrimeNumber(int n)
{
    int index = 2;
    while (index <= Math.Sqrt(n))
    {
        if (n % index != 0)
        {
            index++;
        }
        else
        {
            return false;
        }
    }
    return true;
}

void PrimeNumbersFrom1ToN(int number)
{
    Console.Write(number + " -> ");

    int index = 2;
    while (index <= number)
    {
        if (IsPrimeNumber(index))
        {
            Console.Write(index + " ");
        }
        index++;
    }
}

PrimeNumbersFrom1ToN(11);