// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 0)
{
    number *= -1;
}
if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели неправильное значение!");
}
else
{
    int number_1 = (number / 10) % 10;
    Console.WriteLine(number_1);
}