/* Задача 29: Напишите программу, которая задаёт массив из N элементов 
и выводит их на экран. Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33] */


Console.WriteLine("Введите число элементов для массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size]; //объявление массива


for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
}


