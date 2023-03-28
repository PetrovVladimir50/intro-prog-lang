int a1 = 45;
int a2 = 54;
int a3 = 2;
int b1 = 87;
int b2 = 1;
int b3 = 0;
int c1 = 15;
int c2 = 84;
int c3 = 33;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} 
int max1 = Max(a1,a2,a3);
int max2 = Max(b1,b2,b3);
int max3 = Max(c1,c2,c3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);