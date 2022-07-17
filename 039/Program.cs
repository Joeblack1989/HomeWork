//task_39
//Найти сумму чисел одномерного массива стоящих на нечетной позиции


/*int N=12;
int[] a=new int [N];
for (int i=0; i<a.Length; i++)
    a[i] =i;
for (int i=0;i<a.Length;i++)
    Console.WriteLine($"{a[i],4}");
*/
//инициализация массива
int N=12;
int[] a=new int [N];
Random random=new Random();//псевдослучайные числа
for (int i=0; i<a.Length; i++)
    a[i] =random.Next(-9,10);

//Вывод массива (до обработки)
for (int i=0;i<a.Length;i++)
    Console.Write($"{a[i],4}");
Console.WriteLine();

//Решение массива
int s=0;
for (int i=1;i<a.Length;i=i+2)
    s=s+a[i];

Console.WriteLine(s); 
