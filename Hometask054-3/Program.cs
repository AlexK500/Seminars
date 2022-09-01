// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Сортировка строк массива через временный массив;
int m = 3;
int n = 3;
int[,] array = new int[m, n];
int[] ary = new int[n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 16);
        ary[j] = array[i, j];


        Console.Write(" " + ary[j] + " " + '\t');
        
    }
    ary = ary.OrderByDescending(i => i).ToArray();
    for (int k = 0; k < n; k++)
    {
        array[i, k] = ary[k];

    }
    Console.WriteLine();

}
Console.WriteLine("В итоге получается вот такой массив:");
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(" " + array[i, j] + " " + '\t');

    }
    Console.WriteLine();
}
