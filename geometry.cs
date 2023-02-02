using System;
class Test {
  static void Main() {
    // круг
    Console.WriteLine("Введите радиус:");
    double pi = 3.14;
    double r;
    if (!double.TryParse(Console.ReadLine(), out r))
        Console.WriteLine("Неверный радиус!");
    else
        Console.WriteLine("Площадь круга: " + String.Format("{0:0.0}", pi * r * r));

    // треугольник 
    Console.WriteLine("Введите длины сторон треугольника:");
    string s_abc = Console.ReadLine();
    string[] arr_abc = s_abc.Split(' ');
    double a, b, c;

    if (!double.TryParse(arr_abc[0], out a))
        Console.WriteLine("Ошибка в первом значении!");
    else
    {
        if (!double.TryParse(arr_abc[1], out b))
            Console.WriteLine("Ошибка в втором значении!");
        else
        {
            if (!double.TryParse(arr_abc[2], out c))
                Console.WriteLine("Ошибка в третьем значении!");
            else    
                if (a + b <= c || a + c <= b || b + c <= a)
                    Console.WriteLine("Из этих значений нельзя составить треугольник!");
                else
                {
                    double p = 0.5 * (a + b + c);
                    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine("Площадь треугольника: " + String.Format("{0:0.0}", s));
                    
                    // проверка на прямоугольность: квадрат гипотенузы равен сумме квадратов катетов
                    if (
                        (a > b && a > c && a * a == (b * b + c * c))
                        ||
                        (b > a && b > c && b * b == (a * a + c * c))
                        ||
                        (c > a && c > b && c * c == (a * a + b * b))
                        )
                        Console.WriteLine("Кстати, это прямоугольный треугольник");
                }
        }
    }
  }
}
