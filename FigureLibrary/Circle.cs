namespace FigureLibrary
{
    public class Circle : IFigure
    {
        double Radius;
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI*Radius*Radius;
        }

        public void SetUserValues()
        {
            Console.WriteLine("Введите радиус круга(положительное число больше 0)");
            Radius = Convert.ToDouble(Console.ReadLine());
            if(Radius <= 0 ) throw new ArgumentException("Ошибка! Неверный ввод");
        }
    }
}
