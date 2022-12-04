/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbersMatrix = new int[rows, columns];
FillMatrixRandomNumbers(numbersMatrix);
WriteMatrix(numbersMatrix);

Console.WriteLine("Необходимо ввести позицию элемента в двумерном массиве.");


int numberRow = ReadInt("Введите номер строки элемента: ");
int numberColumn = ReadInt("Введите номер столбца элемента: ");

if (numberRow > rows && numberColumn > columns)
Console.WriteLine("такого числа нет");


else
{
    int minLength = numbersMatrix.GetLength(0);
    if(numbersMatrix.GetLength(1) < minLength)
    {
        minLength = numbersMatrix.GetLength(1);
    }
        Console.WriteLine($"{numbersMatrix[numberRow, numberColumn]} - есть ");
}





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
