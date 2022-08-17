//Task_54
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
//Например: 
//1 4 7 2
//5 9 2 3 
//8 4 2 4
//Должно получиться:
//1 2 4 7
//2 3 5 9
//2 4 4 8 
int n=0,m=0;
Init(out n,out m);
int [,] a = new int [n,m];
FillArray (a);
Console.WriteLine("Массив до изменения: ");
PrintArray (a);
Console.WriteLine("Массив после изменения: ");
Sort(a);
PrintArray (a);



void Init (out int n, out int m)//подпрограмма инициализации двумерного массива
{
    Console.WriteLine("Введите количество строк двумерного массива и нажмите Enter:");
    string? s=Console.ReadLine();
    n = Convert.ToInt32(s);
    Console.WriteLine("Введите количество столбцов двумерного массива и нажмите Enter:");
    s=Console.ReadLine();
    m = Convert.ToInt32(s);
}    

void FillArray (int [,]a)//подпрограмма заполнения двумерного массива случайными числами
{
Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=random.Next(1,11);  
        }
    } 
}

void PrintArray (int [,]a) //подпрограмма вывода массива на экран
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j]} " );  
        }
    Console.WriteLine();
    } 
}

void Sort(int [,]a)//подпрограмма, которая упорядочивает по убыванию элементы каждой 
//строки двумерного массива.
{
int temp;    
    for(int i = 0; i<a.GetLength(0);i++)
    {
        for(int j = 0; j<a.GetLength(1);j++)
        {
            for (int k = j + 1; k < a.GetLength(1); k++)
            {
                if (a [i,j] > a [i,k])
                {
                    temp = a [i,j];
                    a [i,j] = a [i,k];
                    a [i,k] = temp;
                }
            }
        }
    } 
}
