namespace FigureLibrary
{
    public class UserQuery
    {
        //IFigure figure;
        public static IFigure ChooseFigure()
        {
            IFigure selectedFigure;
            Console.WriteLine("Выберите фигуру: Круг(введите 1), Треугольник(введите 2)");
            switch (Console.ReadLine())
            {
                case "1": selectedFigure = new Circle(); break;
                case "2": selectedFigure = new Triangle(); break;
                default: throw new ArgumentException("Ошибка! Неверный ввод"); 
            }
            selectedFigure.SetUserValues();
            return selectedFigure;
        }
    }
}