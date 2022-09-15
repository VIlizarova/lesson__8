// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine ("Введите размерность массива через пробел");

string[] net = Console.ReadLine().Split(' ');
int n = Convert.ToInt32(net[0]);
int m = Convert.ToInt32(net[1]);

double[,] array = new double[n, m];

for (int j = 0; j < array.GetLength(1); j++)
{

    for (int i = 0; i < array.GetLength(0); i++)
        {
            Random tmprand = new Random();
            int tmpr = tmprand.Next(-10, 10);
            Random rand = new Random();
            array[i,j] = Math.Round(rand.NextDouble()*tmpr, 1);
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