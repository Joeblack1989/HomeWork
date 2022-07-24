//Task_30
//Написать программу вычисления произведения чисел от 1 до N

int [] a;
array (out a);
Print(a, "a");

/*void array (out int[] a) // заполняем массив
{
    Console.Write("Введите значение длины массива и нажмите клавишу Enter: ");
    string? s=Console.ReadLine();
    int N=Convert.ToInt32(s);
    for (int i=0; i<N; i++)
    a[i] = i+1
}*/    
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
    
    
    ;
*/    
int Factorial(int n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}
 
int factorial4 = Factorial(4);  // 24
int factorial5 = Factorial(5);  // 120
int factorial6 = Factorial(6);  // 720
 
Console.WriteLine($"Факториал числа 4 = {factorial4}");
Console.WriteLine($"Факториал числа 5 = {factorial5}");
Console.WriteLine($"Факториал числа 6 = {factorial6}");

    /*if (1<N)
    {
    //sum = a[i]*a[i+1];
    }
    if (1 > N)
    {
    Console.WriteLine("Ошибка! Необходимо ввести переменную > 1"); 
    }
    Console.Write($"{sum} ");*/
/*
void Print(int[] a, string variableName)// вывод массива
{
    for(int i=0;i<a.Length;i++)
    Console.Write($"{variableName}[{i}]={a[i]} ");
}
*/

/*int a=1;
Console.Write("Введите значение переменной N и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
int N=Convert.ToInt32(s);
if 
else
    {          
    int i, sum = 0;
    for (i = 0; N >= i; i++)
    
    Console.WriteLine($"произведение чисел до равно: {sum}");
    }*/