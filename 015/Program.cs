//Task_15
// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

Console.WriteLine("Введите целое число и нажмите Enter: ");
string? s = Console.ReadLine();
int Number = Convert.ToInt32(s);
    if (Number / 100 > 0)
    {
    Console.WriteLine($"Третьей цифрой введенного числа является цифра {Number / 100 % 10}");    
    } 
    else Console.WriteLine($"У введенного числа нет третьей цифры");