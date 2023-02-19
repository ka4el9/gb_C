/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Задание 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.Write("Введите любое целое положительно число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

const int DEGREE = 3;

  if (number < 2)
  {
    Console.WriteLine("Error! Введено число меньше 2");
  }

  for (int i = 1; i <= number; i++)  {
    Console.WriteLine(Math.Pow(i,DEGREE));
  }