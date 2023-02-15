int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 1, 2, 45, 4, 44, 56, 37, 78, 9 };

int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);

int max_itog = Max(max1, max2, max3);

int[] array2 = { 1, 2, 45, 4, 44, 4, 37, 78, 9 };

int n = array2.Length;

int find = 4;

int index = 0;

while (index < n)
{
    if (find == array2[index])
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
