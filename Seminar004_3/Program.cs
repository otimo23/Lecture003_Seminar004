/*30 Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// int a = new Random().Next(2)*/

int []Mass = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(", ", Mass)}]");
//for(int i = 0; i < Mass.Length-1; i++)
//{
//   Console.Write($"{Mass[i]}, ");
//}
//Console.Write($"{Mass[Mass.Length-1]}");
int[] GetBinaryArray(int size)
{
   int[]result = new int[size];
   for(int i = 0; i < size; i++)
   {
      result[i] = new Random().Next(2);
   }
   return result;
}


