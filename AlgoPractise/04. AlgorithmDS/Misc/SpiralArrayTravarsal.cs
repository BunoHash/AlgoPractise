using System;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgoPractise.Algorithm_DS
{
					
    public class SpiralArrayTravarse
    {
        static int ll;
        static int indX=0,indY=0;
        
        static void updateInd(int x, int y){
            indX = x; indY =y;
            Console.WriteLine(indX*3 + (indY+1));
        }
        
        public static void Process()
        {
            int N=3, M=3, required =4;
            int serial =0,dir = 0; // 0> right, 1> down, 2>left, 3 >up
            int top=0, bottom = N-1, left =0, right= M-1;
            
            while(serial< required)
            {
                if(dir== 0){
                    for(int i = left;i<=right && serial<required ;i++)
                    {
                        serial++;
                        updateInd(top, i);
                    }
                    top++;
                }
                if(dir== 1){
                    for(int i = top;i<=bottom && serial<required ;i++)
                    {
                        serial++;
                        updateInd(i,right);
                    }
                    right--;
                }
                if(dir== 2){
                    for(int i = right;i>=left && serial<required ;i--)
                    {
                        serial++;
                        updateInd(bottom, i);
                    }
                    bottom--;
                }
                if(dir== 3){
                    Console.Write(bottom+":"+bottom+", top:"+top+ "\n");
                    for(int i = bottom;i>= top && serial<required ;i--)
                    {
                        serial++;
                        updateInd(i,left);
                    }
                    left++;
                }
                
                dir++;
                dir = dir%4;
                //Console.WriteLine("/");

                
                
            }
            Console.WriteLine(indX*M + (indY+1));
            
        }
    }

}