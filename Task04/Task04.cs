// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int number1 = new Random().Next();
Console.WriteLine($"Первое случайное число: {number1}");

int number2 = new Random().Next();
Console.WriteLine($"Второе случайное число: {number2}");

int number3 = new Random().Next();
Console.WriteLine($"Третье случайное число: {number3}");

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Максимальное число = {number1}");
}

else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Максимальное число = {number2}");
}

else
{
    Console.WriteLine($"Максимальное число = {number3}");
}