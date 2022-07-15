//Task_3
//С клавиатуры вводятся два числа a и b. Найти максимальное из них.

double a,b;
Console.Write("Введите первое число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.Write("Введите второе число и нажмите клавишу Enter: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
if(a==b)
{
    Console.WriteLine("Второе число равно первому ");
}
else
{
    if(a<b)
    {
        Console.WriteLine("Первое число меньше, чем второе");
    }
    else
    {
        Console.WriteLine("Второе число  меньше, чем первое");
    }
}
