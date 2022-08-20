/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.==");
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current <= N)
{   
    if (current %2 == 0)
    {
                Console.Write(current + " ");
    }
    current ++;
}


