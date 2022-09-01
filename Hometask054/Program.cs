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

// ввод данных от пользователя
Console.WriteLine();
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());


// Метод генерации массива размер указывает польователь
int[,] ArrayGenerator(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++) matrix[i, j] = new Random().Next(1, 16);
    return matrix;
}


//Метод сортировки массива направление сортировки выбирает пользователь
Console.WriteLine();
Console.WriteLine("Исходный массив до сортировки:");
int[,] matrix = ArrayGenerator(m, n);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(" " + matrix[i, j] + " " + '\t');
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Для сортировки массива введите:");
Console.Write(" - (знак минус) если убывание, или + (знак плюс) по возрастанию: ");
var znak = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Сортировка возможна всего массива или только в строке");
Console.Write("Для строк нажмите С, для всего массива - просто Enter ");
var sort = Console.ReadLine();
if (znak != "+" & znak != "-")
{
    Console.Write("Не верно введены данные, поробуйте еще раз.");
}
else
{
    int k = 0;
    // int countStolb = 0;
    int countStr = 0;
    int endStr = 0;
    // countStr = m;

    while (countStr < (m * n))
    {
        for (int i = 0; i < m; i++)
        {
            if (znak == "+" & sort=="")
            {
                if (i != 0 && matrix[i, 0] < endStr)
                {
                    k = matrix[i, 0];
                    matrix[i, 0] = endStr;
                    matrix[i - 1, n - 1] = k;
                }
            }
            else if (znak == "-"  & sort=="")
            {
                if (i != 0 && matrix[i, 0] > endStr)
                {
                    k = matrix[i, 0];
                    matrix[i, 0] = endStr;
                    matrix[i - 1, n - 1] = k;
                }
            }



            int countStolb = n;
            while (countStolb >= 0)
            {
                for (int j = 1; j < n; j++)
                {
                    if (znak == "-")
                    {
                        if (matrix[i, j - 1] < matrix[i, j])

                        {
                            k = matrix[i, j - 1];
                            matrix[i, j - 1] = matrix[i, j];
                            matrix[i, j] = k;

                        }
                    }
                    else if (znak == "+")
                    {
                        if (matrix[i, j - 1] > matrix[i, j])

                        {
                            k = matrix[i, j - 1];
                            matrix[i, j - 1] = matrix[i, j];
                            matrix[i, j] = k;

                        }
                    }

                    endStr = matrix[i, j];

                }
                countStolb--;
            }
        }
        countStr++;
    }

    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(" " + matrix[i, j] + " " + '\t');
        }
        Console.WriteLine();
    }

}