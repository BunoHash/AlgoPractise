using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._02._DesignPatterns.Behavioural.Momento
{
    public class History
    {
        private List<EditorState> states = new List<EditorState>(); 

        public void push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState pop()
        {
            var lastIndex = states.Count -1;

            if(lastIndex>=0)
            {
                 var lastState = states[lastIndex];
                states.Remove(lastState);
                return lastState;
            }

            return null;
        }
    }
}
