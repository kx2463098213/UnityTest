//#if UNITY_ANDROID

using System;
using MobileAds.Common;
using MobileAds.Api;
using UnityEngine;

namespace MobileAds.Android
{
    internal class InterstitialClient : AndroidJavaProxy, IInterstitialClient
    {

        private AndroidJavaObject interstitial;

        public InterstitialClient() : base(Configs.AdListenerClassName){
            AndroidJavaClass palyerClass = new AndroidJavaClass(Configs.UnityActivityClassName);
            AndroidJavaObject activity = palyerClass.GetStatic<AndroidJavaObject>("currentActivity");
            this.interstitial = new AndroidJavaObject(Configs.InterstitialClassName ,activity, this);
        }

        public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;
        public event EventHandler<EventArgs> OnAdLoaded;
        public event EventHandler<EventArgs> OnAdDisplayed;
        public event EventHandler<EventArgs> OnAdClosed;
        public event EventHandler<EventArgs> OnAdClicked;

        #region MobileAdsInterstitialClient implementation

        //Load and show Ad
        public void LoadAd(string place)
        {
            this.interstitial.Call("loadAd",place);
        }

        public bool IsLoaded()
        {
           return this.interstitial.Call<bool>("isLoaded");
        }

        public void ShowAd()
        {
            this.interstitial.Call("showAd");
        }

        #endregion

        #region  Callbacks from UnityAdListener

        public void onAdLoaded()
        {
            if(null != this.OnAdLoaded)
            {
                this.OnAdLoaded(this,EventArgs.Empty);
            }
        }

        public void onAdDisplayed()
        {
            if(null != this.OnAdDisplayed)
            {
                this.OnAdDisplayed(this,EventArgs.Empty);
            }
        }

        public void onAdClose()
        {
            if(null != this.OnAdClosed)
            {
                this.OnAdClosed(this , EventArgs.Empty);
            }
        }

        public void onAdClick()
        {
            if(null != this.OnAdClicked)
            {
                this.OnAdClicked(this , EventArgs.Empty);
            }
        }

        public void onAdLoadFailed(string errMessage)
        {
            if(null != this.OnAdFailedToLoad)
            {
                AdFailedToLoadEventArgs args = new AdFailedToLoadEventArgs() {
                    Message = errMessage
                };
                this.OnAdFailedToLoad(this , args);
            }
        }

        #endregion
    }
}


//#endif