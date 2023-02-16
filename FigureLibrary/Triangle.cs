namespace FigureLibrary
{
    public class Triangle : IFigure
    {
        double SideA;
        double SideB;
        double SideC;
        public Triangle() { }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            double maxSide = Math.Max(SideA, Math.Max(SideB, SideC));
            double perimeter = SideA + SideB + SideC;
            if (perimeter - maxSide <= maxSide)
                throw new ArgumentException("Ошибка! Указаны невозможные размеры сторон треугольника");
        }

        public double CalculateSquare()
        {
            double p = (SideA+SideB+SideC)/2;
            return Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
        }

        public void SetUserValues()
        {
            Console.WriteLine("Введите размеры сторон треугольника ЧЕРЕЗ ПРОБЕЛ");
            string[] sides = (Console.ReadLine()).Split(" ");
            SideA = double.Parse(sides[0]);
            SideB = double.Parse(sides[1]);
            SideC = double.Parse(sides[2]);
            double maxSide = Math.Max(SideA, Math.Max(SideB, SideC));
            double perimeter = SideA + SideB + SideC;
            if (perimeter - maxSide <= maxSide)
            throw new ArgumentException("Ошибка! Указаны невозможные размеры сторон треугольника");
        }

        public bool CheckForSquareness()
        {
            if(SideA > SideB && SideA > SideC)
            {
                if (Math.Pow(SideA, 2) == SideB * SideB + SideC * SideC) return true;
                else return false;
            }
            else if(SideB > SideA && SideB > SideC)
            {
                if (Math.Pow(SideB, 2) == SideA * SideA + SideC * SideC) return true;
                else return false;
            }
            else if (SideC > SideA && SideC > SideB)
            {
                if (Math.Pow(SideC, 2) == SideA * SideA + SideB * SideB) return true;
                else return false;
            }
            else return false;
        }
    }
}
