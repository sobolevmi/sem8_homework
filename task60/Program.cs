// Создать трехмерный массив из неповторяющихся двухзначных чисел и вывести его элементы на экран с добавлением индексов
int[,,] CreateRandomArray(int [,,] randomArray)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int index = 0; index < 2; index++)
            {
                randomArray[i, j, index] = new Random().Next(10, 100);
            }
        }
    }
    for (int k = 0; k < 2; k++)
    {
        for (int p = 0; p < 2; p++)
        {
            for (int l = 0; l < 2; l++)
            {
                if (randomArray [k, p, l] == randomArray [randomArray.GetLength (0) - 1 - k, randomArray.GetLength (1) - 1 - p, randomArray.GetLength (2) - 1 - l])
                {
                    randomArray [k, p, l] = -randomArray [k, p, l];
                }
            }
        }
    }
    return randomArray;
}

void ShowArray (int [,,] userArray)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int index = 0; index < 2; index++)
            {
                Console.Write ($"{userArray [i, j, index]} ({i},{j},{index})  ");
            }
        }
        Console.WriteLine ();
    }
}

int [,,] array = new int[2, 2, 2];
int [,,] newArray = CreateRandomArray (array);
ShowArray (newArray);