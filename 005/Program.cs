//Task_5
//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

double a,b,c;
double max=0;
Console.Write("Введите первое число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.Write("Введите второе число и нажмите клавишу Enter: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
Console.Write("Введите третье число и нажмите клавишу Enter: ");
s=Console.ReadLine();
c=Convert.ToInt32(s);
if(a>b)
{
    max=a;
}
    if (b>max)
    {
        max=b;
    }
        if (c>max)
        {
            max=c;
        }
Console.WriteLine($"Максимальное чиcло {max}");