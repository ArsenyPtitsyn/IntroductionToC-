double distanceBetweenTwoPointsIn3DSpace(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}

Console.WriteLine("Расстояние между точками A(3, 6, 8) и B(2, 1, -7) в трёхмерном пространстве равно "
+ $"{Math.Round(distanceBetweenTwoPointsIn3DSpace(3, 6, 8, 2, 1, -7), 2)}");
Console.WriteLine("Расстояние между точками A(7, -5, 0) и B(1, -1, 9) в трёхмерном пространстве равно "
+ $"{Math.Round(distanceBetweenTwoPointsIn3DSpace(7, -5, 0, 1, -1, 9), 2)}");