/*Задача 10
Напишите программу, которая 
принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

Console.Write("Введите трехзначное число: ");
string valueStr = Console.ReadLine();
int valueNum = int.Parse(valueStr);

if (valueNum > 99 && valueNum < 1000) //Условие работы только с трехзначными числами
{
    int secondNum = (valueNum % 100) / 10;
    Console.WriteLine("Вторая цифра этого числа: " + secondNum);
}
else
{
    Console.WriteLine("Введено некорректное число");
}
