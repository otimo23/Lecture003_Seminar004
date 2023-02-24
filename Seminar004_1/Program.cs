﻿/*26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5*/

Console.WriteLine("Enter number: ");
int s = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Digits number is {GetNum(s)}");

int GetNum (int n)
{
    int count = 0;
    if (n < 0)
    n = n * -1;
    while (n > 0)
    {
        n/=10;
        count++;
    }
    return count;
}