/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
Без использования функции Math.Pow.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите число B: ");
int C = A;

for(int i = 1; i < B; i++)
{
    C = C * A;

}

Console.WriteLine($"{A},  {B} -> {C}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
