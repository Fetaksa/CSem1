﻿//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Привет! Эта программа может выдавать название дня недели по заданному номеру.");
Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 && number < 8)
{
if(number == 1)
{
        Console.WriteLine("Понедельник");
}

else if(number == 2)
{
        Console.WriteLine("Вторник");
}

else if(number == 3)
{
        Console.WriteLine("Среда");
}

else if(number == 4)
{
        Console.WriteLine("Четверг");
}

else if(number == 5)
{
        Console.WriteLine("Пятница");
}

else if(number == 6)
{
        Console.WriteLine("Суббота");
}

else if(number == 7)
{
        Console.WriteLine("Воскресенье");
}

}
else
{
    Console.WriteLine("Недопустимое значение ввода");
}