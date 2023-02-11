/*
Напишите программу, которая: 
1. на вход принимает число (N)
2. а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 != 0)
        {
            continue;
        }
        Console.Write($"{i} ");
    }
}
else
{
    Console.WriteLine("Введено не натуральное число!");
}