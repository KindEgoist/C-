/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.==");
void Vihodnoi(int num)
{
    if ( num >= 6 ) Console.WriteLine("Урааа, выходой!:)");
    else Console.Write("Блин! Опять работать. :(");
}

Console.SetCursorPosition(0, 10);
Console.Write("Введите цефру соответсрующему дню недели: ");
int N = Convert.ToInt32(Console.ReadLine());
Vihodnoi(N);
