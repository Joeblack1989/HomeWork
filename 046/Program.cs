//Task_46
//Показать числа Фибоначчи

Fibonachi ();

void Fibonachi (int a=1)
{
    Console.Write("Введите конец диапазона чисел Фибоначчи и нажмите клавишу Enter: ");
    string? s=Console.ReadLine();
    int end=Convert.ToInt32(s);
    for(int i=1; i<=end; i+=a) 
    {
    Console.Write("{0} ", i);
    a=i-a;
    }
}