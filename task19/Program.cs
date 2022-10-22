bool IsPalindrome(int number)
{
    if (number > 9999 && number < 100000)
    {
        return (number % 10 == number / 10000
        && number / 10 % 10 == number / 1000 % 10);
    }
    else
    {
        throw new System.Exception("Вы ввели не пятизначное число");
    }
}

try
{
    Console.WriteLine("14212 -> " + (IsPalindrome(14212) ? "Да" : "Нет"));
    Console.WriteLine("12821 -> " + (IsPalindrome(12821) ? "Да" : "Нет"));
    Console.WriteLine("23432 -> " + (IsPalindrome(23432) ? "Да" : "Нет"));
}
catch
{
    Console.WriteLine("Вы ввели не пятизначное число");
}