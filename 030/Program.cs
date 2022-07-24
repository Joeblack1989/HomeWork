//Task_30
//Написать программу вычисления произведения чисел от 1 до N

Factorial ();

void Factorial (int F=1)
{
    Console.Write("Введите число, факториал которого вас интересует, и нажмите клавишу Enter: ");
    string? s=Console.ReadLine();
    int N=Convert.ToInt32(s);
    if (N <= 1)
    {
    Console.Write("Ошибка! Введенное число, должно быть > 1 ");
    return;
    }
    else 
    for(int i=1;i <= N;i++)
    {
    F = F * i;
    }   
    Console.WriteLine($"Факториал числа {N} = {F}"); 
}