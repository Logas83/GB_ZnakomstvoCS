/*
Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.

7 -> 28
4 -> 10
8 -> 36
*/

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int result = SummNumbers(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено некорректное значение!");
}



int SummNumbers(int num)
{
    int summ = 0;

    for (int i = 1; i <= num; i++)
    {
        summ += i;
    }
    return summ;
}