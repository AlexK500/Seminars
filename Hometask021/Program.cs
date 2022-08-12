// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2).

Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
Double pointAX = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
Double pointAY = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
Double pointAZ = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Отлично! Теперь координаты точки B: ");
Console.Write("X: ");
Double pointBX = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
Double pointBY = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
Double pointBZ = Convert.ToDouble(Console.ReadLine());

Double dist = Math.Sqrt(Math.Pow((pointBX-pointAX),2)+Math.Pow((pointBY-pointAY),2)+Math.Pow((pointBZ-pointAZ),2));
Console.Write($"Растояние между точками = {Math.Round(dist, 2)}");