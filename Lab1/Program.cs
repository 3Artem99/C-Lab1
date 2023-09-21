//Задание№1
//Выведите на консоль минимальные и максимальные значения для предопределенных типов данных CTS.

//==============================================================================================================================================================================================

//Задание№2
//Создайте класс с именем Rectangle.
//В теле класса создайте два поля, описывающие длины сторон double side1, side2.
//Создайте пользовательский конструктор Rectangle(double sideA, double sideB), в теле которого поля sideA и sideB инициализируются значениями аргументов.
//Создайте два private метода, вычисляющие площадь прямоугольника - double CalculateArea() и периметр прямоугольника - double CalculatePerimeter ().
//Создайте два свойства double Area и double Perimeter с одним методом доступа get, вызывающим созданные ранее методы.
//Напишите программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. Покройте тестами методы класса Rectangle.

//==============================================================================================================================================================================================


//Задание №3
//Создайте классы Point и Figure.
//Класс Point должен содержать два целочисленных поля с координатами точки.
//Создайте два свойства с одним методом доступа get.
//Создайте пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point, а также строковое автосвойство для хранения названия фигуры.
//Создайте два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Напишите программу, которая выводит на экран название и периметр многоугольника. Покройте тестами методы класса Figure.

//Примечание: Избегайте повторения кода при реализации перегруженных конструкторов, используйте реализованные ранее конструкторы с помощью ключевого слова this, например, так:

using System;
namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            DisplayMinMaxValues(typeof(byte));
            DisplayMinMaxValues(typeof(sbyte));
            DisplayMinMaxValues(typeof(short));
            DisplayMinMaxValues(typeof(ushort));
            DisplayMinMaxValues(typeof(int));
            DisplayMinMaxValues(typeof(uint));
            DisplayMinMaxValues(typeof(long));
            DisplayMinMaxValues(typeof(ulong));
            DisplayMinMaxValues(typeof(float));
            DisplayMinMaxValues(typeof(double));
            DisplayMinMaxValues(typeof(decimal));
            DisplayMinMaxValues(typeof(char));
            DisplayMinMaxValues(typeof(bool));

            //Задание 2
            Console.Write("Введите длину первой стороны прямоугольника: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второй стороны прямоугольника: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(sideA, sideB);

            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");

            //Задание 3
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 4);
            Point point3 = new Point(3, 0);

            Figure triangle = new Figure(point1, point2, point3)
            {
                Name = "Треугольник"
            };

            Point point4 = new Point(0, 0);
            Point point5 = new Point(0, 5);

            Figure pentagon = new Figure(point1, point2, point3, point4, point5)
            {
                Name = "Пятиугольник"
            };

            triangle.PerimeterCalculator();
            pentagon.PerimeterCalculator();

            Console.ReadLine();
        }


        static void DisplayMinMaxValues(Type dataType)
        {
            TypeCode typeCode = Type.GetTypeCode(dataType);

            Console.WriteLine($"Type: {dataType.Name}");
            Console.WriteLine($"Type Code: {typeCode}");

            switch (typeCode)
            {
                case TypeCode.Byte:
                    Console.WriteLine($"Min Value: {byte.MinValue}");
                    Console.WriteLine($"Max Value: {byte.MaxValue}");
                    break;
                case TypeCode.SByte:
                    Console.WriteLine($"Min Value: {sbyte.MinValue}");
                    Console.WriteLine($"Max Value: {sbyte.MaxValue}");
                    break;
                case TypeCode.Int16:
                    Console.WriteLine($"Min Value: {short.MinValue}");
                    Console.WriteLine($"Max Value: {short.MaxValue}");
                    break;
                case TypeCode.UInt16:
                    Console.WriteLine($"Min Value: {ushort.MinValue}");
                    Console.WriteLine($"Max Value: {ushort.MaxValue}");
                    break;
                case TypeCode.Int32:
                    Console.WriteLine($"Min Value: {int.MinValue}");
                    Console.WriteLine($"Max Value: {int.MaxValue}");
                    break;
                case TypeCode.UInt32:
                    Console.WriteLine($"Min Value: {uint.MinValue}");
                    Console.WriteLine($"Max Value: {uint.MaxValue}");
                    break;
                case TypeCode.Int64:
                    Console.WriteLine($"Min Value: {long.MinValue}");
                    Console.WriteLine($"Max Value: {long.MaxValue}");
                    break;
                case TypeCode.UInt64:
                    Console.WriteLine($"Min Value: {ulong.MinValue}");
                    Console.WriteLine($"Max Value: {ulong.MaxValue}");
                    break;
                case TypeCode.Single:
                    Console.WriteLine($"Min Value: {float.MinValue}");
                    Console.WriteLine($"Max Value: {float.MaxValue}");
                    break;
                case TypeCode.Double:
                    Console.WriteLine($"Min Value: {double.MinValue}");
                    Console.WriteLine($"Max Value: {double.MaxValue}");
                    break;
                case TypeCode.Decimal:
                    Console.WriteLine($"Min Value: {decimal.MinValue}");
                    Console.WriteLine($"Max Value: {decimal.MaxValue}");
                    break;
                case TypeCode.Char:
                    Console.WriteLine($"Min Value: {char.MinValue}");
                    Console.WriteLine($"Max Value: {char.MaxValue}");
                    break;
                case TypeCode.Boolean:
                    Console.WriteLine($"Min Value: {bool.FalseString}");
                    Console.WriteLine($"Max Value: {bool.TrueString}");
                    break;
                default:
                    Console.WriteLine("Unknown type.");
                    break;
            }
            Console.WriteLine();
        }
        //==============================================================================================================================================================================================
        class Rectangle
        {
            private double side1;
            private double side2;

            public Rectangle(double sideA, double sideB)
            {
                side1 = sideA;
                side2 = sideB;
            }

            private double CalculateArea()
            {
                return side1 * side2;
            }

            private double CalculatePerimeter()
            {
                return 2 * (side1 + side2);
            }

            public double Area
            {
                get { return CalculateArea(); }
            }

            public double Perimeter
            {
                get { return CalculatePerimeter(); }
            }
        }
        //==============================================================================================================================================================================================

        public class Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        public class Figure
        {
            private readonly Point[] points;
            public string Name { get; set; }
            public Figure()
            {
                points = new Point[5];
            }

            public Figure(Point point1, Point point2, Point point3) : this()
            {
                points[0] = point1;
                points[1] = point2;
                points[2] = point3;
            }

            public Figure(Point point1, Point point2, Point point3, Point point4) : this(point1, point2, point3)
            {

                points[3] = point4;
            }

            public Figure(Point point1, Point point2, Point point3, Point point4, Point point5) : this(point1, point2, point3, point4)
            {
                points[4] = point5;
            }

            public void PerimeterCalculator()
            {
                double perimeter = 0;
                int pointCount = 0;
                switch (Name)
                {
                    case "Треугольник":
                        pointCount = 3;
                        break;
                    default:
                        break;
                }

                for (int i = 0; i < pointCount; i++)
                {
                    int nextIndex = (i + 1) % pointCount; // Обработка последней точки, связывая ее с первой

                    perimeter += LengthSide(points[i], points[nextIndex]);

                }
                if (points[4] == null)
                {
                    Console.WriteLine("is null");
                }

                Console.WriteLine($"Название фигуры: {Name}");
                Console.WriteLine($"Периметр: {perimeter}");
            }

            private double LengthSide(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }
        }
    }
}