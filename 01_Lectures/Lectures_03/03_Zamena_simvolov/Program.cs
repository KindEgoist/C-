// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить на маленькие "c".

string text = "-Я думаю, - сказать князь, улыбаюсь, - что, "
            +" ежели бы вас послали вместо нашего милого Винцегероде,"
            +"вы бы взяли приступом согласие прусского короля. "
            +"Вы так красноречивы. Вы дадите мне чаю?"; //string -страка как массив 0 1 2 3  s[3] = r   
                                                        //                          q w e r
string Replace(string text, char oldValue, char newValue)
{
   string result = String.Empty;
   int lenght = text.Length;
   for (int i =0; i < lenght; i++)
   {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
   } 
   return result;
}

string newText = Replace(text, ' ' , '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к' , 'К');
Console.WriteLine(newText);