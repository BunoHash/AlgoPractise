using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.State
{
    public class EraserTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Eraser down");
        }

        public void mouseUp()
        {
            Console.WriteLine("Eraser up");
        }
    }
}
