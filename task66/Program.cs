/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
*/
int FindSumOfIntegersBetween(int lowerLimit, int upperLimit)
{
    if (lowerLimit > upperLimit) { return 0; }
    return lowerLimit + FindSumOfIntegersBetween(lowerLimit + 1, upperLimit);
}

int sum = FindSumOfIntegersBetween(-15, 5);
Console.WriteLine(sum);
