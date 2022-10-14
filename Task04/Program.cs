// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю
// цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
int lastDigit = number % 10; //456 / 10 = 45   456 % 10 = 6 (остаток от деления)
Console.WriteLine($"Последняя цифра числа = {lastDigit}");
}

else Console.WriteLine("Неверный формат ввода. Введите трёхзначное число.");