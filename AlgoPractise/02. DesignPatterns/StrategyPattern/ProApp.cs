using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._02._DesignPatterns.StrategyPattern
{
    internal class ProApp : PhoneCameraApp
    {

        public override void EditPhoto()
        {
            this.editPhotoStrategy.EditPhoto();
        }

        public override void SharePhoto()
        {
            this.sharePhotoStrategy.SharePhoto();
        }

    }
}
