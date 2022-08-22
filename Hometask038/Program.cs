// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
double[] myArray = new double[elementsCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индехом {i}:\t");
    myArray[i] = Convert.ToDouble(Console.ReadLine());
}
double max = myArray[1];
double min = myArray[1];
for (int i = 0; i < myArray.Length; i++)
{
    if (max < myArray[i]) max = myArray[i];
    else if (min > myArray[i]) min = myArray[i];
}
Console.Write('[' + String.Join(", ", myArray) + "] -> " + (max - min));
