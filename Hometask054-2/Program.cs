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

// Сортировка всего массива через промежуточный массив
int m = 3;
int n = 3;
int size = m * n;
int count = 0;
int[,] array = new int[m, n];
int[] ary = new int[size];
Console.WriteLine("Сортировка всего массива через промежуточный массив");

Console.WriteLine("Исходный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 16);
        ary[count] = array[i, j];
    
    Console.Write(" " + ary[count] + " " + '\t');
    count++;
    }
    Console.WriteLine();
}

Console.WriteLine();
ary = ary.OrderBy(i => i).ToArray();
Console.WriteLine("Одномерный массив отсортирован c помощью .OrderBy");
for (int i = 0; i < ary.Length; i++)
{
Console.Write(" [" + ary[i] + "] ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("В итоге получается вот такой массив:");
count = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = ary[count];
        
    
    Console.Write(" " + array[i,j] + " " + '\t');
    count++;
    }
    Console.WriteLine();
}
