using System;
using MobileAds.Api;

namespace MobileAds.Common
{
    internal interface ISplashAdClient
    {
        //Ad event fired when the interstitial ad has been received.
        event EventHandler<EventArgs> OnAdLoaded;
        //Ad evnet fired when the interstitial ad has failed to load.
        event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;
        //Ad event fired when the interstitial ad is showing;
        event EventHandler<EventArgs> OnAdDisplayed;
        //Ad event fired when the interstitial ad is closed;
        event EventHandler<EventArgs> OnAdClosed;
        //Ad event fired when the interstitial is clicked;
        event EventHandler<EventArgs> OnAdClicked;

        //Load a interstitialAd
        void LoadAd(string placeId);

        //Is ad loaded
        bool IsLoaded();

        //show a interstitialAd
        void ShowSplashAd();

    }
}


