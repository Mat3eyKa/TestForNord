using System;

namespace TestForNord
{
  //  1
  //  2 3
  //  4 5 6
 
    class Program
    {
        static void Main(string[] args)
        {
            int couple = 0;
            int [][] TriangleArray= new int [6][];
            TriangleArray[0] = new int[1];
            TriangleArray[1] = new int[2];
            TriangleArray[2] = new int[3];
            TriangleArray[3] = new int[4];
            TriangleArray[4] = new int[5];
            TriangleArray[5] = new int[6];
            Random array = new Random();
            for (int i = 0;  i < TriangleArray.Length; i++)
            {
                for (int j = 0; j < TriangleArray[i].Length; j++)
                {
                    TriangleArray[i][j] = array.Next(10);
                }

            }
            // Array.Reverse(TriangleArray);
            for (int i = 0; i < TriangleArray.Length; i++)
            {
                for (int j = 0; j < TriangleArray[i].Length; j++)
                {
                    Console.Write(TriangleArray[i][j] + "\t");
                }
                Console.WriteLine();

            }
            int[] CoupleArray = new int[3];
            for (int i = TriangleArray.Length-2; i >=0 ; i--)
            {
                for (int j = 0; j < TriangleArray[i].Length; j++)
                {
                    if (TriangleArray[i + 1][j] > TriangleArray[i + 1][j + 1])
                        TriangleArray[i][j] += TriangleArray[i + 1][j];
                    else
                        TriangleArray[i][j] += TriangleArray[i + 1][j + 1];
                }

            }
            for (int i = 0; i < TriangleArray.Length; i++)
            {
                for (int j = 0; j < TriangleArray[i].Length; j++)
                {
                    Console.Write(TriangleArray[i][j] + "\t");
                }
                Console.WriteLine();

            }

        }
    }
}
