//task_56
//Задайте прямоугольный двумерный массив. Напишите програму, которая будет находить строку с наименьшей суммой элементов.
//Например: 
//1 4 7 2
//5 9 2 3 
//8 4 2 4
//5 2 6 7 
//Должно получиться:
// 1 строка

int n=0,m=0;
Init(out n,out m);
if (n==m)// пофиксить
    {
        Console.WriteLine("Ошибка! Необходим прямоугольный массив! Попробуйте еще раз...");
        return;
    }
int [,] a = new int [n,m];
FillArray (a);
Console.WriteLine("Сформированный массив: ");
PrintArray (a);
Console.WriteLine("Ответ: " );
FindMinLine(a);



void Init (out int n, out int m)//подпрограмма инициализации
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

void PrintArray (int [,]a)//подпрограмма вывода массива на экран
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

void FindMinLine(int [,]a)//подпрограмма поиска строки массива с наименьшей суммой элементов.
{
    int MinLine = 0;
    int MinNumber = a [MinLine,0];
    for(int i = 0;i < a.GetLength(0);i++)
    {
        for(int j = 0;j < a.GetLength(1);j++)
        {
            if (a [i, j] < MinNumber)
            {
                MinNumber = a [i, j];
                MinLine = i;
            }
        }
    }
    Console.WriteLine($"{MinLine} строка " );
}