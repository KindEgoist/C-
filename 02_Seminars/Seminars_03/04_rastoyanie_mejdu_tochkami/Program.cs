// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double FindDistance(double x1, double y1, double x2, double y2)
{
	return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y2));
}

Console.WriteLine("Введите координаты Х первой точки: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y первой точки: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Х второй точки: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y второй точки: ");
double yB = Convert.ToInt32(Console.ReadLine());

double dist = FindDistance(xA, yA, xB, yB);
Console.WriteLine($"Расстояние между точками {dist} ");