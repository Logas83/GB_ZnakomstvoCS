/*
Напишите программу, которая:
1. принимает на вход число N 
2. и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120
*/

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int result = Faktorial(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено некорректное значение!");
}



int Faktorial(int num)
{
    int fakt = 1;

    for (int i = 1; i <= num; i++)
    {
        fakt = fakt * i;
    }
    return fakt;
}