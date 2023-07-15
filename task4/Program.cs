// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int number_a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_c = int.Parse(Console.ReadLine());
if (number_a > number_b)
if (number_a > number_c) 
{
    Console.WriteLine ($"Максимальное число - {number_a}");
}
if (number_b > number_c)
if (number_b > number_a) 
{
    Console.WriteLine ($"Максимальное число - {number_b}");
}
if (number_c > number_b)
if (number_c > number_a) 
{
    Console.WriteLine ($"Максимальное число - {number_c}");
}