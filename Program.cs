//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int [,] Create2DArray (int row, int column)  
     {
      int[,] createdArray = new int[row,column];
       for (int i = 0; i < row; i++)
              for (int j = 0; j < column; j++)
              createdArray[i, j] = new Random().Next(0,10);
       return createdArray;
       }

void Print2DArray (int[,] array) 
{
         for (int i = 0; i < array.GetLength(0); i++)
        {
                for (int j = 0; j< array.GetLength(1); j++)
                    {
                         Console.Write(array[i,j] + " ");
                         }
                         Console.WriteLine();
                     }
                     Console.WriteLine(" ");
}

void SortRowArray (int[,] array)
{
int temp; 
for (int i = 0; i < array.GetLength(0); i++)
                     for (int j = 0; j< array.GetLength(1); j++)
                            for (int t = 0; t < array.GetLength(1) - 1; t++)
                               if (array[i,t] < array[i,t + 1])
                {
                    temp = array[i, t + 1];
                    array[i, t + 1] = array[i, t];
                    array[i, t] = temp;
                }
}

Console.WriteLine("Input count of rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of collumns: ");
int cols1 = Convert.ToInt32(Console.ReadLine());
int[,] arrayTask54 = Create2DArray(rows1, cols1);
Print2DArray(arrayTask54);
SortRowArray(arrayTask54);
Print2DArray(arrayTask54);


