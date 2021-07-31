using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.State
{
    public class SelectionTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("selection down");
        }

        public void mouseUp()
        {
            Console.WriteLine("selection up");
        }
    }
}
