/*
Напишите программу, которая: 
1. принимает на вход число (N) 
2. и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Cube(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 5}    {Math.Pow(count, 3)}");
        count++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Cube(number);
}
else
{
    Console.WriteLine("Введено не натуральное число!");
}