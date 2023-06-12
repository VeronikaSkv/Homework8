

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18 


Console.WriteLine("введите количество строк в матрице №1");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов в матрице №1");
int n = Convert.ToInt32(Console.ReadLine());
 int[,] matrix1 =new int [m,n];
 Console.WriteLine( " матрица №1");
for (int i=0; i < matrix1.GetLength(0); i++)
{
    for (int j=0; j<matrix1.GetLength(1); j++)
    {
        matrix1 [i,j] = new Random().Next(1,10);
        Console.Write(matrix1[i,j]+ " ");
    
    }
    Console.WriteLine( );
}
Console.WriteLine( );
Console.WriteLine( " матрица №2");

 int[,] matrix2 =new int [n,m];
for (int i=0; i < matrix2.GetLength(0); i++)
{
    for (int j=0; j<matrix2.GetLength(1); j++)
    {
        matrix2 [i,j] = new Random().Next(1,10);
        Console.Write(matrix2[i,j]+ " ");
    
    }
    Console.WriteLine( );
}
 Console.WriteLine( );
 Console.WriteLine("Произведение двух матриц равно");

int[,] matrixSUM =new int [m,n];

int sumnumber = 0;
for (int i=0; i < matrixSUM.GetLength(0); i++)
{ 
    for (int j=0; j<matrixSUM.GetLength(1); j++)
    { 
    for (int k=0; k<matrix1.GetLength(0); k++)
    {
      
        sumnumber = sumnumber + matrix1[i,k]* matrix2[k,j];
       
  } 
  matrixSUM[i,j]= sumnumber;
   sumnumber =0;
  Console.Write(matrixSUM[i,j]+ " ");
    }
    
    Console.WriteLine( );
}

