using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Used it for a doctor's document uploader
/// The phone camera app has different version: Standerd, Pro, Bundled
/// The common functionality : take(), Save()
/// Different Functionality: SharePhoto(): Email, WhatsApp, Line



namespace StrategyPattern
{
    internal abstract class PhoneCameraApp
    {
        protected IShareStrategy sharePhotoStrategy;
        protected IEditStrategy editPhotoStrategy;


        public abstract void SharePhoto();
        public abstract void EditPhoto();

        public bool Save() 
        {
            return true;
        }
        public bool TakePhoto() 
        {
            return true;
        
        }
        public void SetShareStratgy(IShareStrategy strategy)
        {
            this.sharePhotoStrategy = strategy;
        }

        public void SetEditStratgy(IEditStrategy strategy)
        {
            this.editPhotoStrategy = strategy;
        }
    }
}
