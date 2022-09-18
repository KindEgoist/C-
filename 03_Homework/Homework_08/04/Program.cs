/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] RandomArray3d(int z, int x, int y) 
{
    int[,,] newArray = new int[z, x, y]; 
    int count = 10;
    for(int i = 0; i < z; i++) 
    {
        for(int j = 0; j < x; j++) 
        {
            for(int k = 0; k < y; k++)
            {
                newArray [i, j, k] = count;
                count ++;
                int temp = newArray [i, j, k];
                newArray [k, j, i] = newArray [i, j, k];;
                newArray [i, j, k] = temp;
            }
        }
    }
       
    return newArray;
}

void PrintArray3d(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
        Console.WriteLine($"{array[i, j, k]}(z={i},x={j},y={k}) ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] myArray = RandomArray3d(2, 2, 2);
PrintArray3d(myArray);

