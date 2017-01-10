using System;
using UnityEngine;
using MobileAds.Common;

namespace MobileAds.Android
{
    internal class AdService : IAdServiceClient
    {

        private AndroidJavaObject adService;
        private AndroidJavaObject activity;

        public AdService()
        {
            AndroidJavaClass palyerClass = new AndroidJavaClass(Configs.UnityActivityClassName);
            activity = palyerClass.GetStatic<AndroidJavaObject>("currentActivity");
            this.adService = new AndroidJavaObject(Configs.AdServiceClassName);
        }


        public void init(string publisherId, string appKey, string appId)
        {
            this.adService.CallStatic("init" , activity , publisherId , appKey , appId);
        }

        public void setDebug(bool debug)
        {
            this.adService.CallStatic("setDebug",debug);
        }

        public void setLocationEnable(bool enable)
        {
            this.adService.CallStatic("setLocationEnable", enable);
        }
    }
}


