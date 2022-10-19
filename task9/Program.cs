bool IsMultiple(int number)
{
    return (number % 7 == 0 && number % 23 == 0);
}

Console.WriteLine("число 14 " + (IsMultiple(14) ? "ЯВЛЯЕТСЯ" : "НЕ ЯВЛЯЕТСЯ") + " одновременно кратным 7 и 23.");
Console.WriteLine("число 46 " + (IsMultiple(46) ? "ЯВЛЯЕТСЯ" : "НЕ ЯВЛЯЕТСЯ") + " одновременно кратным 7 и 23.");
Console.WriteLine("число 161 " + (IsMultiple(161) ? "ЯВЛЯЕТСЯ" : "НЕ ЯВЛЯЕТСЯ") + " одновременно кратным 7 и 23.");