/* Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double b1 = ReadInt("Введите координату b1: ");
double k1 = ReadInt("Введите координату k1: ");
double b2 = ReadInt("Введите координату b2: ");
double k2 = ReadInt("Введите координату k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if(k1 == k2)
{
    Console.WriteLine("Найти точку пересечения нельзя.");
}
else
{
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
} 



Double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}