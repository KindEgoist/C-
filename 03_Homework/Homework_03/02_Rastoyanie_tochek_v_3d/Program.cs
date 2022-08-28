/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.==");
double TwoTochki(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
}

Console.SetCursorPosition(0, 10);
Console.Write("Введите координаты Х первой точки: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y первой точки: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z первой точки: ");
double zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Х второй точки: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y второй точки: ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z второй точки: ");
double zB = Convert.ToInt32(Console.ReadLine());

double dist = TwoTochki(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками {dist} ");

