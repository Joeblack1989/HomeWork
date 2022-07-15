//Task_30
//Написать программу вычисления произведения чисел от 1 до N
//не работает

int a=1;
Console.Write("Введите значение переменной N и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
int N=Convert.ToInt32(s);
if (a > N)
    {
    Console.WriteLine("Ошибка! Необходимо ввести переменную > 1"); 
    }
else
    {          
    int i, sum = 0;
    for (i = a; N >= i; i++)
    sum = i*N;
    Console.WriteLine($"произведение чисел равно: {sum}");
    }