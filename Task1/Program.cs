// Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"
// С использованием рекурсии подучилоьс только так ()

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void MonotonousSequence(int n, int startNumber = 1)
{
    if (n == 0) return;
    for(int i= 0; i<startNumber; i++)
    {
        Console.Write(startNumber + " "); ;
    }
    MonotonousSequence(n - 1, startNumber+1);
}

int n = Prompt("Введите n =>");
MonotonousSequence(n);
