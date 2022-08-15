//Task_13
//Удалить вторую цифру целого числа введенного с клавиатуры.

/*
//Удаление с конца
Console.WriteLine("Введите необходимое число и нажмите Enter: ");
int n=Convert.ToInt32(Console.ReadLine());
int d0=n%10;
int d1=n/10%10;
int d2=n/100;
int n1=d2*10+d0;
//Console.WriteLine($"{d0}{d1}{d2}");
Console.WriteLine($"{n1}");
*/

//Удаление с начала
Console.WriteLine("Введите необходимое число и нажмите Enter: ");
int n=Convert.ToInt32(Console.ReadLine());
int k=DigitsCount(n);
int n2=n%(int)Math.Pow(10,k-2);
int n3=n/(int)Math.Pow(10,k-1);
int nn=n3*(int)Math.Pow(10,k-2)+n2;
//Console.WriteLine($"{n3}{n2}");
Console.WriteLine(nn);

int DigitsCount(int N)
{
    if (N==0) return 1;
    int k=0;
    while (N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
}