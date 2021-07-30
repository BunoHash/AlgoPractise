using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.Momento
{
    public class ProcessMomento
    {
        public static void test()
        {
            var editor = new Editor();
            var history = new History();

            editor.setContent("army");


            history.push(editor.createState());
            editor.setContent("nevy");


            history.push(editor.createState());
            editor.setContent("air force");

            editor.restoreState(history.pop());
            Console.WriteLine(editor.getContent());
            editor.restoreState(history.pop());
            Console.WriteLine(editor.getContent());
            editor.restoreState(history.pop());
        }
    }
}
