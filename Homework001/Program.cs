/*Напишите цикл, который принимает на вход два числа (A и B) и возводит
 число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Enter A:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter B:");
int b = int.Parse(Console.ReadLine()!);
Console.Write($"A in power B {GetPower(a,b)}");

int GetPower(int c, int d)
{
    int result = 1;
    for(int i = 1; i <= d; i++)
    result = result * c;
    return result;
}



