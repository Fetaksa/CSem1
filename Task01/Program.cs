// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число
// квадратом второго.

Console.WriteLine("Привет! Эта программа способна определить, является ли первое число квадратом второго.");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


//тут вводишь переменную square:
int square = number2 * number2;

//дальше пошёл цикл if
if(number1 == square)
{
    Console.WriteLine("Первое число является квадратом второго.");
}

else
{
    Console.WriteLine("Первое число НЕ является квадратом второго.");
}
