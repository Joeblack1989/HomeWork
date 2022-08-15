/*
//пример рекурсивной функции набраный лично по памяти
void loop(int i, int N)
{
    Console.WriteLine($"{i}");
    if (i<N)
    {
    loop(i+1,N);
    }
}

loop (1,10);
*/

/*
int P(int a, int b)
{
    if (b==0) return 1;
    if (b%2!=0) return P(a,b-1)*a; 
    else  return P(a,b/2)*P(a,b/2);
}

System.Console.WriteLine(P(2,10));
*/
//Задача_1 в группах
//Найти сумму элементов от M до N, N и M заданы
/*
int P(int M, int N)
{
    if (M==N) return M;
    else return P(M+1,N)+ M;
}
System.Console.WriteLine(P(1,10));
*/

//Задача 2 в группах
// 70. Найти сумму цифр числа - 2
/*

int P(int a, int b)
{
    if (b==0) return 1;
    if (b%2!=0) return P(a,b-1)*a; 
    else  return P(a,b/2)*P(a,b/2);
}

System.Console.WriteLine(P(2,10));

        {
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма цифр числа:"+Sum(num));
        }
        static int Sum(int num)
        {
            if (num < 10) return num;
            else return num % 10 + Sum(num / 10);
        }
*/

//Задача 3 в группах
/*
int a=2;
int b=3;

int P(int a, int b)
{
    if (b==0) return 1;
    else return P(a,b-1)*a;
}

System.Console.WriteLine(P(a,b));
*/


/*
int A(int n, int m)
    {
        if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
        if (n == 0) return m + 1;
        if (m == 0) return A(n - 1, m);
        return A(n - 1, A(n, m - 1));
    }
    void Main(string[] args)
    {
        Console.WriteLine(A(2, 5));
        Console.WriteLine(A(1, 2));
    }
*/
/*
int Akk(int m, int n)
{
     if (!m and n)
     return (n+1);
     else
     if (m and !n)
     return Akk(m-1,1);
     return Akk(m-1,Akk(m,n-1));
}

сint Akk(int m, int n){
     if (!m and n)
     return (n+1);
     else
     if (m and !n)
     return Akk(m-1,1);
     return Akk(m-1,Akk(m,n-1));
}
*/
/*
static int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return Ack(m - 1, 1);
            }
            else
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
 
        }
        void button13_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox24.Text);
            int b = int.Parse(textBox25.Text);
            string eee = Ack(a, b).ToString();
            label50.Text = eee;
        }
*/