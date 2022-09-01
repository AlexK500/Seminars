// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

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


//Вычмсляем сумму значений в строке
Console.WriteLine();
Console.WriteLine("Исходный массив:");
int sum = 0;
int temp = 0;
int strNum = 0;
int[,] matrix = ArrayGenerator(m, n);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum += matrix[i, j];
        Console.Write(" " + matrix[i, j] + " " + '\t');
       
    }
     Console.Write(" [" + sum + "] ");
    if(i==0) temp = sum;
     
    if(sum < temp)
    {
        temp=sum;
        strNum = i;

    }
    Console.WriteLine();
    sum = 0;
}
Console.WriteLine();

Console.WriteLine("Номер строки с наименьшей суммой элементов: "+(strNum+1)+" строка");