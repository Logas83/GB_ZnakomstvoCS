/*
Напишите программу, которая: 
1. принимает на вход число 
2. и выдаёт сумму цифр в числе

452 -> 11
82 -> 10
9012 -> 12
*/

int Summ(int num)
{
    int  summ = 0;

    while (num > 0)
    {        
        summ = summ + (num % 10);
        num = num / 10;
    }
    return summ;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);

int result = Summ(number);
Console.WriteLine(result);