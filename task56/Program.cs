// Задать прямоугольный массив, высчитать сумму элементов каждой строки и вывести номер строки с наименьшей суммой элементов на экран
int[,] CreateRandomArray (int rows, int columns, int minValue, int maxValue)
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

void ShowArray (int[,] userArray)
{
    for (int index = 0; index < userArray.GetLength(0); index++)
    {
        for (int k = 0; k < userArray.GetLength(1); k++)
        {
            Console.Write (userArray[index, k] + "  ");
        }
        Console.WriteLine();
    }
}

void SumOfElementsInTheRow (int [,] anyArray)
{
    int [] newArray = new int [anyArray.GetLength (0)];
    for (int i = 0; i < anyArray.GetLength (0); i++)
    {
        int sum = 0;
        for (int index = 0; index < anyArray.GetLength (1); index++)
        {
            sum = sum + anyArray [i, index];
        }
        newArray [i] = sum;
    }
    int min = newArray [0];
    int minIndex = 0;
    Console.WriteLine (newArray [0]);
    for (int p = 1; p < newArray.Length; p++)
    {
        Console.WriteLine (newArray [p]);
        if (newArray [p] < min)
        {
            min = newArray [p];
            minIndex = p;
        }
    }
    Console.WriteLine("-----------------");
    Console.Write ($"{minIndex} строка: {min}");
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
SumOfElementsInTheRow (array);