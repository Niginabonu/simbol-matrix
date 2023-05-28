using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simbol_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            char[,] str = new char[4,4];

            for (int i = 0; i < 4; i++)
            {
                var arr=Console.ReadLine();
                for (int j = 0; j < 4; j++)
                {
                    str[i, j] = arr[j];



                    

                }
            }



            for (int i = 0; i < 3; i++)
            {
                

                for (int j = 0; j < 3; j++)
                {
                   // char result = str[i, j];


                    if (str[i,j] == str[i, j + 1] && str[i,j] == str[i + 1, j] && str[i,j] == str[i + 1, j + 1])
                    {
                        Console.WriteLine("No");
                        return;
                    }

                    

                }
            }
            Console.WriteLine("Yes");
            Console.ReadKey();
        }
    }
}
