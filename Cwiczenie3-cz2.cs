using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cz2
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
            

            int[,] array = new int[Size, Size];

            int currentCol = 0;
            int currentRow = 0;
            int direction = 0;

            for (int currentNumber = 1; currentNumber <= Size * Size; currentNumber++)
            {
                array[currentRow, currentCol] = currentNumber;
                switch (direction)
                {
                    case 0:
                        if (currentCol + 1 >= Size || array[currentRow, currentCol + 1] != 0)
                        {
                            direction = 1;
                            currentRow++;
                        }
                        else
                        {
                            currentCol++;
                        }
                        break;
                    case 1:
                        if (currentRow + 1 >= Size || array[currentRow + 1, currentCol] != 0)
                        {
                            direction = 2;
                            currentCol--;
                        }
                        else
                        {
                            currentRow++;
                        }
                        break;
                    case 2:
                        if (currentCol - 1 < 0 || array[currentRow, currentCol - 1] != 0)
                        {
                            direction = 3;
                            currentRow--;
                        }
                        else
                        {
                            currentCol--;
                        }
                        break;
                    case 3:
                        if (array[currentRow - 1, currentCol] != 0)
                        {
                            direction = 0;
                            currentCol++;
                        }
                        else
                        {
                            currentRow--;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Tablica{Size}x{Size}: ");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
