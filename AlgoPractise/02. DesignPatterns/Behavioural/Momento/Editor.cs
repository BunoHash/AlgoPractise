using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.Momento
{
    public class Editor
    {
        private string Content;


        public EditorState createState()
        {
            return new EditorState(Content);
        }

        public void restoreState(EditorState state)
        {
            this.Content = state?.getContent();
        }



        public String getContent()
        {
            return Content;
        }

        public void setContent(string content)
        {
            this.Content = content;
        }

    }
}
