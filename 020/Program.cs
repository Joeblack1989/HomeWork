//Task_20
//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Solution (0,0);

void Solution (double x, double y)
{
    {
    Console.WriteLine("Введите значение x: ");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение y: ");
    y = Convert.ToDouble(Console.ReadLine()); 
    }
        if (x == 0 || y == 0)
        {
        Console.WriteLine("Введенные Вами параметры недопустимы, X и Y не должны быть равны 0"); 
        }
            if (x > 0 && y > 0)
                Console.WriteLine("Заданная точка находится в первой четверти плоскости");
            if (x > 0 && y < 0)
                Console.WriteLine("Заданная точка находится в четвертой четверти плоскости");
            if (x < 0 && y > 0)
                Console.WriteLine("Заданная точка находится во второй четверти плоскости");
            if (x < 0 && y < 0)
                Console.WriteLine("Заданная точка находится в третьей четверти плоскости");
}
