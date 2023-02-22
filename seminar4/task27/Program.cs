/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

int ReadNumber (string messageToUser) {
    Console.WriteLine(messageToUser);
    return int.Parse(Console.ReadLine());
}

int SumToUser (int s) {
    int value = 0;
    do
    {
        value = value + s % 10;
        s /= 10;
    } while (s != 0);

    return value;
}

Console.WriteLine(SumToUser(ReadNumber("Введите число, чтобы получить сумму цифр данного числа ")));