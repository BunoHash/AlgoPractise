using System.Collections.Generic;

namespace AlgoPractise._Design_Principles
{
    public class SingeResponsibilty
    {
        
    }

    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        public int AddEntry (string text)
        {
            entries.Add(text);
            return entries.Count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }
        public override string ToString()
        {
            return string.Join("\n",entries);
        }

    }

    public static class Demo
    {

        public static void Jain()
        {
            var journal = new Journal();
            journal.AddEntry("today it's raining");
            journal.AddEntry("Im feeling nausiated");
            System.Console.WriteLine(journal);

        }
    }
}