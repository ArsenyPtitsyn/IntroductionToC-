﻿void CubesOfNumbersFrom1ToN(int number)
{
    Console.Write(number + " -> ");

    int index = 1;
    while (index < number)
    {
        Console.Write(Math.Pow(index, 3) + ", ");
        index++;
    }
    Console.Write(Math.Pow(index, 3));
    Console.WriteLine();
}

CubesOfNumbersFrom1ToN(3);
CubesOfNumbersFrom1ToN(5);
CubesOfNumbersFrom1ToN(1);