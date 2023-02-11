/*
Напишите программу, которая:
1. выводит массив из 8 элементов, 
2. заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0]
*/

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}


int[] array = FillArray(8, 0, 1);
PrintArray(array);