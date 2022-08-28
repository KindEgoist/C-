/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.==");
void Kub(int num)
{   
    int current = 1;
    while (current <= num)
    {
        Console.Write(current * current * current + " ");
        current++;
    }
}

Console.SetCursorPosition(0, 10);
Console.Write("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
Kub(k);

