//Task_45
//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

intersection ();

void intersection(int b1=1, int b2=2, int k1=3, int k2=4)
{
if (k1==k2)
    {
    Console.WriteLine ("Заданные прямые не пересекаются");
    }
    else 
    {
    int x=(b2-b1)/(k1-k2);
    int y= k1*((b2-b1)/(k1-k2))+b1;
    Console.WriteLine($" Точка пересечения двух заданных прямых: X = {x}; Y = {y} ");
    }       
}
