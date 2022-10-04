/*Задача 15
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/

Console.Write("Введите цифру дня недели (1-7), где 1 - понедельник, а 7 - воскресенье: ");
string weekday = Console.ReadLine();
int indexOfWeekday = int.Parse(weekday);

if (indexOfWeekday > 0 && indexOfWeekday < 8) // Условие работы только с заданным интервалом
{
    if (indexOfWeekday == 6 || indexOfWeekday == 7)
    {
        Console.WriteLine("ДА (Выходной)");    
    }
    else
    {
        Console.WriteLine("НЕТ (Рабочий день)");
    }
}
else
{
    Console.WriteLine("Введено некорректное число");
}