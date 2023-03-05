// Принимаем координаты двух точек; находим расстояние между ними
double Distance(double xa, double ya, double xb, double yb)
{
    double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
    return result;
}
Console.Write("Введите коордитнаты первой точки через Enter: ");
double xa = double.Parse(Console.ReadLine());
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите коордитнаты второй точки через Enter: ");
double xb = double.Parse(Console.ReadLine());
double yb = double.Parse(Console.ReadLine());

double distance = Distance(xa, ya, xb, yb);
Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(distance, 2, MidpointRounding.ToNegativeInfinity)}");
