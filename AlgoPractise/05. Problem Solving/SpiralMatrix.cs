using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._05._Problem_Solving
{
    internal class SpiralMatrix
    {
        static int[,] input = { { 1,2,3,4,5},
                                {16,17,18,19,6 },
                                {15,24,25,20,7},
                                { 14,23, 22, 21,8 },
                                { 13,12,11,10,9} };
        static int[] travarsed = new int[100];
        public static void Travarse()
        {
            int bottom = 5, right = 5, top = 0, left = 0;
            int taken = 0, total = bottom * right, direction = 1, gridX = 0, gridY = 0;



            while (taken < total)
            {
                Console.WriteLine(gridX+" "+gridY+" "+direction);
                travarsed[taken++] = input[gridX, gridY];
                if (direction == 1)
                {
                    if (gridY == right - 1)
                    {
                        gridX++;
                        direction = 2;
                        top++;
                        continue;
                    }
                    gridY++;
                }
                else if (direction == 2)
                {
                    if (gridX == bottom - 1)
                    {
                        gridY--;
                        direction = 3;
                        right--;
                        continue;
                    }
                    gridX++;
                }
                else if (direction == 3)
                {
                    if (gridY ==left)
                    {
                        gridX--;
                        direction = 4;
                        bottom--;
                        continue;
                    }
                    gridY--;
                }
                else if (direction == 4)
                {
                    if (gridX == top)
                    {
                        gridY++;
                        direction = 1;
                        left++;
                        continue;
                    }
                    gridX--;
                }

            }
        
            Console.WriteLine(travarsed.ToString());
        }

        public static void PrintSpiral()
        {
            int rowStart =0, rowEnd = input.GetLength(0)-1, colStart = 0, colEnd = input.GetLength(1)-1;
            while(rowStart <= rowEnd && colStart <= colEnd)
            {
                for (int i = colStart; i <= colEnd; i++)
                {
                    Console.Write(input[rowStart,i]+" ");
                }
                rowStart++;
                for (int i = rowStart; i <= rowEnd; i++)
                {
                    Console.Write(input[i,colEnd] + " ");
                }
                colEnd--;
                
                for (int i = colEnd; i >= colStart; i--)
                {
                    Console.Write(input[rowEnd, i] + " ");
                }
                rowEnd--;
                
                for (int i = rowEnd; i >= rowStart; i--)
                {
                    Console.Write(input[i, colStart] + " ");
                }
                colStart++;
            }
        }
    }
}
