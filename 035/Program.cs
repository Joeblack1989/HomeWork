//Task_35
//Написать программу замены элементов массива на противоположные

int[] t; 
Unit (out t,10);
Print(t, "t");
Console.WriteLine();
replacement(t, 10);
Print(t, "t");

void Unit(out int[] t, int Length, int min=0, int max=100)
{
    t=new int[Length];
    Random random=new Random();
    for(int i=0;i<t.Length;i++)
        t[i]=random.Next(min,max+1);
}

void replacement(int[] t, int Length)//Вот эта программа. И она работает))
{
    for(int i=0;i<t.Length;i++)
    t[i] = -t[i];
}

void Print(int[] t, string variableName)
{
    for(int i=0;i<t.Length;i++)
    Console.Write($"{variableName}[{i}]={t[i]} ");
}

