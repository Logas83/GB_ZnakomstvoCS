/*
Напишите программу, которая:
1. принимает на вход число 
2. и выдаёт количество цифр в числе.

456 -> 3
78 -> 2
*/

int Numbers(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Numbers(number);
Console.WriteLine(result);