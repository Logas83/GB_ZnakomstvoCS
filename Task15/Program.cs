/*
Напишите программу, которая: 
1. принимает на вход цифру, обозначающую день недели, 
2. и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool Weekend(int number)
{
    return number > 5;
}

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    Console.WriteLine(Weekend(number) ? "да" : "нет");
}
else
{
    Console.WriteLine("Вы ввели неправильное число!");
}