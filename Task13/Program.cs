/*
Напишите программу, которая: 
1. выводит третью цифру заданного числа 
2. или сообщает, что третьей цифры нет. 
3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int ThirdDigit(int number)
{
    while (number > 999 )
    {
        number = number / 10;
    }
    return number % 10;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);
if (number >= 100)
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine(thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}