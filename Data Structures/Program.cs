using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Program
    {
        private static int k;
        private static int l;
        //private static object a;
        //NB:"Most of my comments was me trying other solutions before arriving at this one. I just thought to leave my rough journey on the console" 

        static void Main(string[] args)
        {
            try
            {
                DataStructures();
                Determinant sqr = 0;
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        //private static void DataStructures()
        //{
        //    throw new NotImplementedException();
        //}

            //nrow = 0;

        

        public static void DataStructures()
        {

            Console.WriteLine("Welcome to my program which calculates the determinant of the 4D array below\n");
            //The matrix has 2 number of rows and 3 columns



            int i,j;
        	int[,,,] my4Darray = new int[3,4,2,3];
            int Determinant=0;
  
  
                       Console.Write("To find out the determinant of a [3,4,2,3] matrix :\n");                   
	                   Console.Write("Input elements of the matrix by indexing :\n");

                       for(i=0;i < my4Darray.GetLength(0); i++)
                       {
                            for(j=0;j<3;j++)
                            {
	                           Console.Write("element - [{0}],[{1}],[{2}]: ", i,j,k);
			                   my4Darray[i,j,k,l] = Convert.ToInt32(Console.ReadLine());
                            }
                       } 
                       
	                  Console.Write("The matrix is :\n");
	                  for(j=0; j < my4Darray.GetLength(1);j++)
	                  {
	                   for(k=0; k < my4Darray.GetLength(2); k++)
                        
	                    Console.Write("{0}  ",my4Darray[i, j, k,l]);
	                    Console.Write("\n");
	                  }

                      for(l=0; l < my4Darray.GetLength(3); l++)

                      //To calculate the determinant hence;

                      Determinant += (my4Darray[0,i,k,l] * (my4Darray[1,(i+1),(k+1),(j+1) % 3] * my4Darray[2,(i+2),(k+2),(j+2) % 3] - my4Darray[1,(i+2),(k+1),(j+2) % 3] * my4Darray[2,(i+1),(k+1),(j+1) % 3]));

                      Console.Write("\nThe Determinant of the matrix is: {0}\n\n", Determinant);

            //Question2: The determinant squared value 

                      Determinant sqr = (Determinant)^2;
                
                      Console.WriteLine("\n The determinant squared value is: {Determinant sqr}", Determinant);
                      }

             
    
    
    }
            //Display of the 4D array in bits

            //int[,,,] my4Darray = new int[3, 4, 2, 3]
            //{
            //    {{{ 2, 4, 8 }, {3, 4, 2 }},
            //    {{ 3, 2, 4 }, { 2, 1, 3 }},
            //    {{ 3, 2, 6 }, { 4, 5, 3 }},
            //    {{ 5, 2, 3 }, { 2, 4, 5 }}},

            //    {{{ 2, 3, 4 }, { 4, 6, 7 }},
            //    {{ 2, 3, 1 }, { 3, 2, 3 }},
            //    {{ 3, 4, 5 }, { 4, 9, 5 }},
            //    {{ 3, 5, 7 }, { 3, 2, 1 }}},

            //    {{{ 3, 2, 8 }, { 2, 3, 4 }},
            //    {{ 2, 4, 2 }, { 2, 1, 7 }},
            //    {{ 2, 5, 7 }, { 2, 1, 8 }},
            //    {{ 6, 4, 3 }, { 2, 1, 5 }}},
            //};
           // matrix(aperm(arr, c(3, 4, 2, 3)), v: nrow = dim(arr) * dim(arr));

        }

        //private static object Dim(object arr)
        //{
        //    throw new NotImplementedException();
        //}

        //private static object dim(object arr)
        //{
        //    throw new NotImplementedException();
        //}

        //private static object c(int v1, int v2, int v3, int v4)
        //{
        //    throw new NotImplementedException();
        //}

        //private static object aperm(object arr, object p)
        //{
        //    throw new NotImplementedException();
        //}

        //private static void matrix(object p, int v)
        //{
        //    throw new NotImplementedException();
        //}
    
 

