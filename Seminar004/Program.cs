/*Напишите программу, которая на вход принимает
 число N и выводит сумму от 1 до N.*/

int GetSum(int n)
{ 
    int sum = 0;
    for(int i = 1; i <= n; i++)
        sum+=i; //sum = sum +i
    return sum;
}
Console.Clear();
Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Summ from 1 to {n} is {GetSum(n)}");