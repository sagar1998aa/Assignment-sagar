/*name= Sagar Devkota*/
/*student id=30004439*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Random rand = new Random();
            int[,] array = new int[3, 3];
           
   
            
            int[,] matrix = new int[ 3, 3 ]{ { -2, -5,-1 }, {- 4, -2,- 5 }, { -5, -1, -3 } };
            int[,] matrixb =new int[ 3, 3 ] { { 9, 8, 7 }, { 6, 4, 4 }, { 1, 2, 3 } };
            Console.WriteLine("******************");
            Console.WriteLine("Welcome to matrices");
             Console.WriteLine("****************");

            Console.WriteLine("\n the length property returns: " + matrix.Length);

            //Displaying a 2d array.
            Console.WriteLine("\n Array1:");
           Display(matrix);
            Console.WriteLine("\n Array2:");
            Display(matrixb);
          // in this added the array with together

            Console.WriteLine("\nArrays added together:");
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                     Console.Write(matrix[i, j] + matrixb[i, j] + "  ");
                }
                Console.WriteLine();
               

               
            }
            Console.WriteLine("**************Press Enter to Continue*************");
            Console.ReadLine();

        }

        public static void Display(int[,] arraya)
        {
            //row
            for (int i = 0; i < arraya.GetLength(0); i++)
            {
                //collumn
                for (int j = 0; j < arraya.GetLength(1); j++)
                {
                    Console.Write(arraya[i, j] + "  ");
                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
        }
        
    }
    
}
