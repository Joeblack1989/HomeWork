//Task_071*
//Написать программу вычисления функции Аккермана


int Akker(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n ==0)
        return Akker (m-1,1);
    if (m > 0 && n > 0)
        return Akker (m-1, Akker(m,n-1));
    else return 0;

}
Console.WriteLine(Akker(3,1));

