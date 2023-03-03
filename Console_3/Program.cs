// Вводим четверть, выводим диапозон возможных значений
void Quarter(int x)
{
    if (x == 1)
    {
        Console.WriteLine("x > 0; y > 0");
    }
    if (x == 2)
    {
        Console.WriteLine("x < 0; y > 0");
    }
    if (x == 3)
    {
        Console.WriteLine("x < 0; y < 0");
    }
    if (x == 4)
    {
        Console.WriteLine("x > 0; y < 0");
    }
}
Console.Write("Введите номер четверти: ");
int Q = int.Parse(Console.ReadLine());

Quarter(Q);
