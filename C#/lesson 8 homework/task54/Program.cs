// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

 try
    {
        Console.WriteLine ("Введите размерность массива через пробел");
        string[] net = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(net[0]); 
        int m = Convert.ToInt32(net[1]);
        if (n<1 || m<0)
            {
                Console.WriteLine("Размерность массива не может быть меньше [1,0]");
                return;
            }

        int[,] array = new int[n, m];

        for (int j = 0; j < array.GetLength(1); j++) 
            {
                for (int i = 0; i < array.GetLength(0); i++) 
                    {
                        Random rand = new Random();
                        array[i,j] = rand.Next(1,10);
                    }
            }

        Console.WriteLine("Первичный массив");
        for(Int32 i =0; i< array.GetLength(0);i++)
            {
                for(Int32 j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                Console.WriteLine("");
            }


        int [] array_tmp = new int[m];
        int y = 0;
        for (int i = 0; i < array.GetLength(0);i++)
            {
                for (int j = 0; j < array_tmp.Length; j++)
                    {
                        array_tmp[j] = array[y,j];
                    }

                Array.Sort(array_tmp, (x, y) => y.CompareTo(x));
                
                for (int k = 0; k < array.GetLength(1); k++)
                    {
                        array[y,k] = array_tmp[k];
                    }
                
                y = y+1;
            }


        Console.WriteLine("Сортированный массив");
        for(Int32 i =0; i< array.GetLength(0);i++)
            {
                for(Int32 j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                Console.WriteLine("");
            }

    }


catch (FormatException)
    {
        Console.WriteLine("Программа принимает только целые числа через 1 пробел");
        return;    
    }
catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Размерность массива введена не полностью");
        return;
    }