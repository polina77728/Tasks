/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int size = ReadInt("Введите размер прямоугольного двумерного массива: ");
int[,] matrix = new int[size, size];
FillMatrixRandomNumbers(matrix);
WriteMatrix(matrix);
int indexRow = 1;
int sumMin = Int32.MaxValue;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];   
    }
    
    if(sum < sumMin)
    {
        sumMin = sum;
        indexRow++;
    }
    
}        
Console.WriteLine($"Строка с наименьшей суммой элементов: {indexRow} ");  





void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
