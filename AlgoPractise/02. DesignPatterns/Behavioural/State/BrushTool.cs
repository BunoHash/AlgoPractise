using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.State
{
    public class BrushTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("brush down");
        }

        public void mouseUp()
        {
            Console.WriteLine("brush up");
        }
    }
}
