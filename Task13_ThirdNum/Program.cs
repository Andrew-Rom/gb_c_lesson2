/*Задача 13
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/

Console.Write("Введите число: ");
string value = Console.ReadLine();

// Для корректной работы с отрицательными значениями
int checkValue = int.Parse(value);
if (checkValue < 0)
{
    value = value.Remove(0, 1);
}

// Вывод третьей цифры
int valueLen = value.Length;
if (valueLen >= 3)
{
    string thirdNum = value.Substring(2, 1);
    Console.WriteLine("Третья цифра этого числа: " + thirdNum);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
