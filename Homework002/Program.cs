/*Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Enter number ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum of digits {GetSum(number)}");

int GetSum(int n)
{
    int sum = 0;
    while (n > 0)
    // как работает последняя цифра?
    {
        sum+= n%10;sum=sum+(n%10)
        n = n/10;
    }
    return sum;
}