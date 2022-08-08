// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    // подсчёт количества цифр в числе
    int count = 0;
    int length = number;
    while (length != 0)
    {
        count++;
        length /= 10;
    }
    //делим введенное число на 10 в степени (кличество чисел - 3) 
    //получаем трёхзначную целую часть - выделяем целую часть 
    double num = Math.Floor(number / Math.Pow(10, (count - 3)));
    Console.WriteLine(num % 10);
}