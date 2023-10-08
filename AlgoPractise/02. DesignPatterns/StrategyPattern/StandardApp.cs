using AlgoPractise._02._DesignPatterns.StrategyPattern.DrivingMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class StandardApp : PhoneCameraApp
    {
        

        public override void EditPhoto()
        {
            editPhotoStrategy.EditPhoto();
        }

   
        public override void SharePhoto()
        {
            sharePhotoStrategy.SharePhoto();
        }

       
    }
}
