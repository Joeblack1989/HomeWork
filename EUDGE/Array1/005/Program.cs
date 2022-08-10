/*Вводится число N, а затем - N чисел.
Определить, сколько среди них пар одинаковых чисел, стоящих рядом.
100>=N>=2
Пример входного файла:
5
1 3 2 2 3

Пример выходного файла:
1

Пример входного файла:
4
1 1 1 1
Пример выходного файла:
3
*/

using System;

int n=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
int result = 0;
for(int i = 0; i< a.Length - 1; i++)
{
    if (a[i]==a[i+1])
    result++;
}
Console.Write(result);

/*
for (int i = 0; i < a.Length / 2; i++)
{
   int tmp = a[i];
   a[i] = a[a.Length - i - 1];
   a[a.Length - i - 1] = tmp;
}
for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + " " );
}
*/