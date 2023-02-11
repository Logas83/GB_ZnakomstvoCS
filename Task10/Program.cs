/*
Напишите программу, которая: 
1. принимает на вход трёхзначное число 
2. и на выходе показывает вторую цифру этого числа. 
3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
*/

int SecondDigit(int number)
{
    return (number / 10) % 10;
}

while (true)
{
    Console.Write("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 100 && number < 1000)
    {
        int secondDigit = SecondDigit(number);
        Console.WriteLine(secondDigit);
        break;
    }
    else
    {
        Console.WriteLine("Неправильный ввод!");
    }
}
