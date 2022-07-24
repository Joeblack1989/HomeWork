namespace ConsoleApplication
{
    class Point//Класс точки, представленной 2-мя координатами.
    {
        public Point() { }//
 
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
 
        public int X { get; set; }
        public int Y { get; set; }
 
        public override string ToString()
        {
            return String.Format("X = {0}, Y = {1}", X, Y);
        }
         public static Point operator +(Point pt, Vector v)
        {
            return new Point(pt.X + v.X, pt.Y + v.Y);
        }
    }
    class Vector//Класс вектора, представленный 2-мя координатами.
    {
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector(Point ptStart, Point ptEnd)
        {
            X = ptEnd.X - ptStart.X;
            Y = ptEnd.Y - ptStart.Y;
        }
 
        public int X { get; set; }
        public int Y { get; set; }
        public static int ScalarProd(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }  
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
    }
    class Program
    {
        static Point stringToPoint(string str)//Вспомогательная функция для конвертации строки в экземпляр точки (Point)/ В строке через пробел должны быть записаны 2 целые координаты.
        {
            string[] coordStrings = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (coordStrings.Length != 2)
                throw new ArgumentException("Недопустимый ввод.");
            Point pt = new Point();
            pt.X = Int32.Parse(coordStrings[0]);
            pt.Y = Int32.Parse(coordStrings[1]);
            return pt;
        }

        /*void zoom (int k, int [] points)
        {
            Point[] newpoints = new Point[4];
            Console.Write("Введите коэфициент масштабирования и нажмите клавишу Enter: ");
            string? s=Console.ReadLine();
            k=Convert.ToInt32(s);
            newpoints = points[0]*k;
        }
        */

        static void Main(string[] args)
        {
            Point[] points = new Point[4]; // 4 точки, задаваемые пользователем.
            
            Console.WriteLine("Введите (через пробел) координаты 4-х точек создаваемой фигуры: ");
            Console.WriteLine("Первая точка: ");
            points[0] = stringToPoint(Console.ReadLine());
            Console.WriteLine("Вторая точка: ");
            points[1] = stringToPoint(Console.ReadLine());
            Console.WriteLine("Третья точка: ");
            points[2] = stringToPoint(Console.ReadLine());
            Console.WriteLine("Четвертая точка: ");
            points[3] = stringToPoint(Console.ReadLine());
            
            
            
            // Вывод результатов.
            Console.WriteLine("Введённые точки:");
            //Console.WriteLine($"{Point pt*2}");
            foreach(Point pt in points)
            {
                Console.WriteLine(pt);
            }
        }
    }
}