﻿/*
1. Задайте значения M и N. 
2. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

// void IntervalOfNumbers(int num1, int num2)
// {
//     if (num1 == num2) Console.Write($"{num2} ");
//     if (num1 > num2)
//     {
//         IntervalOfNumbers(num1, num2 + 1);
//         Console.Write($"{num2} ");
//     }
//     if (num1 < num2)
//     {
//         Console.Write($"{num1} ");
//         IntervalOfNumbers(num1 + 1, num2);
//     }
// }

// Console.Write("Введите M: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите N: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// IntervalOfNumbers(firstNumber, secondNumber);

Console.WriteLine("Введите два числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

GapNaturalNumbers(number1, number2);

void GapNaturalNumbers(int num1, int num2)
{
    Console.Write($"{num1} ");
    if (num1 == num2) return;
    if (num1 > num2) GapNaturalNumbers(num1 - 1, num2);    
    else GapNaturalNumbers(num1 + 1, num2);
}