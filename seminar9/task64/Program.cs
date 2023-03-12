/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

void reqursion (int n) {
    Console.Write($"{n}\t");
    if (n <= 1) return;
    reqursion(n - 1);
}

reqursion( ReadNumber("Введите число N больше 1:"));

