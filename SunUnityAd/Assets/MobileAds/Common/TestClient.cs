using UnityEngine;
using MobileAds.Api;
using System;
using System.Reflection;

namespace MobileAds.Common
{
    internal class TestClient : IInterstitialClient , IAdServiceClient
    {
        public event EventHandler<EventArgs> OnAdClicked;
        public event EventHandler<EventArgs> OnAdClosed;
        public event EventHandler<EventArgs> OnAdDisplayed;
        public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;
        public event EventHandler<EventArgs> OnAdLoaded;

        public void init(string publisherId, string appKey, string appId)
        {
            Debug.Log("AdServices init whit publisherId:"+publisherId+",appKey:"+appKey+",appId:"+appId);
        }

        public bool IsLoaded()
        {
            Debug.Log("Test " + MethodBase.GetCurrentMethod().Name);
            return true;
        }

        public void LoadAd(string placeId)
        {
            Debug.Log("Test" + MethodBase.GetCurrentMethod().Name);
        }

        public void setDebug(bool debug)
        {
            Debug.Log("Test " + "debug :" + debug);
        }

        public void setLocationEnable(bool enable)
        {
            Debug.Log("Test " + "LocationEnable:"+enable);
        }

        public void ShowAd()
        {
            Debug.Log("Test " + MethodBase.GetCurrentMethod().Name);
        }
    }
}


