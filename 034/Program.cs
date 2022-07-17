//Task_34
//Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

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

//Вывод массива
for (int i=0;i<a.Length;i++)
    Console.Write($"{a[i],4}");

//Решение массива
int sumPositive=0;
for (int i=0;i<a.Length;i++)
    if (a[i]>0)
        sumPositive=sumPositive+a[i];
        Console.WriteLine();
int sumNegative=0;
for (int i=0;i<a.Length;i++)
    if (a[i]<0)
        sumNegative=sumNegative+a[i];

//Вывд результатов
Console.WriteLine(sumNegative);
Console.WriteLine(sumPositive);