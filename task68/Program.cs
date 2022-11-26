/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
*/
int AkkermanFunction(int a, int b)
{
    if (a == 0) { return b + 1; }
    if (b == 0) { return AkkermanFunction(a - 1, 1); }
    return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
}

int res = AkkermanFunction(2, 3);
Console.WriteLine(res);