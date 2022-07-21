//Task_33
//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


int[] t; 
ZeroOne (0,1,8);
Print(t, "t");

void ZeroOne(int number1, int number2, int Length)
{
    t=new int[Length];
    for(int i=0;i<t.Length;i++)
        if (i%2==0)
        {
        t[i] = number1;
        }
        else 
        {
        t[i] = number2;
        }  
}

void Print(int[] t, string variableName)
{
    for(int i=0;i<t.Length;i++)
    Console.Write($"{variableName}[{i}]={t[i]} ");
}

