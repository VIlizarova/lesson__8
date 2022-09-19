// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

//создаем массив с клавиатуры и заполняем рандомом
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

        // //смотрим какой массив сгенерировался
        // Console.WriteLine("Первичный массив");
        // for(int i =0; i< array.GetLength(0); i++)
        //     {
        //         for(int j = 0; j < array.GetLength(1); j++)
        //             {
        //                 Console.Write(array[i, j] + "\t");
        //             }
        //         Console.WriteLine("");
        //     }

        int [] array_sum = new int[n];//храним тут информацию о суммах элементов каждой строки
        int [] array_num = new int[n];//а тут соответствующий индекс строки

        //подсчет
        for(int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum = sum + array[i,j];
                    }
                array_sum[i] = sum; 
                array_num[i] = i;
            }

        //Сортируем оба массива по значениям массива сумм
        Array.Sort(array_sum, array_num, 0, array_sum.Length - 1);

        //Ответ
        Console.Write ($"Строка с наименьшей суммой элементов: {array_num[0]}");
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