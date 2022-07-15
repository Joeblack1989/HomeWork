//Task_28
//Определить количество цифр в числе. Сделать подпрограмму

/*int N=1265;
int k=0;
while (N!=0)
{
    k++;
    N=N/10;
}
Console.WriteLine(k);
*/

int N;
Console.Write("Введите первое число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
N=Convert.ToInt32(s);
int CountDigits(int N)
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
Console.WriteLine($"Количество цифр в веденом числе: {CountDigits(N)}");
