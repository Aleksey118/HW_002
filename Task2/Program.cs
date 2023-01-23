// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int num1 = num;
if (num < 100)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    while (num1 > 999)
    {
        num1 = num1 / 10;
    }
    int res = num1 % 10;
    Console.WriteLine($"{num} -> {res}");
}
