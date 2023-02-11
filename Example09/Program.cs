int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {12, 22, 31, 41, 15, 63, 17, 18, 19};


int max = Max(max1, max2, max3);

Console.WriteLine(max);