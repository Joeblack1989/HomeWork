//Task_12
//С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a;
Console.Write("Введите число в диапазоне [10,99] и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a<10 || a>99)
{
Console.WriteLine("Я же просил число от 10 до 99...Попробуй еще раз");
}
else
{
int b=a/10;
int c=a%10;
    if(b>c)
        {
        Console.WriteLine($"{b}");
        }
    else
        {
        Console.WriteLine($"{c}");
        }
}
    