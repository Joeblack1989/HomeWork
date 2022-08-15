//Task_14
// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, 
// если нет, вывести остаток от деления a на b
int a=0;
int b=0;
int result=0;
Solution (a,b,result);


void Solution (int a,int b, int result)
{
    Console.WriteLine("Введите число и нажмите Enter: ");
    string? s = Console.ReadLine(); 
    a = Convert.ToInt32(s);
    Console.WriteLine("Введите число b и нажмите Enter: ");
    s = Console.ReadLine(); 
    b = Convert.ToInt32(s);
    result = a % b;
        if (result == 0) Console.WriteLine($"Число {a} кратно числу {b}");
        else
        {
            Console.WriteLine($"Число {a} не кратно числу {b}, остаток от деления равен {a % b}");
        }
}