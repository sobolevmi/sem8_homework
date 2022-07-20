// Задать двумерный массив и отсортировать элементы по убыванию в каждой строке
int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] randomArray = new int[rows, columns];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return randomArray;
}

void ShowArray(int[,] userArray)
{
    for (int index = 0; index < userArray.GetLength(0); index++)
    {
        for (int k = 0; k < userArray.GetLength(1); k++)
        {
            Console.Write(userArray[index, k] + "  ");
        }
        Console.WriteLine();
    }
}

void SortingElementsInTheArray(int[,] oldArray)
{
    int temp = 0;
    for (int p = 0; p < oldArray.GetLength(0); p++)
    {
        for (int l = 0; l < oldArray.GetLength(1); l++)
        {
            for (int n = 1; n < oldArray.GetLength(1); n++)
            {
                if (oldArray [p, n] > oldArray [p, n - 1])
                {
                    temp = oldArray [p, n - 1];
                    oldArray [p, n - 1] = oldArray [p, n];
                    oldArray [p, n] = temp;
                }
            }
        }
    }
}

Console.Write("Введите количество строк случайно генерируемого массива: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов случайно генерируемого массива: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число диапазона чисел, генерируемых в массив: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число диапазона чисел, генерируемых в массив: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandomArray(userRows, userColumns, startNumber, endNumber);
ShowArray(array);
Console.WriteLine("-----------------");
SortingElementsInTheArray(array);
ShowArray (array);