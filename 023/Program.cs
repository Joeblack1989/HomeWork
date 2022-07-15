//Task_23
//Найти расстояние между точками в пространстве 2D

double x1,x2,y1,y2;
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
double a=x2-x1;
double b=y2-y1;
double c=Math.Sqrt(Math.Pow (a,2)+Math.Pow (b,2));      
Console.Write($"Hасстояние между указанными точками в пространстве 2D составляет:{c}");