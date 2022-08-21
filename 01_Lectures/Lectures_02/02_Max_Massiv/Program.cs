int Max(int arg1, int arg2, int arg3) //метод функции
{
    int result = arg1;
    if(arg1> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}//            0    1   2  3    4   5   6   7   8
int[] array = {15, 21, 39, 12, 23, 33, 13, 29, 53};
// array[0] = 12; оюразение к массиву по индексу и замена значения
int max =Max( 
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
