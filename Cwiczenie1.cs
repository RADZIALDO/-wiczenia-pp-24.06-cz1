using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Size = 10;

            int[,] tab = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                if(i % 2 == 0)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        tab[i, j] = i * 10 + j + 1;
                    }
                }
                else
                {
                    for(int j = 0;j < Size; j++)
                    {
                        tab[i,j] = (i + 1) * 10 - j;
                    }
                }
            }

            for (int i = 0;i < Size;i++)
            {
                for(int j =0;j < Size;j++)
                {
                    Console.Write(tab[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}