/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Задание 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");


Console.Write("Введите целое число 1 до 7: ");
string number = Console.ReadLine();
int value = Convert.ToInt32(number);

if ((value < 1) || (value > 7) ) {
    Console.WriteLine("Error! Необходимо ввести число от 1 до 7");
 }
else {
    switch (value)
    {
        case 1: Console.WriteLine("Monday is not a day off");
        break;

        case 2: Console.WriteLine("Tuesday is not a day off");
        break;

        case 3: Console.WriteLine("Wednesday is not a day off");
        break;

        case 4: Console.WriteLine("Thursday is not a day off");
        break;

        case 5: Console.WriteLine("Friday is not a day off");
        break;

        case 6: Console.WriteLine("Saturday is a day off");
        break;

        case 7: Console.WriteLine("Sunday is a day off");
        break;
    }
}