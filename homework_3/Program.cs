// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine()!);
if (day >= 1 && day <= 5) Console.WriteLine("нет");
else if (day == 6 || day == 7) Console.WriteLine("да");
else Console.WriteLine("Такого дня недели не существует");