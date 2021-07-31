using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.State
{
    public class Canvas
    {
        private Tool CurrentTool;


        public void mouseDown()
        {
            CurrentTool.mouseDown();

        }
        public void mouseUp()
        {
            CurrentTool.mouseUp();

        }

        public Tool getCurrentTool()
        {
            return CurrentTool;
        }

        public void setCurrentTool(Tool tool)
        {
            CurrentTool = tool;
        }
    }
}
