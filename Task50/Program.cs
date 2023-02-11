/*
Напишите программу, которая: 
1. на вход принимает позиции элемента в двумерном массиве, 
2. и возвращает значение этого элемента 
3. или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет
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

void FindElem(int row, int colum, int[,] matrix)
{
    if (row < matrix.GetLength(0) && colum < matrix.GetLength(1)) Console.WriteLine(matrix[row, colum]);
    else Console.WriteLine($"{row}, {colum} -> такого числа в массиве нет");
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

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int colum = Convert.ToInt32(Console.ReadLine());

if (row >= 0 && colum >= 0)
{
    FindElem(row, colum, array2D);
}
else Console.WriteLine("Некорректный ввод! Отрицательные значения.");