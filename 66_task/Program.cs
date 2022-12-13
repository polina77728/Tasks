/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int m = ReadInt("Введите М: ");
int n = ReadInt("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

SumNumRec(m, n, 0);

void SumNumRec(int m, int n, int sum)
{
    sum = sum + n;
    if (n < m)
    {
        Console.Write($" {sum} ");
        return;
    }
    SumNumRec(m, n - 1, sum);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

