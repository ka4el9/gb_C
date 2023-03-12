/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

int reqursion (int m, int n) {

    if (n < m) return 0;
    else return  n + reqursion(m, n - 1);
    
}

Console.WriteLine(reqursion(ReadNumber("Введите число M:"), ReadNumber("Введите число N > M:")));


