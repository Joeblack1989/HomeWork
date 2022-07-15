//Task_26
//Найти сумму чисел от 1 до А

int a=1;
Console.Write("Введите значение переменной A и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
int b=Convert.ToInt32(s);
if (a > b)
    {
    Console.WriteLine("Ошибка! Необходимо ввести переменную > 1"); 
    }
else{          
    int i, sum = 0;
    for (i = a; b >= i; i++)
    sum += i;
    Console.WriteLine("Сумма чисел равна: " + sum);
}