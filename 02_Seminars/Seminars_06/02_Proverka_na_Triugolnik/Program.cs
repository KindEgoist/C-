// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool Treugolnik(int a, int b, int c)
{
    if(a + b > c && a + c > b && c + b > a) 
    {
            return true;
    }
    return false;
        
}

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Treugolnik(a, b, c));
