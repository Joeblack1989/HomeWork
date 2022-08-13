//Task_41A
// Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.

//создаем и заполняем двумерный массив
int[,] a = new int[4, 4];
FillArray (a);
//Выводим массив на экран
PrintArray (a);
//проверяем на симметричность
CheckSymmetry (a);

//методы
void FillArray(int[,]a)
{
Random random=new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j]= random.Next(0,2);
        }
    }
}

void PrintArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
            System.Console.WriteLine();
    }
}

void CheckSymmetry(int[,] a)
{
    bool symmetry = true;
        for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++) 
                {
                    if (a[i, j] != a[j, i])
                    { 
                        symmetry = false;
                    }
                }
            }
    if (symmetry) 
        Console.WriteLine("Созданная матрица симметрична");
    else
        Console.WriteLine("Созданная матрица не симметрична"); 
}