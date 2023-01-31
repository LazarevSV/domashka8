//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*

    int[,] CreateRandom2dArray()
    {
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
    }

    void Show2dArray(int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
    }


void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

    for (int j = 0; j < array.GetLength(1); j++)

    for (int k = 0; k < array.GetLength(1) - 1; k++)

    if (array[i, k] < array[i, k + 1])
    {
    int temp = array[i, k + 1];
    array[i, k + 1] = array[i, k];
    array[i, k] = temp;
        }
    }


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
        
SortToLower(myArray);
Console.WriteLine();
Show2dArray(myArray);

*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элем


/*
int[,] CreateRandom2dArray()
    {
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
    }

    void Show2dArray(int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
    }


void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
        




Console.WriteLine();
NumberRowMinSumElements(myArray);


*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


/*
    int[,] CreateRandom2dArray()
    {
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
    }

    void Show2dArray(int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
    }


int[,] ArrayMultiplication(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                    result[i, j] += array1[i, k] * array2[k, j];
            }
    }
    return result;
}


int [,] array1 = CreateRandom2dArray();
int [,] array2 = CreateRandom2dArray();

Show2dArray(array1);
Show2dArray(array2);


Show2dArray(ArrayMultiplication(array1, array2));


*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



void CreateRandom3dArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}


int[,,] array3D = new int[2, 2, 2];

void Show3dArray(int[,,] arr)


{

    
    for (int i = 0; i < array3D.GetLength(0); i++)
    
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            
        }
    }




CreateRandom3dArray(array3D);
Show3dArray(array3D);

