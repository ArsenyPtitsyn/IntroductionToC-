void GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} пересекаются в точке: ({(b2 - b1) / (k1 - k2)}, {k1 * (b2 - b1) / (k1 - k2) + b1})");
    }
    else if (b1 == b2)
    {
        Console.WriteLine("Прямые совпадают!");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются");
    }
}

Console.Write("Введите вещественное число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите вещественное число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите вещественное число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите вещественное число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

GetIntersectionPoint(b1, k1, b2, k2);