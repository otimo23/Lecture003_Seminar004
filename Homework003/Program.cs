/*Напишите программу, которая задаёт массив из 8
 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int[] array = GetBinArray(8);
int size = 8;
Console.Clear();
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine();
Console.WriteLine($"Sum is {GetSum(array)}"!);
int[] GetBinArray (int size)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
    result [i] = new Random().Next(0, 100);
    }
    return result;
    
}
int GetSum(int[]result)
{
    int sum = 0;
    for(int i=0; i < size; i++)
    sum = sum+result[i];
    return sum;
}