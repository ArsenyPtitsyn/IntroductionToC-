/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.
*/
void PrintNumbersdescending(int n)
{
    if (n == 0) { return; }

    Console.Write($"{n} \t");
    PrintNumbersdescending(n - 1);
}
PrintNumbersdescending(10);