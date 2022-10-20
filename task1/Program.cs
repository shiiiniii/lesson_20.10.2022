// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8
Console.Clear();
Console.WriteLine("Вывод случайного числа из отрезка [10, 99]");
int number = new Random().Next(10 , 100);
Console.WriteLine($"Случайное число: {number}");
int number1 = number / 10; 
int number2 = number % 10;
if(number1 > number2)
{
    Console.WriteLine($"Цифра {number1} > {number2}");
}
else
{
     Console.WriteLine($"Цифра {number2} > {number1}");
}
