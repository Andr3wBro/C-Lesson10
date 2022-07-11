// Заполните спирально квадратный массив по возрастанию, с заданным размером.
// Получилось сделать пересмотрев кучу всего, много идей повзаимтвоавал . Сам бы сидел очень долго думаю.

int[,] array = new int[4, 4];
void SpiralFill(int[,] array)
{
    int rowValue = array.GetLength(0);
    int colValue = array.GetLength(1);
    int val = 1;
    for (int y = 0; y < colValue; y++)
    {
        array[0,y] = val;
        val++;
    }
    for (int x = 1; x < rowValue; x++)
    {
        array[x,colValue - 1] = val;
        val++;
    }
    for (int y = colValue - 2; y >= 0; y--)
    {
        array[rowValue - 1,y] = val;
        val++;
    }
    for (int x = rowValue - 2; x > 0; x--)
    {
        array[x,0] = val;
        val++;
    }
    int insideRow = 1;
    int insideCol = 1;
    while (val < rowValue * colValue)
    {
        while (array[insideRow,insideCol + 1] == 0)
        {
            array[insideRow,insideCol] = val;
            val++;
            insideCol++;
        }
        while (array[insideRow + 1,insideCol] == 0)
        {
            array[insideRow,insideCol] = val;
            val++;
            insideRow++;
        }
        while (array[insideRow,insideCol - 1] == 0)
        {
            array[insideRow,insideCol] = val;
            val++;
            insideCol--;
        }
        while (array[insideRow - 1,insideCol] == 0)
        {
            array[insideRow,insideCol] = val;
            val++;
            insideRow--;
        }
    }
    for (int x = 0; x < rowValue; x++)
    {
        for (int y = 0; y < colValue; y++)
        {
            if (array[x,y] == 0)
            {
                array[x,y] = val;
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(array);
SpiralFill(array);
PrintArray(array);