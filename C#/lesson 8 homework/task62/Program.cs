// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] array = new int[4,4];

int up = 0;
int down = array.GetLength(0);  //принимаем любое количество строк
int left = 0;
int right = array.GetLength(1); //принимаем любое количество столбцов
int x = 1;                      //стартовое значение индекса [0] Может быть любым целым числом
int last = ((array.GetLength(0)*array.GetLength(1))+x);

while (x < last)
    {
        for (int j = left; j < right; j++)
            {
                int i = up;
                if (array[i,j] != 0)
                    {
                        continue;
                    }
                array[i,j] = x;
                x = x + 1;               
            }
            up = up + 1;
            
        for (int i = up; i < down; i++)
            {
                int j = right - 1;
                if (array[i,j] != 0)
                    {
                        continue;
                    }
                array[i,j] = x;
                x = x + 1;   
            }    
            right = right - 1;

        for (int j = right - 1; j > left - 1; j--)
            {
                int i = down -1;
                if (array[i,j] != 0)
                    {
                        continue;
                    }
                array[i,j] = x;
                x = x + 1;     
            }
            down = down - 1;
        
        for (int i = down - 1; i > up -1; i--)
            {
                int j = left;
                if (array[i,j] != 0)
                    {
                        continue;
                    }
                array[i,j] = x;
                x = x + 1;
            }    
            left = left + 1;
            
    }

for(Int32 i =0; i< array.GetLength(0); i++)
    {
        for(Int32 j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] < 10 && array[i,j] > -1)
                    {
                        Console.Write(" 0" + array[i, j] + "\t");
                    }
                else if (array[i,j] > 9)
                    {
                        Console.Write(" " + array[i, j] + "\t");
                    }
                else if (array[i,j] > -10)
                    {
                        Console.Write("-0" + (array[i, j] - (array[i, j]*2)) + "\t");
                    }
                else    
                    {
                        Console.Write(array[i, j] + "\t");
                    }
            }
        Console.WriteLine("");
    }