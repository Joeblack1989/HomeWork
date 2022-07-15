//Task_7
//Выяснить является ли число чётным.

int a;
Console.Write("Введите число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a%2==0)
{
   Console.WriteLine($"Чиcло {a} является четным"); 
}
else
{
    Console.WriteLine($"Чиcло {a} является нечетным");
}