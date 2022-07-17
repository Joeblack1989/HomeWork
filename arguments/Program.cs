/*int a,b;
a=1;
b=2;
Console.WriteLine($"{a} {b}");
int t=a;
a=b;
b=t;
Console.WriteLine($"{a} {b}");*/

void Swap(int a,int b)
{
int t=a;
a=b;
b=t;
}
int a,b;
a=1;
b=2;
Console.WriteLine($"{a} {b}");
Swap(a,b);
Console.WriteLine($"{a} {b}");

/*Защита от дурака
string s;
int n;
bool f;
do
{
s=Console.ReadLine();
f=int.TryParse(s,out n);
if (f==false) System.Console.WriteLine("Wrong input!");
}
while(f==false);
System.Console.WriteLine(n);*/