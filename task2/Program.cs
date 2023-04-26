// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a > b ? a : b; // Тернарный оператор  https://devpractice.ru/c-sharp-lesson-6-if-and-for/
int min = a < b ? a : b; // Синтаксис оператора : "condition ? if_true : if_else"
Console.WriteLine($"Наибольшее число: {max}");
Console.WriteLine($"Наименьшее число: {min}");