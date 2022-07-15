//Task_29
//Подсчитать сумму цифр в числе

Console.Write("Введите число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
int a=Convert.ToInt32(s);
int b=0;
while (a > 0)
    {
    b = b + a % 10;
    a = a /10 ;
    }
 Console.WriteLine(b);