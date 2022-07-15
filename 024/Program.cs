//Task_24
//Вывести на экран таблицу квадратов чисел от 1 до N

Console.Write("Введите значение число N и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
int N=Convert.ToInt32(s);
Console.WriteLine("Число N" +"\t" + "Квадрат числа N");
for(int i = 1; i <= N; i++)
Console.WriteLine(i + "\t" + i*i);