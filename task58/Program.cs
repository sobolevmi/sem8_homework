// Задать две матрицы и найти их произведение
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

int [,] MultiplicationOfMatrix (int [,] userArray1, int [,] userArray2)
{
    int [,] newArray = new int [userArray1.GetLength (0), userArray2.GetLength (1)];
    for (int i = 0; i < userArray1.GetLength (0); i++)
    {
        for (int j = 0; j < userArray2.GetLength (1); j++)
        {
            for (int n = 0; n < userArray1.GetLength (0); n++)
            {
                newArray [i, j] += userArray1 [i, n] * userArray2 [n, j];
            }
        }
    }
    return newArray;
}

Console.Write("Введите количество строк первого случайно генерируемого массива: ");
int userRows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого случайно генерируемого массива: ");
int userColumns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число диапазона чисел, генерируемых в массив: ");
int startNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число диапазона чисел, генерируемых в массив: ");
int endNumber1 = Convert.ToInt32(Console.ReadLine());
int[,] arrayRandom1 = CreateRandomArray(userRows1, userColumns1, startNumber1, endNumber1);
ShowArray(arrayRandom1);
Console.WriteLine ("------------------");
Console.Write("Введите количество строк второго случайно генерируемого массива: ");
int userRows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго случайно генерируемого массива: ");
int userColumns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число диапазона чисел, генерируемых в массив: ");
int startNumber2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число диапазона чисел, генерируемых в массив: ");
int endNumber2 = Convert.ToInt32(Console.ReadLine());
int [,] arrayRandom2 = CreateRandomArray (userRows2, userColumns2, startNumber2, endNumber2);
ShowArray (arrayRandom2);
Console.WriteLine ("------------------");
if (userColumns1 == userRows2) 
{
    int [,] resultMultiplication = MultiplicationOfMatrix (arrayRandom1, arrayRandom2);
    Console.WriteLine ("Произведение двух матриц:");
    ShowArray (resultMultiplication);
}
else Console.WriteLine ("Получить произведение данных матриц невозможно");