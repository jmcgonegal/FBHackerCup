using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StudiousStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("input.txt");
            StreamReader fs = new StreamReader(file.OpenRead());

            int count = int.Parse(fs.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] values = fs.ReadLine().Split(' ');
                int index = int.Parse(values[0]);
                string[] strings = new string[index];

                Array.Copy(values, 1, strings, 0, index);
                List<string> sorted = new List<string>(strings);
                sorted.Sort();
                foreach (string s in sorted)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
