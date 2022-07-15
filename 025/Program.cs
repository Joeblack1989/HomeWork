//Task_25
//Вывести на экран кубы чисел от 1 до N

Console.Write("Введите значение число N и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
int N=Convert.ToInt32(s);
Console.WriteLine("Число N" +"\t" + "Куб числа N");
for(int i = 1; i <= N; i++)
Console.WriteLine(i + "\t" + i*i*i);