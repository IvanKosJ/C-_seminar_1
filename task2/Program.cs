// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число а: ");
int number_a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int number_b = int.Parse(Console.ReadLine());
if (number_a > number_b)
{
    Console.WriteLine ($"первое число больше второго и равно {number_a}");
}
else
{
    Console.WriteLine ($"второе число больше первого и равно {number_b}");
}