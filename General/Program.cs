/*Tipe1 - ничего не возврашает и не принимает
void Method1() 
{
    Console.WriteLine("Author...");  
}
Method1();


Tipe2 - ничего не возвращает, 
но может принимать на вход аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text of message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;   
    }
}
Method21(msg:"Text", count: 4);
Or Method21(count: 4, msg:"Text");

Tipe 3 - ничего не принимает,
 что то возвращает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


Type4 - 
что то принимает и что то возвращает.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
        while (i < count)
        {
            result = result + text;
            i++;
        } 
        return result;
}
string res = Method4(10, "mama");
Console.WriteLine(res);*/


string Method4(int count, string text)
{
    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
        {
            result = result + text; 
        } 
        return result;
}
string res = Method4(10, "mama");
Console.WriteLine(res);