//процедурное програмирование
/*
double Distance (double x1, double x2,double y1, double y2);
{
    return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
}

double x1=0,y1=0,x2=4,y2=4;
double distance=Distance(x1,y1,x2,y2);
System.Console.WriteLine(distance);
*/

//объекто-ориентированное програмирование
class Program

struct Point
{
    
}

static double Distance (double x1, double x2,double y1, double y2);
{
    return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
}

static void Main()
{
    Program program=new Program
    double x1=0,y1=0,x2=4,y2=4;
    double distance=Distance(x1,y1,x2,y2);
    System.Console.WriteLine(distance);
}






















/*
double x1,x2,y1,y2;
Init ();
Solution ();

void Init(double x1,double x2,double y1,double y2)
{
Console.Write("Введите x1 и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
x1=Convert.ToInt32(s);
Console.Write("Введите x2 и нажмите клавишу Enter: ");
s=Console.ReadLine();
x2=Convert.ToInt32(s);
Console.Write("Введите y1 и нажмите клавишу Enter: ");
s=Console.ReadLine();
y1=Convert.ToInt32(s);
Console.Write("Введите y2 и нажмите клавишу Enter: ");
s=Console.ReadLine();
y2=Convert.ToInt32(s);
}
void Solution ();
{
double a=x2-x1;
double b=y2-y1;
double c=Math.Sqrt(Math.Pow (a,2)+Math.Pow (b,2));      
Console.Write($"Hасстояние между указанными точками в пространстве 2D составляет:{c}");
}
*/