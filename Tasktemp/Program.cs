Console.Write("Ваше имя: ");
// Ввод строки
string name = Console.ReadLine();
// Приветствие + подсказка
Console.Write("Привет, " + name + "\nВведите Ваш рост в см: ");
// Ввод числа. Чтобы сразу получить число, используйте методы класса Convert
double height = Convert.ToDouble(Console.ReadLine())/100;