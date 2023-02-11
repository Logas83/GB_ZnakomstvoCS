﻿/*
Напишите программу, которая: 
1. на вход принимает число 
2. и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} является чётным");
}
else
{
    Console.WriteLine($"Число {number} является нечётным");
}