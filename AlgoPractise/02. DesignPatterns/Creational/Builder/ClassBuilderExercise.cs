using System;
using System.Collections.Generic;
using System.Text;



namespace DP.Creational.Builder
    {
    public class Field
    {
        public string Type, Name;
    }
    public class Class
    {
        public string Name;
        public List<Field> fields = new List<Field>();

        public override string ToString()
                {
                    var sb = new StringBuilder();
                    sb.AppendLine($"public class {Name}").AppendLine("{");
                    foreach (var f in fields)
                    sb.AppendLine($"  {f.Type}: {f.Name}");

                    sb.AppendLine("}");
                    return sb.ToString();
                }
    }




    public class ClassBuilder
    {
        private Class theClass = new Class();


        public ClassBuilder(string className){
            this.theClass.Name = className;
        }

        public ClassBuilder AddField(string name, string type)
        {
            theClass.fields.Add(new Field{Name = name, Type = type});
            return this;
        }
        public override string ToString()
        {
        return theClass.ToString();
        }
    }

    public static class FirstTestSuite
    {
        public static void PersonTest()
        {
            var cb = new ClassBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
}