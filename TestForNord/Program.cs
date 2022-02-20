using System;

namespace TestForNord
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] TriangleArray = Init(6);
            Console.Write("Изначальный массив\n");
            Print(TriangleArray);
            int[][] resultArray = Result(TriangleArray);
            Console.Write("Максмимальная сумма из всех возможных маршрутов:" + resultArray[0][0]+ "\n");
            Console.Write("Результирующий массив\n");
            Print(resultArray);

        }
        private static int[][] Init(int line)
        {
            int[][] TriangleArray = new int[line][];
            for (int i = 0; i < line; i++)
            {
                TriangleArray[i] = new int[i + 1];
            }
            Random count = new Random();
            for (int i = 0; i < TriangleArray.Length; i++)
            {
                for (int j = 0; j < TriangleArray[i].Length; j++)
                {
                    TriangleArray[i][j] = count.Next(100);
                }
            }
            return TriangleArray;
        }
        private static void Print(int[][] array)
        {
            //вывод значений массива
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        private static int[][] Result(int[][] array)
        {
            // вычисляем максимальное значение маршрута занося всю сумму в [0][0]
            for (int i = array.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i + 1][j] > array[i + 1][j + 1])
                    {
                        array[i][j] += array[i + 1][j];

                    }
                    else
                    {
                        array[i][j] += array[i + 1][j + 1];
                    }
                }
            }
            return array;
        }
    }

}
