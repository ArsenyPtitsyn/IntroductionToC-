int SecondDigitOfThreeDigitNumber(int number)
{
    return number / 10 % 10;
}

Console.WriteLine("Введите трёхзначное целое число: ");
string numberString = Console.ReadLine();
int n = Convert.ToInt32(numberString);

Console.WriteLine(SecondDigitOfThreeDigitNumber(n));