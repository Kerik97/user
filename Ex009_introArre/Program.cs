int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3; 
    return result;
}


int[] arrey = {15, 24, 37, 845, 54, 67, 72, 84, 95};

int max = Max( 
    Max(arrey[0], arrey[1], arrey[2]),
    Max(arrey[3], arrey[4], arrey[5]),
    Max(arrey[6], arrey[7], arrey[8])

);

Console.WriteLine(max);


