/*
Напишите цикл, который:
1. принимает на вход два числа (A и B) 
2. и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void Exponentiation(int num, int deg)
{
    int exp = 1;    
    for (int i = 0; i < deg; i++)
    {
        exp = exp * num;      
    }

    Console.WriteLine(exp);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите нужную натуральную степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree > 0)
{
    Exponentiation(number, degree);
}
else
{
    Console.WriteLine("Неправильный ввод!");
}