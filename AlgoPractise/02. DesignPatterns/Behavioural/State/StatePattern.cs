using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.State
{
    public class StatePattern
    {

       

        public static void test()
        {
            var canvas = new Canvas();
            canvas.setCurrentTool(new SelectionTool());

            canvas.mouseDown();
            canvas.mouseUp();

            canvas.setCurrentTool(new EraserTool());
            canvas.mouseDown();
            canvas.mouseUp();


        }

    }
}
