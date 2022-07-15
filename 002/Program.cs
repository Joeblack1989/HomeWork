//Task_2
//С клавиатуры вводится вещественынх число. 
//Проверьте, является ли одно из них квадратом другого.

int a,b;
Console.Write("Введите первое число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.Write("Введите второе число и нажмите клавишу Enter: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
//==,!=,<,>,<=,>=
if(a*a==b)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    if(b*b==a)
    {
        Console.WriteLine("Первое число является квадратом второго");
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