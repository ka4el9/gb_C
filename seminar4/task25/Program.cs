/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

int ReadNumber (string messageToUser) {
    Console.WriteLine(messageToUser);
    return int.Parse(Console.ReadLine());
}

double DegreeToUser (int n, int d) {
    double value = Math.Pow(n, d);
    return value;
}
Console.WriteLine(DegreeToUser(ReadNumber("Введите первое число, которое будем возводить в степень "), ReadNumber("Введите второе число (степень) ")));
