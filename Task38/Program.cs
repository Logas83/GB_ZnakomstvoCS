/*
1. Задайте массив вещественных чисел. 
2. Найдите разницу между максимальным и минимальным элементом массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();    

    for (int i = 0; i < array.Length; i++)
    {        
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }

    return array;
}

double ElementDifference(double[] arr)
{
    double diff = 0;
    double minElem = arr[0];
    double maxElem = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElem) minElem = arr[i];
        if (arr[i] > maxElem) maxElem = arr[i];
    }

    diff = maxElem - minElem;
    return Math.Round(diff, 2);
}

void PrintArray(double[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    //Console.Write("]");
}

double[] arr = CreateArrayRndDouble(5, 1, 10);
//int[] newArray = ArrayProductNumberFirstLast(arr);
Console.Write("[");
PrintArray(arr);
Console.Write("]");
Console.Write(" -> ");
double elementDifference = ElementDifference(arr);
Console.Write(elementDifference);