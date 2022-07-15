//Task_6
//Написать программу вычисления значения функции y = sin(a). (Класс Math)

double x,y;
Console.Write("Введите число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
x=Convert.ToInt32(s);
y=Math.Sin(x);
Console.WriteLine($"Синус от заданного числа составляет {y}");

/*Ниже записи и решение, сделанные во время семинара

double x,y;
x=Math.PI;
y=Math.Sin(x);
Console.WriteLine($"sin({x})={y}");

double r=1.0/3+1.0/3;
Console.WriteLine(r);


//тип возвращаемого значения Имя функции (аргументы функции)
/*double sin(double x)//методы
{
        return Math.Sin(x);
}// самодельная функция (подпрограмма)

double Sum(double a,double b)
{
    return a+b;
}

void Pause()//метод функция которая просто что то делает
{
    Console.WriteLine("Press ane key");
}

double y=sin(3.14);
Console.WriteLine(y);
Pause();
Console.WriteLine(Pause());
*/