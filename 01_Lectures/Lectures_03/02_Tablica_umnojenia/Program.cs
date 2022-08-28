/*string Method4(int count, string textik)
{
    
    string result = String.Empty; //пустая строка
    
    for (int i = 0; i < count; i++)
    {
        result = result + textik;
    }
    return result;
}
string res = Method4(10, "Z ");
Console.WriteLine(res);*/

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}