// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

void Mes(int num1, int num2)
{
    int ostatok = num2 % num1;
    if (ostatok == 0) Console.WriteLine($"{num2} кратно числу {num1}");
    else Console.WriteLine($"Остаток от деления {num2} на {num1} равен {ostatok}");
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Mes(number1, number2);