/*
1. Задайте прямоугольный двумерный массив.
2. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2}  ");
            else Console.Write($"{matrix[i,j], 2} ");
        }
        Console.WriteLine();
    }
}

int FindMinSumm(int[,] arr)
{
    int minSumm = default;
    int summ = default;
    int numString = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minSumm = minSumm + arr[0, i];
    }

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ = summ + arr[i, j];
        }
        if (summ < minSumm) 
        {
            minSumm = summ;
            numString = i;
        }
        summ = 0;
    }

    return numString;
}



int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int result = FindMinSumm(matrix);
Console.WriteLine($"{result} строка");