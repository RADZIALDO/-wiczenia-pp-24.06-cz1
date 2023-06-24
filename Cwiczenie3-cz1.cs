using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy:");
            int Size = 0;
            while (Size <= 0)
            {
                if (!int.TryParse(Console.ReadLine(), out Size) || Size <= 0)
                {
                    Console.WriteLine("Niepoprawny rozmiar tablicy. Podaj liczbę większą od zera:");
                }
            }
            int[,] tab = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        tab[i, j] = i * Size + j + 1;
                    }
                }
                else
                {
                    for (int j = 0; j < Size; j++)
                    {
                        tab[i, j] = (i + 1) * Size - j;
                    }
                }
            }

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(tab[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
