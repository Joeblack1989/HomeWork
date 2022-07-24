//Task_43
//Определить сколько чисел больше 0 введено с клавиатуры

int [] t; 
array(out t,3);
Print(t, "t");
MoreThenZero();

void array (out int[] t, int Length) // заполняем массив
{
    t=new int[Length];
    for(int i=0;i<t.Length;i++)
    {
    Console.Write("Введите число массива и нажмите клавишу Enter: ");
    string? s=Console.ReadLine();
    t[i]=Convert.ToInt32(s);
    }
}

void Print(int[] t, string variableName)// вывод массива
{
    for(int i=0;i<t.Length;i++)
    Console.Write($"{variableName}[{i}]={t[i]} ");
}

void MoreThenZero (int pos=0)//расчет и вывод количества элементов массива больше нуля
{
    for(int i=0;i<t.Length;i++)
        {
        if(t[i]>0)
        pos=pos+1;
        }
    Console.WriteLine();    
    Console.WriteLine($"{pos} элемента(ов) массива больше нуля");    
}