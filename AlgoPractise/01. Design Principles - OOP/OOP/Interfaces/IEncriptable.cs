using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._01._Design_Principles___OOP.OOP.Interfaces
{
    internal interface IEncriptable
    {
        bool IsEncripted { get; set; }
        void Encript();
        void Decript();
    }
}
