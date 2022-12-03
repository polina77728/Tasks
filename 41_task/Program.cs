/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  */

Console.WriteLine("Введите несколько цифр через запятую: ");
string? input = Console.ReadLine();
char splitSymbol = ',';

// Считаем количество запятых
int numbersCount = 1;
for(int i = 0; i < input.Length; i++)
{
    if(input[i] == splitSymbol)
    numbersCount++;
}       
  
Console.Write(numbersCount); //Проверяем сколько чисел ввел пользователь
int[] numbers = new int[numbersCount];
//проходим циклом по всей строке, значение от текущего до запятой(это наше число) записываем в отд.строку 
//потом конвентируем.
//индексы строки не совпадают с индексами массива, поэтому создаем отдельную переменную и отд.подстроку
Console.WriteLine();
int numberIndex = 0;
string subString = "";

for(int i = 0; i < input.Length; i++)
{
    if(input[i] == splitSymbol)
    {
        numbers[numberIndex] = Convert.ToInt32(subString);
        subString = ""; //обнулить подстроку 
        numberIndex++;
    }
    //иначе, если не запятая, то добавляем текущий символ в подстроке
    else
    {
        subString += input[i];
    }
}  
//добавляем последнюю цифру (т.к.в конце нет запятой)
numbers[numberIndex] = Convert.ToInt32(subString);

WriteArray(numbers);

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

/*Решение с методами
Console.Write("Введите числа через запятую: ");
string? input = Console.ReadLine();
char splitSymbol = ',';

WriteArray(ParseArray(input, splitSymbol));

int[] ParseArray(string inputNumbers, char split)
{
    // Считаем количество запятых
    int numbersCount = 1;
    for(int i = 0; i < inputNumbers.Length; i++)
    {
        if(inputNumbers[i] == split)
        numbersCount++;
    }       
    int[] numbers = new int[numbersCount];
    int numberIndex = 0;
    string subString = "";
    for(int i = 0; i < inputNumbers.Length; i++)
    {
        if(inputNumbers[i] == split)
        {
            numbers[numberIndex++] = Convert.ToInt32(subString);
            subString = "";
        }
        else
        {
        subString += inputNumbers[i];
        }
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    return numbers;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/

