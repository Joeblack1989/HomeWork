//Task_017
//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int a;
Console.Write("Введите порядковый номер дня недели и нажмите клавишу Enter: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if(a<1 || a>7){Console.WriteLine("В неделе семь дней, балбес. Попробуй еще раз.");}
else
    if(a==6 || a==7)
    {
    Console.WriteLine("Указанный день недели - выходной");
    }
    else 
    {
    Console.WriteLine("Указанный день недели - рабочий");
    }