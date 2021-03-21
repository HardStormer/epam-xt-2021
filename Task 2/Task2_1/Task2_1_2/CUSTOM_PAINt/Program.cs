using System;

namespace CUSTOM_PAINt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя?");
            string userName = Console.ReadLine();
            User MyUser = new User(userName);
            int choice = 0;
            int typeOfShape = 0;
            while (choice != 5)
            {
                Console.WriteLine($"{MyUser.Name}, выберите действие: {Environment.NewLine} 1. Добавить фигуру{Environment.NewLine} 2. Показать фигуры{Environment.NewLine} 3. Очистить фигуры{Environment.NewLine} 4. Смена пользователя{Environment.NewLine} 5. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"{MyUser.Name}, Выберите тип фигуры: {Environment.NewLine} 1. Круг{Environment.NewLine} 2. Кольцо{Environment.NewLine} 3. Квадрат{Environment.NewLine} 4. Прямоугольник{Environment.NewLine} 5. Треугольник");
                        typeOfShape = int.Parse(Console.ReadLine());


                        switch (typeOfShape)
                        {
                            case 1:
                                Circle circle;
                                double rcircle;
                                double xcircle;
                                double ycircle;
                                Console.WriteLine("Введите центральную точку (x, y)");
                                xcircle = double.Parse(Console.ReadLine());
                                ycircle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите радиус");
                                rcircle = double.Parse(Console.ReadLine());
                                circle = new Circle(xcircle, ycircle, rcircle);
                                MyUser.AddCircle = circle;
                                Console.WriteLine("Фигура круг добавлена");
                                break;
                            case 2:
                                Ring ring;
                                Console.WriteLine("Введите центральную точку (x, y)");
                                xcircle = double.Parse(Console.ReadLine());
                                ycircle = double.Parse(Console.ReadLine());

                                Console.WriteLine("Введите больший радиус");
                                rcircle = double.Parse(Console.ReadLine());

                                Console.WriteLine("Введите меньший радиус");
                                double rring = double.Parse(Console.ReadLine());

                                ring = new Ring(xcircle, ycircle, rcircle, rring);
                                MyUser.AddRing = ring;
                                Console.WriteLine("Фигура кольцо добавлена");
                                break;
                            case 3:
                                Square square;
                                double a;
                                Console.WriteLine("Введите сторону");
                                a = double.Parse(Console.ReadLine());
                                square = new Square(a);
                                MyUser.AddSquare = square;
                                Console.WriteLine("Фигура квадрат добавлена");
                                break;
                            case 4:
                                Rectangle rectangle;
                                Console.WriteLine("Введите стороны a, b");
                                a = double.Parse(Console.ReadLine());
                                double b = double.Parse(Console.ReadLine());
                                rectangle = new Rectangle(a, b);
                                MyUser.AddRectangle = rectangle;
                                Console.WriteLine("Фигура прямоугольник добавлена");
                                break;
                            case 5:
                                Triangle triangle;
                                double a_side = 0;
                                double b_side = 0;
                                double c_side = 0;
                                while (a_side + b_side <= c_side || a_side + c_side <= b_side || c_side + b_side <= a_side)
                                {
                                    Console.WriteLine("Введите стороны a, b, c");
                                    a_side = double.Parse(Console.ReadLine());
                                    b_side = double.Parse(Console.ReadLine());
                                    c_side = double.Parse(Console.ReadLine());
                                }
                                triangle = new Triangle(a_side, b_side, c_side);
                                MyUser.AddTriangle = triangle;
                                Console.WriteLine("Фигура треугольник добавлена");
                                break;
                            default:
                                Console.WriteLine("Фигура не добавлена");
                                break;
                        }



                        break;
                    case 2:
                        int count = 0;
                        if (MyUser.OutCircle.Count != 0)
                            foreach (Circle figure in MyUser.OutCircle)
                                figure.Print();
                        else
                            ++count;
                        if (MyUser.OutRing.Count != 0)
                            foreach (Ring figure in MyUser.OutRing)
                                figure.Print();
                        else
                            ++count;
                        if (MyUser.OutSquare.Count != 0)
                            foreach (Square figure in MyUser.OutSquare)
                                figure.Print();
                        else
                            ++count;
                        if (MyUser.OutRectangle.Count != 0)
                            foreach (Rectangle figure in MyUser.OutRectangle)
                                figure.Print();
                        else
                            ++count;
                        if (MyUser.OutTriangle.Count != 0)
                            foreach (Triangle figure in MyUser.OutTriangle)
                                figure.Print();
                        else
                            ++count;
                        if (count == 5)
                            Console.WriteLine("Нету фигур");
                        break;
                    case 3:
                        MyUser.OutCircle.Clear();
                        MyUser.OutRing.Clear();
                        MyUser.OutSquare.Clear();
                        MyUser.OutRectangle.Clear();
                        MyUser.OutTriangle.Clear();
                        Console.WriteLine("Очищено");
                        break;
                    case 4:
                        Console.WriteLine("Введите имя");
                        userName = Console.ReadLine();
                        MyUser.Name = userName;
                        break;
                }
            }
        }
    }
}
