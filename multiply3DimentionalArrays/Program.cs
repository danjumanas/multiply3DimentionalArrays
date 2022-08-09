using System;

namespace multiply3DimentionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] threeDeeArray1 = new int[2, 2, 2]
            {
                {
                    { 5, 3}, 
                    { 6, 9}
                    
                },
                { 
                    { 2, 6},
                    { 4, 3}
                  
                } 
            };

            int[,,] threeDeeArray2 = new int[2, 2, 2]
            {
                {
                    { 7, 8},
                    { 1, 3}
                },
                {
                    { 5, 2},
                    { 6, 7}
                }
            };

            int[,,] resultArray = new int[2,2,2] ;

          
            for (int i = 0; i < threeDeeArray1.GetLength(0); i++)
            {
                for (int j = 0; j < threeDeeArray1.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDeeArray1.GetLength(2); k++)
                    {
                        resultArray[i,j,k] += threeDeeArray1[i, j, k] * threeDeeArray2[i, j, k];
                    }
                }
            }

            foreach (int item in resultArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
