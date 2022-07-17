//Task_36
//Определить, присутствует ли в заданном массиве, некоторое число

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

//Решение массива
int f=400;
//a[3]=f;
//Вывод массива
for (int i=0;i<a.Length;i++)
    Console.Write($"{a[i],4}");
Console.WriteLine();

//Линейный поиск
int j=0;
while (j<a.Length && a[j]!=f) j++;
if (j==a.Length) Console.WriteLine("Not fFound");
else Console.WriteLine($"Element {f} founded at {j}"); 
