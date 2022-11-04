// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А:");
Console.WriteLine("Введите число B:");
 int numberA = int.Parse(Console.ReadLine());
 int numberB = int.Parse(Console.ReadLine());
 double c = Math.Pow(numberA, numberB);

for (int i = 0; i <=numberA && i <=numberB; i++)

Console.WriteLine($"Число {numberA} в степени {numberB} равно {c}");