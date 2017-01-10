using System;

namespace MobileAds.Api
{
    public class AdFailedToLoadEventArgs : EventArgs
    {
        //Event that occurs when an ad fails to load
        public string Message { get; set;}
    }
}


