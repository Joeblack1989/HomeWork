//Task_1
//С клавиатуры вводится целое число. Вывести квадрат числа 

Double a;
Double b;
Console.Write("Введите число, которое необходимо возвести в квадрат и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
b=a*a;
Console.WriteLine($"Квадрат введеного числа равен {b} "); 

//Console.WriteLine("{0}^2={1}",a,b); //строка форматирования
//Console.WriteLine($"{a}^2={b}"); //строка интерполяции

/*Материалы урока
Console.WriteLine("Hello, World!");
System.Console.WriteLine(11%2);

int MaxFromToNumbers=0;
double d=3.14;
System.Console.WriteLine(int.MaxValue);
Console.WriteLine(double.MaxValue);
string s="Hello"+"asd"; //конскатенация строк (склеивание)
char c='a';
*/



/*Task_2
string? s;//объявили переменную
s=Console.ReadLine();//присвоили

Console.WriteLine(s);
*/

