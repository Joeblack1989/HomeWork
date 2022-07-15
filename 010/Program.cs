//Task_10
//Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int a;
Console.Write("Введите число и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a%10;
Console.WriteLine($"Последняя цифра введеного числа: {b}");
