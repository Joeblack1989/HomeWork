//Task_37
//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] t; 
Unit (out t,10);
Print(t, "t");
Console.WriteLine();
FindNumbers ();

void Unit(out int[] t, int Length, int min=99, int max=999)// заполняем массив
{
    t=new int[Length];
    Random random=new Random();
    for(int i=0;i<t.Length;i++)
        t[i]=random.Next(min,max+1);
}
void FindNumbers (int even=0, int noeven=0)// счет чет/нечет
{
    for(int i=0;i<t.Length;i++)
    if (t[i]%2==0)
    {
    even=even+1;
    }
    else 
    {
    noeven=noeven+1;
    }
    Console.Write($"Четных чисел: {even} ");
    Console.Write($"Нечетных чисел: {noeven} ");
}

void Print(int[] t, string variableName)// вывод массива
{
    for(int i=0;i<t.Length;i++)
    Console.Write($"{variableName}[{i}]={t[i]} ");
}

