// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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
//2. задаем одномерный пустой массив для записи сумм строк и подсчитываем суммы
int [] arrayTemp= new int [array3.GetLength(0)];
for (int i=0; i < array3.GetLength(0); i++)
{ int summa=0;
    for (int j=0; j<array3.GetLength(1); j++)
    {
        summa = summa + array3[i,j];
    }
     arrayTemp[i] = summa;
} 
//  Console.Write(string.Join (",",arrayTemp));
//3. находим в какой ячейке лежит минимальная сумма и выводим результат
int summaMin =arrayTemp[0];
int indexMin = 0;
for (int i=1; i < array3.GetLength(0); i++)
{
    if (arrayTemp[i]<summaMin) 
    {
        summaMin = arrayTemp[i];
        indexMin =i;
    }
}
Console.WriteLine($" Строка {indexMin+1} содержит минимальную сумму элементов"  );
