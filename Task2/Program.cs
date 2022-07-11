// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    if ((n != 0) && (m == 0))
        return Akerman(n - 1, 1);
    else
        return Akerman(n - 1, Akerman(n, m - 1));
}

int M = Prompt("Enter M => ");
int N = Prompt("Enter N => ");
Console.Write(Akerman(M,N));