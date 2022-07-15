//Task_16
// Дано число. Проверить  кратно ли оно 7 и 23

bool b,c,d;
int x=24*7;
b=x%7==0;// Х кратно 7 //простое условие
c=x%23==0;// С кратно 23
d=b && c;//Д истина если Б и Ц истина // сложное условие
Console.WriteLine(x);
Console.WriteLine($"Число кратно 7 - {b}");
Console.WriteLine($"Число кратно 23 - {c}");
//Console.WriteLine(d);


/* Записи с урока
bool b;
b=true;//1
b=false;//0
b=2*2!=5;//>,<,<=,>=,==,!= 
int x=14;
b=x%7==0;
Console.WriteLine(b);
*/