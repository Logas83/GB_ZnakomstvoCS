/*
Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

int prodactNumbersAB = Exponentiation(number, degree);
Console.WriteLine($"число {number} в целую степень {degree} равно {prodactNumbersAB}");


int PowerRec (int numberA, int numberB)
{
    return numberB == 0 ? 1 : PowerRec (numberA, numberB - 1) * numberA;    
}

int Exponentiation(int num, int deg)
{
    if (deg == 0) return 1;
    if (deg % 2 == 0) return Exponentiation (num * num, deg / 2);
    return PowerRec (num, deg - 1) * num;
}