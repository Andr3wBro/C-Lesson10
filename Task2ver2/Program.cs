// Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, желательно использовать recuration:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"
// Без использование рекурсии, но останавливается как в примере на 12 символе.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void MonotonousSequence(int n)
{
    if (n == 0) return;

    for (int i = 0, startNumber = 1, temp = startNumber; i < n; i++)
    {
        Console.Write(startNumber + " "); ;
        if (--temp == 0)
        {
            temp = ++startNumber;
        }
    }
}

int n = Prompt("Введите n =>");
MonotonousSequence(n);