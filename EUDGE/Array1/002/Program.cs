using System;//подключаем пространство имен 
int n=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
for(int i=0;i<a.Length;i++)
    if(a[i] % 2!= 0)
    System.Console.Write($"{a[i]} ");

for(int j=0;j<a.Length;j++)   
    if (a[j] % 2== 0)
System.Console.Write($"{a[j]} ");
