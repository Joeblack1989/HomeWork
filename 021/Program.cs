//Task_21
// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите четверть двумерной плоскости и нажмите Enter: ");
string? s = Console.ReadLine();
int NumberQuarter = Convert.ToInt32(s);
string range = " ";
if (NumberQuarter == 1)
{
    range = "x > 0, y > 0";
}
    else if (NumberQuarter == 2)
    {
        range = "x < 0, y > ";
    }
        else if (NumberQuarter == 3)
        {
            range = "x < 0, y < 0";
        }
            else range = "x > 0, y < 0";

Console.WriteLine($"Для {NumberQuarter}-й четверти координаты точки должны быть заданы в диапазоне ( {range} )");
