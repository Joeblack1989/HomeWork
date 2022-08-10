// создать массив NxM и заполнить его случайными числами от 1 до 10. ВЫевести массив

int N=4;
int M=4;

int[,] a;// Описываем массив

a=new int[N,M];// создаем массив
//Инициализация случайными числами
Random random=new Random();//создали объект типа Random

for(int i=0; i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        a[i,j]=random.Next(1,11);
    }
}

for(int i=0; i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
    System.Console.WriteLine();
}

    