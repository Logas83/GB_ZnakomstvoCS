/*
Напишите программу, которая: 
1. принимает на вход пятизначное число 
2. и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

bool Reverse(int number)
{
    int reverse = 0;
    int digit = number;

    while (digit != 0)
    {
        reverse = reverse * 10;

        reverse = reverse + digit % 10;

        digit = digit / 10;
    }
    
    return number == reverse;
}


Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Reverse(number);

Console.WriteLine(result ? "да" : "нет");