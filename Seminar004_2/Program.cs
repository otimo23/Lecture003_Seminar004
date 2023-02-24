/*28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.*/

Console.WriteLine("Enter number: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Multiplication of {n} = {Mult (n)}");

int Mult (int n)
{
    int mult = 1;
    int s = 2;
    if(n < 0)
    s = n;// нужно s<=n, n= -5, 2<=-5 -цикл не запустится 
        //никогда,если не поменять местами s и n. s=n -> -5=-1
    n = -1;
    for(; s <= n; s++ )
    {
        mult = mult * s;
    }
    return mult;
}


