/*З
адача №5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

Console.WriteLine("Задание 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.");

Console.WriteLine("Введите целое число больше 0: ");
string number = Console.ReadLine();
int userNumber = Convert.ToInt32(number);

if (userNumber < 1)
{
    Console.WriteLine("Error. Введите число больше 1");
}

for (int i = -userNumber; i <= userNumber; i++)
{
    Console.WriteLine(i);
}