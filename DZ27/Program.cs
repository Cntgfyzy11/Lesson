// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int summ = 0;
 while (number != 0)
 {
    summ+= number%10;
    number /= 10;
 }
 Console.WriteLine($"Сумма чисел равна {summ}");