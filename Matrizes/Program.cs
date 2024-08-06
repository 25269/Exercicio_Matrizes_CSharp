using System;

namespace MeuNamespace
{
    public class Matrizes
    {
        static void Main(string[] args)
        {
            string[] values;

            Console.Write("Quantas linhas terá a matriz? ");
            int lines = int.Parse(Console.ReadLine());

            Console.Write("Quantas colunas terá a matriz? ");
            int columns = int.Parse(Console.ReadLine());

            int[,] mat = new int[lines, columns];

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("Quais os números desejados? ");
                values = Console.ReadLine().Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Qual o número que deseja verificar os seus números próximos? ");
            int numberSelected = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    if (mat[i, j] == numberSelected)
                    {
                        Console.WriteLine("Position: " + (i, j));

                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                            
                        if (j + 1 < columns)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                            
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                            
                        if (i + 1 < lines)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }

    }
}