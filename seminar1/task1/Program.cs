/* 
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

Console.WriteLine("Задание 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.");

Console.Write("Введите первое число: ");
string first = Console.ReadLine();
int number1 = Convert.ToInt32(first);

Console.Write("Введите второе число: ");
string second = Console.ReadLine();
int number2 = Convert.ToInt32(second);

if (number1 == number2*number2)
{
    Console.WriteLine("true");    
}
else Console.WriteLine("false");