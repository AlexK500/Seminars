// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Give 2 demension array M X N");
Console.Write("Enter M zise: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N zise: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];
double[,] matrix = new double[m, n];

// Заполняем массив случайными значениями
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 101);
        Console.Write(" " + matrix[i, j] + " " + '\t');
     }
    Console.WriteLine();
}
//  Находим среднее арифметическое каждого столбца:
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++) sum += matrix[i, j];
    arr[j] = Math.Round((sum / m), 1);
}
Console.WriteLine("[" + String.Join("]\t[", arr) + "]");
Console.WriteLine();
Console.WriteLine("Или записать как в условии:");
Console.WriteLine("Среднее арифметическое каждого столбца: " + String.Join("; ", arr));