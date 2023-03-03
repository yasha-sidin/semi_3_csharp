// Вводим координаты (x; y). Причем X и Y не равны 0; выдает номер плоскости
// [возвращаемый тип] [имя метода] ([параметры]){
// }

// int GetSum(int a, int b)
// {
//     int sum = a + b;

//     return sum;
// }

// int number = GetSum(10, 15);
// Console.WriteLine(number);

void Quarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("Третья четверть");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("Четвертая четверть");
    }
}
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

Quarter(X, Y);