using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOopPractise
{
    public class EnumPractise 
    {
        public static void Process()
        {
            var type = (int)DataTypes.None;
            Console.WriteLine(type);

            


        }
        
    }

    [System.Flags]
    public enum DataTypes 
    {
        None =0,
        Setup = 1,
        Record = 2,
        Chargable = 3,
        
    }


}