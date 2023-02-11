/*
1. Задайте одномерный массив, заполненный случайными числами. 
2. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

int SummNegativeElem(int[] arr)
{
    int summ = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0) summ += arr[i];
    }

    return summ;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ,");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] array = CreateArray(4, -99, 100);
PrintArray(array);
Console.Write(" -> ");
int summNegativeElem = SummNegativeElem(array);
Console.Write(summNegativeElem);