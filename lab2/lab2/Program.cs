// Лабораторная работа 2
// Логические выражения Средний уровень Вариант 10
//Console.Write("введите число: ");
//int n = int.Parse(Console.ReadLine());
//bool result = (n % 2 == 0)
//    && ((n % 3 != 0 && n % 7 == 0))
//    && ((n % 5 != 0) ? (n % 4 != 0) : true)
//    && ((n % 8 == 0) ? (n % 11 == 0) : true);
//if (result)
//{
//    Console.WriteLine("Условие выполнено");
//}
//else
//{
//    Console.WriteLine("Условие не выполнено");
//}

//Условные операторы Средний уровень Вариат 16
//Console.Write("введите 3 стороны треугольника: ");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//if (a + b > c && a + c > b && b + c > a)
//{
//    Console.WriteLine("Можно построить треугольник");
//}
//else
//{
//    Console.WriteLine("Нельзя построить треугольник");
//}

//оператор выбора Базовый уровень Вариант 1
//var points = new (double x, double y)[]
//      {
//            (3.5, 7.2),
//            (-0.5, 1.2),
//            (0.72, 3.12)
//      };

//foreach (var point in points)
//{
//    bool isInArea = IsPointInArea(point.x, point.y);
//    Console.WriteLine($"Точка ({point.x}, {point.y}) " + $"{(isInArea ? "лежит" : "не лежит")} в области.");
//}

//    static bool IsPointInArea(double x, double y)
//{
//    // Условие: точка внутри области, если
//    // y <= 2 - x^2 и y >= 0 (ось абсцисс)
//    return y >= 0 && y <= 2 - x * x;
//}


