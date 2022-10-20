// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
Console.Clear();
Console.WriteLine("Вывод случайного трёхзначного числа");
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
string value = number.ToString();
Console.WriteLine($"{value[0]}{value[2]}");