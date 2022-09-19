// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//временный массив для "рандомных" чисел. заполняем всем диапазоном двузначных.
int[] arr_tmp = new int[90];
int x = 10;
for (int i = 0; i < arr_tmp.Length; i++)
    {
        arr_tmp[i] = x;
        x = x + 1;
    }

//основной массив
int[,,] array = new int[2, 2, 2];
for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++) 
                    {
                        //рандомом получаем индекс числа во временном массиве
                        Random rand = new Random();
                        int z = rand.Next(0,89);

                        if (arr_tmp[z] != 0) //проверяем, что число под индексом !=0 
                            {
                                array [i, j, k] = arr_tmp[z]; 
                                arr_tmp [z] = 0; //присваиваем использованному индексу во временном массиве 0
                            }
                        else 
                            {
                                i = i - 1; //откатываем счетчик на одну итерацию
                            }
                                
                    }
            }
    }         

 //выводим данные из массива
for(Int32 k =0; k< array.GetLength(2);k++)
    {
        for(Int32 i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(String.Format(array[i, j, k] + $"{(i,j,k)}" + "\t"));
                    }
                Console.WriteLine("");         
            }
    }