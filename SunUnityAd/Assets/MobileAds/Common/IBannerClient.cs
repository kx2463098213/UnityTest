using System;
using MobileAds.Api;

namespace MobileAds.Common
{

    internal interface IBannerClient
    {
        //Ad event fired when the banner ad has been received.
        event EventHandler<EventArgs> OnAdLoaded;
        //Ad evnet fired when the banner ad has failed to load.
        event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;
        //Ad event fired when the banner ad is showing;
        event EventHandler<EventArgs> OnAdDisplayed;
        //Ad event fired when the banner ad is closed;
        event EventHandler<EventArgs> OnAdClosed;
        //Ad event fired when the banner ad is clicked;
        event EventHandler<EventArgs> OnAdClicked;

        //create a banner view 
        void CreateBannerView(string placeId , AdSize size , AdPositon position);

        //request a new banner ad for the banner view
        void LoadAd();

        //show the banner view on screen
        void showBannerView();

        //hide the banner view on screen
        void HideBannerView();

        //destory the banner view
        void DestoryBannerView();
    }

}


