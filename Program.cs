using System;

namespace inverted_triangle_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 5;
                int spaces = 0;

                for (int i = n; i >= 1; i--)
                {

                    for (int j = 1; j <= (i + (i - 1)); j++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine("");
                    for (int k = 0; k < spaces; k++)
                    {
                        Console.Write(" ");
                    }
                    spaces++;
                }


            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");


            }   // End of catch
        }
    }
}
