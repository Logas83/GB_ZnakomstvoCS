/*
Напишите программу, которая:
1. по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 5)
{
    Console.WriteLine($"Указанная четверть соответствует {Quarter(number)} диапазону");
}
else
{
    Console.WriteLine("Введена некорректная четверть!");
}




string Quarter(int digit)
{
    if (digit == 1) return "x > 0; y > 0";
    if (digit == 2) return "x < 0; y > 0";
    if (digit == 3) return "x < 0; y < 0";
    if (digit == 4) return "x > 0; y < 0";
    return "";
}