// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// проверка на кривые руки)
if(number > 99999 ^ number < 10000)
{
    Console.Write("Число введено не верно, попробуйте еще раз");
}
else
{
int length = Math.Abs(number);
int[] array = new int[5];
int count = 4;

// разбираем число на цифры и записываем в массив
while (length > 0)
{
    array[count] = length % 10;
    length /= 10;
    count --;
}

// сравниваем значения массива согласно позиции
if ((array[0] == array[4])
    && (array[1] == array[3]))
{ Console.Write("Да"); }
else { Console.Write("Нет"); }
}