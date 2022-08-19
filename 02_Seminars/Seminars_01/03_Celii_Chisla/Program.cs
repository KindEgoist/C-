// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = N * (-1);
while(current <= N)
{   Console.Write(current + " ");
    current ++;
}
