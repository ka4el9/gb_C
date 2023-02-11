/*
Задача 4: Напишите программу, которая принимает на вход 
три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Задание 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.");

Console.Write("Введите первое число: ");
string first = Console.ReadLine();
int number1 = Convert.ToInt32(first);

Console.Write("Введите второе число: ");
string second = Console.ReadLine();
int number2 = Convert.ToInt32(second);

Console.Write("Введите третье число: ");
string third = Console.ReadLine();
int number3 = Convert.ToInt32(third);

if (number1 > number2 | number1 > number3) {
    Console.Write("max number - ");
    Console.WriteLine(number1);
}

if (number2 > number2 | number2 > number3) {
    Console.Write("max number - ");
    Console.WriteLine(number2);
}
if (number3 > number1 | number3 > number2) {
    Console.Write("max number - ");
    Console.WriteLine(number3);
}
