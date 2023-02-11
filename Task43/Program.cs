/*
Напишите программу, которая:
1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
2. значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double IntersectionPointX(double b1, double k1, double b2, double k2)
{
    return (b2-b1)/(k1-k2);
}

void IntersectionPointY(double x, double b1, double k1, double b2, double k2)
{
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;

    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({y1}; {y2})");
}

System.Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = IntersectionPointX(b1, k1, b2, k2);
IntersectionPointY(x, b1, k1, b2, k2);