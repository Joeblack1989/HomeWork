//Task_42A
/*
Даны две квадратных таблицы чисел. Требуется построить третью,каждый элемент которой равен сумме элементов,
стоящих на том же месте в 1-й и 2-й таблицах.
Входные данные:
Во входном файле записано сначала число N, затем записана первая таблица,
а после нее - вторая. Элементы таблиц - числа от 0 до 100.
100>=N>=1.
*/

// создаем матрицу
int N;
int M;
Console.Write("Введите размер квадратной матрицы и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
N=M=Convert.ToInt32(s);
Console.WriteLine();
//инициализируем и заполняем первую матрицу случайными числами
int [,] a1 = new int[N,M];
FillArray (a1);
Console.WriteLine ("Первая матрица: ");
PrintArray (a1);
Console.WriteLine();
//инициализируем и заполняем вторую матрицу случайными числами
int [,] a2 = new int[N,M];
FillArray (a2);
Console.WriteLine ("Вторая матрица: ");
PrintArray (a2);
Console.WriteLine();
//инициализируем и строим третью матрицу
int [,] a3 = new int[N,M];
SumArray12 (a3);
Console.WriteLine ("Третья матрица: ");
PrintArray (a3);
Console.WriteLine();



//Заполнение массива случайными числами
void FillArray(int[,]a)
{
Random random=new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j]= random.Next(1,101);
        }
    }
}

//Вывод массива на экран
void PrintArray(int[,]a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

//суммируем элементы первой и второй матрицы в третью
void SumArray12(int[,]a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j]=a1[i,j]+a2[i,j];
        }
    }
}