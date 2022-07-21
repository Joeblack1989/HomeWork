//task_41
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


double [] t; //инициализация массива
Unit (out t,10);
MinMaxPrint ();

void Unit(out double[] t, int Length, int min=0, int max=99)// заполняем массив
{
    t=new double[Length];
    Random random=new Random();
    for(int i=0;i<t.Length;i++)
        t[i]=random.Next(min,max)+ random.NextDouble();
}

void MinMaxPrint (double min=99, double max=0)
{
    for(int i=0;i<t.Length;i++)
    if(t[i]<min)
        {
        min = t[i];
        }
    else
    if (t[i]>max)
        {
        max = t[i];
        }
    Console.WriteLine("max:  " + Math.Round (max, 3));
    Console.WriteLine("min:  " + Math.Round (min, 3));
    Console.WriteLine($"Разница между максимальным и минимальным значением массива: {Math.Round (max, 3)-Math.Round (min, 3)}");
}