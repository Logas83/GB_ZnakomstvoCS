/*
1. Задайте двумерный массив из целых чисел. 
2. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] Average(int[,] matrix)
{
    double[] averageArray = new double[matrix.GetLength(1)];

    double summ = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ += matrix[i, j];
        }
        averageArray[j] = Math.Round(summ / matrix.GetLength(0), 1);
        summ = 0;
    }

    return averageArray;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 1}  ");
            else Console.Write($"{matrix[i,j], 1} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}.");
    }
    //Console.Write("]");
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
double[] average = Average(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(average);