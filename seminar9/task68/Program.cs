/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

int akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return akkerman(n - 1, 1);
    else
      return akkerman(n - 1, akkerman(n, m - 1));
}

Console.WriteLine(akkerman(ReadNumber("Введите число m:"), ReadNumber("Введите число n:")));