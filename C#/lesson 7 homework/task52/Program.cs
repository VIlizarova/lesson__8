// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine ("Введите размерность массива через пробел");
string[] net = Console.ReadLine().Split(' ');
int n = Convert.ToInt32(net[0]);
int m = Convert.ToInt32(net[1]);

int[,] array = new int[n, m];

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++) 
        {
            Random rand = new Random();
            array[i,j] = rand.Next(1,10);
        }

}

for(Int32 i =0; i< array.GetLength(0);i++)
{
    for(Int32 j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    Console.WriteLine("");
}

float sum = 0;
int raw = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++) 
        {
            sum = sum + array[i,j];
        }
                
    raw = raw + 1;
    Console.WriteLine ($"среднеарифметическое столбца {raw} равно {Math.Round((sum/3), 1)}");
    sum = 0;
}