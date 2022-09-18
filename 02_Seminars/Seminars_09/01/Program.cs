// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//попорядку
// void ShowNums1(int n) 
// {
//     if(n > 1) ShowNums1 (n - 1);
//     Console.Write (n + " ");
// }
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNums1(n);

// наперед
// void ShowNums2(int n)
// {
//     if(n >= 1)
//     { 
//         Console.Write (n + " ");
//         ShowNums2 (n - 1);
//     }
// }


// int n = Convert.ToInt32(Console.ReadLine());
// ShowNums2(n);

// в ту и другую сторону
void ShowNums3(int n)
{
    if(n > 1)
    { 
        Console.Write (n + " ");
        ShowNums3 (n - 1);
    }
    Console.Write (n + " ");
}

int n = Convert.ToInt32(Console.ReadLine());
ShowNums3(n);
