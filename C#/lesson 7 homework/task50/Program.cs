// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

Console.WriteLine ("Введите позицию элемента через пробел");
string[] pos = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(pos[0]);
int y = Convert.ToInt32(pos[1]);

if (x >= array.GetLength(0) || y >= array.GetLength(1))
{
    Console.WriteLine ("Такого числа в массиве нет");
}

else
    Console.WriteLine($"Число в позиции строка {x}, столбец {y} равно {array[x,y]}");