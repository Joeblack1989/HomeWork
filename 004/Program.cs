//Task_4
//По заданному с клавиатуры номеру дня недели вывести его название

string[] days_of_week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int[] days = new int[6];
int a;
Console.Write("Введите порядковый номер дня недели и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if(a<1 || a>7){Console.WriteLine("В неделе семь дней, балбес. Попробуй еще раз.");}
else
    if(a==1){Console.WriteLine(days_of_week[0]);}
    if(a==2){Console.WriteLine(days_of_week[1]);}
    if(a==3){Console.WriteLine(days_of_week[2]);}
    if(a==4){Console.WriteLine(days_of_week[3]);}
    if(a==5){Console.WriteLine(days_of_week[4]);}
    if(a==6){Console.WriteLine(days_of_week[5]);}
    if(a==7){Console.WriteLine(days_of_week[6]);}