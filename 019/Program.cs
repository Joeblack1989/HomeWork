/*Task_19
Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
!(X || Y)==!X and !Y*/

int N=5;
Console.WriteLine($"N={N}");
bool x,y,f1,f2;
x=true;
y=true;
f1=!(x || y);
f2=!x && !y;
Console.WriteLine($"{x} {y} {f1} {f2}");