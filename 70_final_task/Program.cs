/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] array = new string[5] {"Hello", "2", "world", ":-)" , "456" };
string[] array2 = new string[array.Length];

int length = 3;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= length)
    {
        array2[count] = array[i];
        count++;
    }
}

Console.WriteLine();
WriteArray(array);
Console.WriteLine();
WriteArray(array2);



void WriteArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}