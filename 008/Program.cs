//Task_8
//Вывести на экран числа от -N до N

int N1,N2;
Console.Write("Введите начальное число числового ряда и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
N1=Convert.ToInt32(s);
Console.Write("Введите конечное число числового ряда и нажмите клавишу Enter: ");
s=Console.ReadLine();
N2=Convert.ToInt32(s);
int i=N1;
while (i>=N1 && i<=N2)
{
    Console.Write($"{i}");
    i++;
}