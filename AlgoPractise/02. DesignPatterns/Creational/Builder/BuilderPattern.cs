using System;
using System.Collections.Generic;
using System.Text;


namespace DP.Creational.Builder
{
    public class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> childs = new List<HtmlElement>();
        private const int IndenSize = 2;

        public HtmlElement( string name, string text)
        {
            this.Name = name;
            this.Text = text;
        }

        public HtmlElement()
        {
        }

        private string ToStringImplementation( int indent)
        {
            var sb = new StringBuilder();
            var indentLevel = new string(' ',indent*IndenSize);
            sb.AppendLine($"{indentLevel}<{Name}>");
            if(!string.IsNullOrWhiteSpace(Text)){
                sb.AppendLine($"{indentLevel}  {Text}");
            }

            foreach (var item in childs)
            {
                sb.Append(item.ToStringImplementation(indent+1));
            }

            sb.AppendLine($"{indentLevel}</{Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImplementation(0);
        }

    }


    public class HtmlBuilder
    {
        HtmlElement element = new HtmlElement();
        public string RootName;

        public string Name { get; }

        public HtmlBuilder(string rootName)
        {
            this.RootName = rootName;
            this.element.Name = rootName;
            
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var  e  = new HtmlElement(childName, childText);
            element.childs.Add(e);
            return this;
        }
        public override string ToString()
        {
            return element.ToString();
        }

    }

    public static class BuilderExecuter{

        public static void Run(){

            var builder  = new HtmlBuilder("ul");
            // Fluent Interface : chain multiple calls:
            builder.AddChild("li", "khap").AddChild("li", "kun").AddChild("li", "krap");
            string output =builder.ToString();
            Console.WriteLine(output);

        }



    }
}


