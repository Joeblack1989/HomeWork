//Task_32
//Задать массив из 8 элементов и вывести их на экран

/*
int t1,t2,t3,t4,t5 //без массива
t1=10;
t2=2;
t3=14;//значимые типы данных
t4=6;
t5=20;
*/

//с массивом
int[] t; //объявление переменной
Init (out t,8);
Print(t, "t");
void Init(out int[] t, int Length, int min=0, int max=10)
{
    t=new int[Length];
    Random random=new Random();
    for(int i=0;i<t.Length;i++)
        t[i]=random.Next(min,max+1);
}
void Print(int[] t, string variableName)
{
    for(int i=0;i<t.Length;i++)
    Console.Write($"{variableName}[{i}]={t[i]} ");
}