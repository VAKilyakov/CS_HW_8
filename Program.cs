/* Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/* Решение 1
int InputInteNum(string message) //ввод целочисленных чисел
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray2D (int Length, int Height) //ввод двумерного массива
{
    int[,] Array2D = new int[Height,Length];
    for (int i=0; i < Height; i++)
    {
        for (int j=0; j<Length; j++)
        {
            Array2D[i,j] = InputInteNum("Введите значение массива с индексом [" + i + "," + j + "]");
        }
    }
    return Array2D;
}

int[,] SortArray2D(int[,] Array2D)
{
    for(int i=0;i<Array2D.GetLength(0);i++)
    {
        for(int j=0;j<Array2D.GetLength(1);j++)
        {
            for(int k=0;k<Array2D.GetLength(1)-1;k++)
            {
                if(Array2D[i,k]<Array2D[i,k+1])
                {
                    int temp = Array2D[i,k+1];
                    Array2D[i,k+1] = Array2D[i,k];
                    Array2D[i,k] = temp;
                }
            }
        }
    }
    return Array2D;
}

void PrintArray2D(int[,] Array2D)
{
    Console.Write("Сортированный массив:" + Environment.NewLine);

    for(int i=0;i<Array2D.GetLength(0);i++)
    {
        for(int j=0;j<Array2D.GetLength(1);j++)
        {
            Console.Write(Array2D[i,j] + " ");
        }
        Console.Write(Environment.NewLine);
    }
}

int Height = InputInteNum("Введите количество строк в массиве");
int Length = InputInteNum("Введите количество столбцов в массиве");
int[,] Array2D = CreateArray2D(Length,Height);
Array2D = SortArray2D(Array2D);
PrintArray2D(Array2D);
*/

/* Тест 1
PS D:\Home_Works\CS_HW_8> dotnet run
Введите количество строк в массиве 3
Введите количество столбцов в массиве 4
Введите значение массива с индексом [0,0] 1
Введите значение массива с индексом [0,1] 4
Введите значение массива с индексом [0,2] 7
Введите значение массива с индексом [0,3] 2
Введите значение массива с индексом [1,0] 5
Введите значение массива с индексом [1,1] 9
Введите значение массива с индексом [1,2] 2
Введите значение массива с индексом [1,3] 3
Введите значение массива с индексом [2,0] 8
Введите значение массива с индексом [2,1] 4
Введите значение массива с индексом [2,2] 2
Введите значение массива с индексом [2,3] 4
Сортированный массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/* Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/* Решение 2
int InputInteNum(string message) //ввод целочисленных чисел
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray2D (int Length, int Height) //ввод двумерного массива
{
    int[,] Array2D = new int[Height,Length];
    for (int i=0; i < Height; i++)
    {
        for (int j=0; j<Length; j++)
        {
            Array2D[i,j] = InputInteNum("Введите значение массива с индексом [" + i + "," + j + "]");
        }
    }
    return Array2D;
}

int[] SumNumRow (int[,] Array2D)
{
    int[] Array1D = new int[Array2D.GetLength(1)];
    for (int i=0; i < Array2D.GetLength(0); i++) 
    {
        int NumSum = 0;
        for (int j=0; j<Array2D.GetLength(1); j++) 
        {
            NumSum += Array2D[i,j];
        }
        Array1D[i] =  NumSum;
    }
    return Array1D;
}

void PrintResult(int[] Array1D)
{
    int MinSumRow = Array1D[0];
    int IndexRow = 0;
    for(int i=1; i < Array1D.Length; i++)
    {
        if(MinSumRow>Array1D[i])
        {
            MinSumRow = Array1D[i];
            IndexRow = i;
        }
    }
    Console.Write("Строка с минимальным значением - " + (IndexRow+1));
}

int Height = InputInteNum("Введите количество строк в массиве");
int Length = InputInteNum("Введите количество столбцов в массиве");
int[,] Array2D = CreateArray2D(Length,Height);
int[] Array1D = SumNumRow(Array2D);
PrintResult(Array1D);
*/

/* Тест 2
PS D:\Home_Works\CS_HW_8> dotnet run
Введите количество строк в массиве 4
Введите количество столбцов в массиве 4
Введите значение массива с индексом [0,0] 1
Введите значение массива с индексом [0,1] 4
Введите значение массива с индексом [0,2] 7
Введите значение массива с индексом [0,3] 2
Введите значение массива с индексом [1,0] 5
Введите значение массива с индексом [1,1] 9
Введите значение массива с индексом [1,2] 2
Введите значение массива с индексом [1,3] 3
Введите значение массива с индексом [2,0] 8
Введите значение массива с индексом [2,1] 4
Введите значение массива с индексом [2,2] 2
Введите значение массива с индексом [2,3] 4
Введите значение массива с индексом [3,0] 5
Введите значение массива с индексом [3,1] 2
Введите значение массива с индексом [3,2] 6
Введите значение массива с индексом [3,3] 7
Строка с минимальным значением - 1
*/

