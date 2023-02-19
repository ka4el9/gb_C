/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Задание 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

int reserveNumber (int number) {    
    int var = 0;
    do
    {   var = var * 10 + number % 10;
        number /= 10;        
    } while (number != 0);

     return var;
}

Console.Write("Введите пятизначное число: ");
string usernumber = Console.ReadLine();
int value = Convert.ToInt32(usernumber);

if (value < 10000 || value > 99999 )
{
    Console.WriteLine("Error! Ведите пятизначное число");
}

if (value == reserveNumber(value))
{
    Console.WriteLine("Введено число палиндром");
}
else Console.WriteLine("Введено число не палиндром");
