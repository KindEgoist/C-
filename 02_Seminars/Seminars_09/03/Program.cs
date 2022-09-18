// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNums(int m, int n) 
{
    if(n > m)
    {
        if(n > m) ShowNums (m, n - 1);
        Console.Write (n + " ");
    }
    else
    {
       if(m > n) ShowNums (m, n + 1);
        Console.Write (n + " "); 
    }
}

ShowNums(2, 10);
