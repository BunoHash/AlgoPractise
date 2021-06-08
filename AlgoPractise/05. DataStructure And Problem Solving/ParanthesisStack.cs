using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.DataStructure
{
    public class ParanthesisStack
    {

        public static void StackProcess()
        {

            string input = "{{}}){}{[]}";

            Stack<char> myStack = new Stack<char>();



            for(int i=0;i<input.Length; i++)
            {
                char item = input[i];
                
                if (item == '{' || item == '[' || item == '(')
                {
                    myStack.Push(item);
                }
                else if (myStack.Count == 0)
                {
                    Console.WriteLine("NOT RIGHT FORMAT");
                    return;
                }
                else if (item == '}' && myStack.Pop() =='{') 
                {
                    
                }
                else if (item == ']' && myStack.Pop() == '[')
                {
                }
                else if (item == ')' && myStack.Pop() == '(')
                {
                }
                else
                {
                    Console.WriteLine("NOT RIGHT FORMAT");
                    return;
                }

            }

            Console.WriteLine("Right!!!");
            return;

        }
    }
}
