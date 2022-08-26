// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Для нахождения числа в массиве по индексу, введите индекс строки: ");
int leftIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("И индекс столбца: ");
int rightIndex = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 5];
int rows = matrix.GetUpperBound(0) + 1;    // количество строк
int columns = matrix.Length / rows; // количество столбцов
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = new Random().Next(1, 101);
        if (leftIndex == i & rightIndex == j)
        {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" " + matrix[i, j] + " " + '\t');
        }
        else if (leftIndex == i)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" " + matrix[i, j] + " " + '\t');

        }
        else if (rightIndex == j)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" " + matrix[i, j] + " " + '\t');

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" " + matrix[i, j] + " " + '\t');
        }
     }
    Console.WriteLine();
}

Console.WriteLine();
if (leftIndex >= 0 & leftIndex < columns & rightIndex >= 0 & rightIndex < rows)
    {
    Console.ForegroundColor = ConsoleColor.White;    
    Console.Write($"По адресу [{leftIndex}, {rightIndex}] - находится значение: ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(matrix[leftIndex, rightIndex]);
    Console.ForegroundColor = ConsoleColor.White;
}
 else {Console.WriteLine("Значенией нет - запрашиваемый адрес вне диапазона массива");}
 Console.WriteLine();
 