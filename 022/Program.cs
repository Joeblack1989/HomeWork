//Task_22
//Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
int N=Convert.ToInt32(s);
check (N);
if (s.Reverse().SequenceEqual(s))
{
    Console.WriteLine("Введенное число является палиндромом!");
}
else 
{
    Console.WriteLine("Введенное число не является палиндромом!");
}

void check (int N)
{
    int k=0;
    while (k!=0)
    {
        N
    }


    if (N.lenght!=5) 
    {
        Console.WriteLine ("Вводимое число должно состоять из пяти цифр, попробуй еще раз" );
    }  
}