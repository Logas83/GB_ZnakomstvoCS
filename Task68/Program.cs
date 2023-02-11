/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AckermannFunction(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = AckermannFunction(n, m - 1);
        n = n - 1;
    }

    return m + 1;
}

int result = AckermannFunction(2, 3);
Console.WriteLine(result);