//Task_38
//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] t; 
Unit (out t,123);
FindNumbers ();

void Unit(out int[] t, int Length, int min=0, int max=123)// заполняем массив числами по порядку
{
    t=new int[Length];
    for(int i=0;i<t.Length;i++)
    t[i]=i+1;
}
void FindNumbers (int CatchNumber=0)// счет элементов в заданном диапазоне и вывод результата
{
    for(int i=0;i<t.Length;i++)
    if (t[i]>9 && t[i]<100)
    {
    CatchNumber=CatchNumber+1;
    }
    Console.Write($"В диапазоне между числами 10 и 99 находится {CatchNumber} элементов заданного массива");
}