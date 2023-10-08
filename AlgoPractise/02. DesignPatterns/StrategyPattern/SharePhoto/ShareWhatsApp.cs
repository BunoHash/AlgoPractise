using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStrategyPattern
{
    internal class ShareWhatsApp : IShareStrategy
    {
        
        void IShareStrategy.SharePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
