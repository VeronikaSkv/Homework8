// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//  каждой строки двумерного массива.

//1. Задаем двумерный массив

Console.WriteLine("введите количество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
 int[,] array3 =new int [m,n];
for (int i=0; i < array3.GetLength(0); i++)
{
    for (int j=0; j<array3.GetLength(1); j++)
    {
        array3 [i,j] = new Random().Next(1,10);
        Console.Write(array3[i,j]+ " ");
    
    }
    Console.WriteLine( );
}
int [] arrayTemp = new int [n]; //2. Создаем пусной массив для возможности сортировки каждой строки
int a = 0; 
Console.WriteLine( );
for (int i=0; i < array3.GetLength(0); i++) //3. Цикл для перезаписи созданного массива
{  a=0;
    for (int j=0; j<array3.GetLength(1); j++)
    { 
        arrayTemp [a] =array3 [i,j]; //4. Наполняем построчно массив 
        a++;
     
    }
    
       Array.Sort(arrayTemp);   //5.Сортируем строки массива

    a =n-1;
    for (int j=0; j<array3.GetLength(1); j++) //6. Перезаписываем построчно отсортированными строками (задом наперед)
    {   
        array3 [i,j] = arrayTemp[a];
        a--;
         Console.Write(array3[i,j]+ " ");
         }
    
     
    Console.WriteLine( );
}









