int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int a1 = 555662;
int a2 = 56;
int a3 = 56;

int b1 = 56;
int b2 = 45;
int b3 = 123;

int c1 = 343;
int c2 = 55;
int c3 = 6;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max_itog = Max(max1, max2, max3);

Console.WriteLine(max_itog);