using AlgoPractise._01._Design_Principles___OOP.OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasicInterfaces
{
    // TO-DO : Define a IStorable interface that provides the ability to load and save info
    // TO_DO: Implement IStorable interface in Document class

    class Document : IStorable, IEncriptable
    {
        private string _name;

        public Document(string name)
        {
            _name = name;
            Console.WriteLine($"Created a Document with name {name}");
        }

        public bool NeedSave { get ; set ; }
        public bool IsEncripted { get; set; }

        public void Decript()
        {
            Console.WriteLine($"Decripted a Document with name {this._name}");
        }

        public void Encript()
        {
            Console.WriteLine($"Encripted a Document with name {this._name}");
        }

        public void Load()
        {
            Console.WriteLine($"Loading a Document with name {this._name}");
        }


        public void Save()
        {
            Console.WriteLine($"Saving a Document with name {this._name}");

        }
    }
}
