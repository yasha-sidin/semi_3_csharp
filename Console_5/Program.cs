// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number; i++)
{
    Console.Write($"{Math.Pow(i, 2)}, ");
}
Console.Write($"{Math.Pow(number, 2)}");