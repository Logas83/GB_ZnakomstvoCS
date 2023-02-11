/*
Напишите программу, которая 
1. на вход принимает число 
2. и выдаёт его квадрат (число
умноженное на само себя).
3. вывод результата
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number*number);

