/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] CreateArray(int numbers)
{
    int[] arr = new int[numbers];

    for (int i = 0; i <= numbers - 1; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }

    return arr;
}

int PosetiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    
    return count;
}

void PrintArray(int[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    //Console.Write("]");
}

Console.Write("Сколько будем вводить чисел? ");
int numbers = Convert.ToInt32(Console.ReadLine());

if (numbers > 0)
{
    int[] array = CreateArray(numbers);
    PrintArray(array);
    Console.Write(" -> ");
    int result = PosetiveNumbers(array);
    Console.Write(result);
}
else
{
    Console.WriteLine("Некорректный ввод!");
}