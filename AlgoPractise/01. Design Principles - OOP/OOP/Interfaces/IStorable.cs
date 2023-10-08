using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    interface IStorable
    {
        void Save();
        void Load();
        bool NeedSave { get; set; }
    }
}
