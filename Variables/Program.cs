//.NET
// Значимые типы (value types)
int a;
double d;
a=3;
// ссылочные типы (reference types)
string s;
s="Hello";
string s1;
s1=s;//копирует,ссылка на одно и тоже
int[] arr;
arr=new int[50];
arr[0]=1;
int[]arr2;
arr2=arr;//ссылка на одно и тоже
arr2[0]=2;

Console.WriteLine();
