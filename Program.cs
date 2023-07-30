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

/* Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/* Решение 3
int InputInteNum(string message) //ввод целочисленных чисел
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray2D (int Length, int Height, int NumMatrix) //ввод двумерного массива
{
    int[,] Array2D = new int[Height,Length];
    for (int i=0; i < Height; i++)
    {
        for (int j=0; j<Length; j++)
        {
            Array2D[i,j] = InputInteNum("Введите значение матрицы " + NumMatrix + " с индексом [" + i + "," + j + "]");
        }
    }
    return Array2D;
}

int[,] MatrixProduct (int[,] Matrix_1, int[,] Matrix_2, int[,] Matrix_res)
{
    for(int i=0;i<Matrix_1.GetLength(0);i++)
    {
        for(int j=0;j<Matrix_2.GetLength(1);j++)
        {
            for(int k=0;k<Matrix_1.GetLength(1);k++)
            {
                Matrix_res[i,j] += Matrix_1[i,k] * Matrix_2[k,j];
            }
        }
    }
    return Matrix_res;
}

void PrintArray2D(int[,] Array2D)
{
    Console.Write("Ваш массив:" + Environment.NewLine);

    for(int i=0;i<Array2D.GetLength(0);i++)
    {
        Console.Write("[" + i + "] - ");
        for(int j=0;j<Array2D.GetLength(1);j++)
        {
            Console.Write(Array2D[i,j] + " ");
        }
        Console.Write(Environment.NewLine);
    }
}


int Height_Matrix_1 = InputInteNum("Введите количество строк в 1й матрице");
int Length_Matrix_1 = InputInteNum("Введите количество столбцов в 1й матрице");
int Height_Matrix_2 = InputInteNum("Введите количество строк в 2й матрице");
int Length_Matrix_2 = InputInteNum("Введите количество столбцов в 2й матрице");

if(Height_Matrix_1 != Length_Matrix_2)
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}

int[,] Matrix_1 = CreateArray2D(Length_Matrix_1,Height_Matrix_1,1);
int[,] Matrix_2 = CreateArray2D(Length_Matrix_2,Height_Matrix_2,2);
int[,] Matrix_res = new int[Length_Matrix_1,Height_Matrix_2];
Matrix_res = MatrixProduct(Matrix_1,Matrix_2,Matrix_res);
PrintArray2D(Matrix_res);
*/

/* Тест 3
PS D:\Home_Works\CS_HW_8> dotnet run
Введите количество строк в 1й матрице 2
Введите количество столбцов в 1й матрице 2
Введите количество строк в 2й матрице 2
Введите количество столбцов в 2й матрице 2
Введите значение матрицы 1 с индексом [0,0] 2
Введите значение матрицы 1 с индексом [0,1] 4
Введите значение матрицы 1 с индексом [1,0] 3
Введите значение матрицы 1 с индексом [1,1] 2
Введите значение матрицы 2 с индексом [0,0] 3
Введите значение матрицы 2 с индексом [0,1] 4
Введите значение матрицы 2 с индексом [1,0] 3
Введите значение матрицы 2 с индексом [1,1] 3
Ваш массив:
[0] - 18 20
[1] - 15 18
*/

/* Задача 4. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/* Решеие 4
int[,,] Array3D = new int[2,2,2];
int Number = 10;
for(int i=0;i<2;i++)
{
    for(int j=0;j<2;j++)
    {
        for(int k=0;k<2;k++)
        {
            Array3D[i,j,k] = Number;
            Number += 5;
        }
    }
}


Console.Write("Ваш массив:" + Environment.NewLine);

for(int i=0;i<Array3D.GetLength(0);i++)
{
    for(int j=0;j<Array3D.GetLength(1);j++)
    {
        for(int k=0;k<Array3D.GetLength(2);k++)
        {
            Console.Write(Array3D[i,j,k] + "(" + i + "," + j + "," + k + ")");
            Console.Write(Environment.NewLine);
        }        
    }
}
*/

/* Тест 4 
PS D:\Home_Works\CS_HW_8> dotnet run
Ваш массив:
10(0,0,0)
15(0,0,1)
20(0,1,0)
25(0,1,1)
30(1,0,0)
35(1,0,1)
40(1,1,0)
45(1,1,1)
*/

/* Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/* Решение 5
void PrintArray2D (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int n = 4;
int[,] Array2D = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Array2D.GetLength(0) * Array2D.GetLength(1))
{
  Array2D[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Array2D.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Array2D.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Array2D.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray2D(Array2D);
*/

/* Тест 5
PS D:\Home_Works\CS_HW_8> dotnet run
 1  2  3  4 
12 13 14  5
11 16 15  6
10  9  8  7
*/