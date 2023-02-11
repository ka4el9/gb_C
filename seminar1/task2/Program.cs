/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7, min = 5
a = 2 b = 10 -> max = 10, min = 2
a = -9 b = -3 -> max = -3, min = -9
*/

Console.WriteLine("Задание 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.");

Console.Write("Введите первое число: ");
string first = Console.ReadLine();
int number1 = Convert.ToInt32(first);

Console.Write("Введите второе число: ");
string second = Console.ReadLine();
int number2 = Convert.ToInt32(second);

if (number1 == number2) {
    Console.Write("max = ");
    Console.WriteLine(number1);
    Console.Write("max = ");
    Console.Write(number2);
}

if (number1 > number2) {
    Console.Write("max = ");
    Console.WriteLine(number1);

    Console.Write("min = ");
    Console.Write(number2);
}

if (number1 < number2) {
    Console.Write("min = ");
    Console.WriteLine(number1);

    Console.Write("max = ");
    Console.Write(number2);
}

