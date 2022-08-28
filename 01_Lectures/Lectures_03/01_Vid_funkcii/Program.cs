// Вид 1
/*
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();*/

//Вид 2
/*void Method2(string msq)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); 
//Method2(msq: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
Method21("Текст", 4);
//Method21(msq: "Текст", count: 3);*/

//Вид 3
/*
int Method3()
{
    return DataTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);*/

// Вид 4
string Method4(int count, string textik)
{
    int i = 0;
    string result = String.Empty; //пустая строка

    while (i < count)
    {
        result = result + textik;
        i++;
    }
    return result;
}
string res = Method4(10, "Z ");
Console.WriteLine(res);