// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a>b? a>c? a:c :b>c? b:c; // Тернарный оператор  https://devpractice.ru/c-sharp-lesson-6-if-and-for/
  // Синтаксис оператора : "condition ? if_true : if_else"
Console.WriteLine($"Наибольшее число: {max}");