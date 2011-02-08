using System;
using System.Text;
using System.IO;

namespace FacebookHackerCup
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 2147483647;
            FileInfo file = new FileInfo("input.txt");
            int max_sq = (int)Math.Ceiling(Math.Sqrt((double)MAX)); // ~46341
            int[] array = new int[max_sq+1];

            // do some math ahead of time
            for (int i = 0; i <= max_sq; i++)
            {
                array[i] = i * i;
            }

            StreamReader fs = new StreamReader( file.OpenRead());

            int count = int.Parse(fs.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(calcDoubleSquare(array, int.Parse(fs.ReadLine())));
            }
        }
        static int calcDoubleSquare(int[] squares, int num)
        {
            int count = 0;
            for (int i = 0; i < squares.Length; i++)
            {
                if (squares[i] > num) break;
                for (int j = i; j < squares.Length; j++)
                {
                    if (squares[i] + squares[j] > num) { break; }
                    else if (squares[i] + squares[j] == num) { count++; break; }
                }
            }
            return count;
        }
    }
}
