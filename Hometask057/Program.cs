// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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


// Метод подсчета количества чисел в массиве
Console.WriteLine();
void CountNum(int m, int n)
{
    // int a = 0;
    int s = 1;
    int str = 0;
    int[] arStr = new int[m * n];

    // в методе подключен метод генерации мвссива ArrayGenerator()
    int[,] matrix = ArrayGenerator(m, n);

    for (int f = 0; f < m; f++)
    {
        for (int j = 0; j < n; j++)
        {
            arStr[str] = matrix[f, j];
            Console.Write(matrix[f, j] + " " + '\t');
            str++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    arStr = arStr.OrderBy(i => i).ToArray(); // сортируем столбец подсчета
    for (int i = 0; i < arStr.Length; i++)
    {
        if (arStr[i] != arStr[arStr.Length - 1])
        {
            if (arStr[i] == arStr[i + 1])
            {
                s++;
                continue;
            }
            else
            {
                Console.WriteLine(arStr[i] + " - " + s);
            }
        }
        else
        {
            Console.WriteLine(arStr[i] + " - " + s);
        }
        s = 1;
    }
}

// Вывод метода
CountNum(m, n);

