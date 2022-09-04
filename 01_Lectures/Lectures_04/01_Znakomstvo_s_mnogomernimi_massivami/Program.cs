
/* string[,] table = new string[2, 5];//иницилизация
table [1,2] = "слово";//обращение к нужному элементу

for(int i = 0; i <2; i++)
{
    for(int j = 0; j < 5; j++)
    {
        Console.Write($"-{table[i, j]}-");
    }
Console.WriteLine();
}*/

/*
int[,] matrix = new int[3,4];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
} */

void Print(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void Fill(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3,4];
Print(matrix);
Fill(matrix);
Console.WriteLine();
Print(matrix);