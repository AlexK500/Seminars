// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// Console.Write("Для нахождения числа в массиве по индексу, введите индекс строки: ");
// int leftIndex = Convert.ToInt32(Console.ReadLine());
// Console.Write("И индекс столбца: ");
// int rightIndex = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 5];
int[] arr = new int[25];
int[,] newarr = new int[4, 4];
int count = 0;
// int rows = matrix.GetUpperBound(0) + 1;    // количество строк
// int columns = matrix.Length / rows; // количество столбцов
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = new Random().Next(1, 101);
        arr[count] = matrix[i, j];
        count++;
    }
}

int result = arr.Min();

int ii = 0;
int jj = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (matrix[i, j] == result)
        {
            ii = i;
            jj = j;
        }
    }
}
Console.WriteLine();

Console.Write($"По адресу [{ii}, {jj}] - находится наименьший элемент массива: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(result);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (ii == i & jj == j)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" " + matrix[i, j] + " " + '\t');
        }
        else if (ii == i)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" " + matrix[i, j] + " " + '\t');

        }
        else if (jj == j)
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
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine($"Соответственно убираем строку {ii+1}-ю, столбец - {jj+1}-й получаем:");
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    if (i == ii)
    {
        continue;
    }
    else
    {
        for (int j = 0; j < 5; j++)
        {
            if (j == jj)
            {
                continue;
            }
            else
            {
                Console.Write(matrix[i, j] + " " + '\t');
            }

        }
    }

    Console.WriteLine();
}
