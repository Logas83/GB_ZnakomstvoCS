﻿/*

*/

Console.WriteLine("введите координаты первой точки ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distanceRound}");


double Distance(int xc1, int yc1, int xc2, int yc2)
{
    return Math.Sqrt(Math.Pow((xc2 - xc1), 2) + Math.Pow((yc2 - yc1), 2));
}