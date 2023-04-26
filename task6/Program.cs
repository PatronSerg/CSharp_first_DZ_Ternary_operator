// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Введите число :");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// Console.WriteLine($"{num} является чётным");
// else
// Console.WriteLine($"{num} не является чётным");

Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
string result = (num%2==0)? "четное":"нечетное";
Console.WriteLine($"{num} {result}");