using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.Momento
{
    public class EditorState
    {

        public EditorState(string content)
        {
            Content = content;
        }

        private string Content { get; set; }
        public string getContent()
        {
            return Content;
        }

    }
}
