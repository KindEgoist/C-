//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuarnt(double x, double y)
{
	if(x > 0 && y > 0) return 1;
	if(x < 0 && y > 0) return 2;
	if(x < 0 && y < 0) return 3;
	if(x > 0 && y < 0) return 4;
	return 0;
}

Console.Write("Input X coordinat: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X coordinat: ");
double yA = Convert.ToDouble(Console.ReadLine());
int quadrant = FindQuarnt(xA, yA);

Console.WriteLine("Num of quad is" + quadrant); 

