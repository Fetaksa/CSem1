﻿// Напишите программу, которая на вход
// 1. принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Привет! Эта программа возводит в квадрат целые числа.");
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// string str = Console.ReadLine();
// int num = Convert.ToInt32(str);   преобразует string в число

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");