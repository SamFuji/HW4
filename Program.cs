Console.Clear();

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine();
// Задача 23

Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the power of number: ");
int power = Convert.ToInt32(Console.ReadLine());

int numPow =Convert.ToInt32( Math.Pow (number, power));
Console.WriteLine($"The number {number} in power of {power}: {numPow}");


