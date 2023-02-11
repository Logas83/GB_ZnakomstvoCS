/*
1. Задайте значения M и N. 
2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
3. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SummNaturalNumbers(int num1, int num2)
{    
    int summ = 0;
    summ = summ + num1;
    if (num1 == num2) return summ;    
        
    if (num1 > num2) return summ = summ + SummNaturalNumbers(num1 - 1, num2);
    else return summ = summ + SummNaturalNumbers(num1 + 1, num2);
}



Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = SummNaturalNumbers(number1, number2);
Console.WriteLine(result);