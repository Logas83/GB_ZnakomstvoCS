/*
Напишите программу, которая:
принимает на вход число (N) 
2. и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void Square(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 5}    {Math.Pow(count, 2)}");
        count++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Square(number);
}
else
{
    Console.WriteLine("Введено не натуральное число!");
}


