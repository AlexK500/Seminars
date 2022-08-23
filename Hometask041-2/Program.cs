// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько цифр планируете ввести?: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число с индексом " + i + ": ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) count++;
}
Console.Write(String.Join(", ", array) + " -> " + count);
