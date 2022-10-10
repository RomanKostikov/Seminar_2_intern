// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine()!);
if (day < 1 || day > 7)
{
    Console.WriteLine("Вы ввели неправильное значение!");
}
if (day == 1) Console.WriteLine("нет");
if (day == 2) Console.WriteLine("нет");
if (day == 3) Console.WriteLine("нет");
if (day == 4) Console.WriteLine("нет");
if (day == 5) Console.WriteLine("нет");
if (day == 6) Console.WriteLine("да");
if (day == 7) Console.WriteLine("да");