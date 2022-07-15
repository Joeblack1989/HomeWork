//Task_018
//По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.

bool Check(int a,int b)
{
    return a*a==b;
}//подпрограмма в 12 строку

int a,b;
Console.Write("Введите первое число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.Write("Введите второе число и нажмите клавишу Enter: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
//==,!=,<,>,<=,>=
if(Check(a,b))
{
    Console.WriteLine("второе число является квадратом первого");
}
else
{
    if(b*b==a)
    {
        Console.WriteLine("первое число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Числа не являются квадратами друг друга");
    }
}












/*
if (2*2==4)//полное условие
{
//true
}
else
{
//false
}


if(2*2==4)//не полное условие
{

}
*/