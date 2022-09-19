// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = new int[2,2];
int[,] matrix2 = new int[2,2];
int[,] array = new int[2,2];

for (int j = 0; j < matrix1.GetLength(0); j++)
    {
        for (int i = 0; i < matrix1.GetLength(1); i++) 
            {
                Random rand = new Random();
                matrix1[i,j] = rand.Next(1,9);
            }
    }

for (int j = 0; j < matrix2.GetLength(0); j++)
    {
        for (int i = 0; i < matrix2.GetLength(1); i++) 
            {
                Random rand = new Random();
                matrix2[i,j] = rand.Next(1,9);
            }
    }

// Console.WriteLine("Первая матрица");
// for(Int32 i =0; i< matrix1.GetLength(0);i++)
//     {
//         for(Int32 j = 0; j < matrix1.GetLength(1); j++)
//             {
//                 Console.Write(matrix1[i, j] + "\t");
//             }
//             Console.WriteLine("");
//     }

// Console.WriteLine("Вторая матрица");
// for(Int32 i =0; i< matrix2.GetLength(0);i++)
//     {
//         for(Int32 j = 0; j < matrix2.GetLength(1); j++)
//             {
//                 Console.Write(matrix2[i, j] + "\t");
//             }
//             Console.WriteLine("");
//     }

for (var i = 0; i < matrix1.GetLength(0); i++)
    {
        for (var j = 0; j < matrix2.GetLength(1); j++)
            {
                array[i, j] = 0;
 
                for (var k = 0; k < matrix1.GetLength(1); k++)
                    {
                        array[i, j] = array[i, j] + (matrix1[i, k] * matrix2[k, j]);
                    }
            }
    }

Console.WriteLine("Результирующая матрица:");
for(Int32 i =0; i< array.GetLength(0);i++)
    {
        for(Int32 j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
        Console.WriteLine("");
    }