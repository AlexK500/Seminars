// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// проверка на кривые руки)
if (number > 99999 ^ number < 10000)
{
    Console.Write("Число введено не верно, попробуйте еще раз");
}
else
{
    // переводим число в строку
    string numStr = Convert.ToString(number);
    
    //  выбираем определенный символ и сравниваем
    if ((numStr.Substring(0, 1) == numStr.Substring(4, 1))
        && (numStr.Substring(1, 1) == numStr.Substring(3, 1)))
    { Console.Write("Да"); }
    else { Console.Write("Нет"); }
}