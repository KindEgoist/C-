// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int PowValue(int a, int b)
{
    if(b > 1) return PowValue(a, b - 1) * a;
    else return a;
}

Console.Write(PowValue(2, 3));