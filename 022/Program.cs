//Task_22
//Программа проверяет пятизначное число на палиндромом.

//Solution ();

/*Console.Write("Введите пятизначное число и нажмите клавишу Enter: ");
int x = Convert.ToInt32(Console.ReadLine());
int k=DigitsCount(n);
int N=1;
    if (N==0) return 1;
    int k=0;
    while (N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
Console.Write ("количество цифр в введеном числе равно ");  
*/
/*void Solution (int number=0)
{
       
            if (x > 0 && y > 0)
                Console.WriteLine("Заданная точка находится в первой четверти плоскости");
            if (x > 0 && y < 0)
                Console.WriteLine("Заданная точка находится в четвертой четверти плоскости");
            if (x < 0 && y > 0)
                Console.WriteLine("Заданная точка находится во второй четверти плоскости");
            if (x < 0 && y < 0)
                Console.WriteLine("Заданная точка находится в третьей четверти плоскости");
}
*/

Console.Write("Введите пятизначное число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
int N=Convert.ToInt32(s);
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
    Console.WriteLine($"Количество цифр в введеном числе: {k}");
}
if (N!=5) 
    {Console.WriteLine ("Вводимое число должно состоять из пяти цифр, попробуй еще раз" );}    
    



//static bool IsPalindrome(string s)

