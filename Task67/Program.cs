/*
Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.

453 -> 12
45 -> 9
*/

int SummNumbers(int num)
{
    if (num < 10) return num;
    else return num % 10 + SummNumbers(num / 10);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SummNumbers(number);
Console.WriteLine($"{number} -> {result}");
