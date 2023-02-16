using FigureLibrary;

IFigure figure = new Circle(3);
Console.WriteLine($"Площадь круга с радиусом 3: {figure.CalculateSquare()}");
figure = new Triangle(12, 16, 20);
Console.WriteLine($"Площадь треугольника со сторонами 12,16,20: {figure.CalculateSquare()}");
Console.WriteLine($"Это прямоугольный треугольник? {(figure as Triangle).CheckForSquareness()}");
Console.WriteLine();

figure = UserQuery.ChooseFigure();
Console.WriteLine($"Площадь фигуры: {figure.CalculateSquare()}");
if (figure.GetType() == typeof(Triangle)) Console.WriteLine($"Это прямоугольный треугольник? {(figure as Triangle).CheckForSquareness()}");

Console.ReadLine();