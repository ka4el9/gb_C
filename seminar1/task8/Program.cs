﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Задание 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.WriteLine("Введите число больше 1: ");
string number = Console.ReadLine();
int userNumber = Convert.ToInt32(number);
if (userNumber < 1)
{
    Console.WriteLine("Error! Введите число больше 1");
}

for (int i = 1; i <= userNumber; i++)
{
    if (i % 2 == 0)
    Console.WriteLine(i);    
}