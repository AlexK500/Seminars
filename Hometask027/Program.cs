// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numStr = Convert.ToInt32(Console.ReadLine());
int x = 1; // множитель первой цифры если вводимое число положительное
if (numStr < 0) x = -1; // множитель первой цифры если вводимое число отрицательное
numStr = Math.Abs(numStr); // готовим число для конвертации в текст
string str = Convert.ToString(numStr); // конвертация в текст
int result = (Convert.ToInt32(str.Substring(0, 1)))*x; // первую цифру приводим к знаку(+/-) вводимого числа
for (int i = 1; i < str.Length; i++) 
    result = result + Convert.ToInt32(str.Substring(i, 1)); // прибавляем остальные цифры
Console.Write(result);
