/* Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int size = 10;
double[] numbers = new double[size];
double max = 0;
double min = 0;
double difference = 0;

FillArrayRandomNumbers(numbers, -10, 10);
Console.WriteLine();
WriteArray(numbers);
Console.WriteLine();

for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];  
    }

   if (numbers[i] < min)
    {
        min = numbers[i];  
    }
}

difference = max - min;
Console.WriteLine($"Мах = {max} Min = {min}. Разница между мах и мin = {difference}");
Console.WriteLine();

void FillArrayRandomNumbers(double[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
    }
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

