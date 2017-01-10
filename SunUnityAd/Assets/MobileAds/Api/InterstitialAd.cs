using System;
using MobileAds.Common;

namespace MobileAds.Api
{
    public class InterstitialAd
    {
        private IInterstitialClient client;
        private string placeId;

        public InterstitialAd(string placeId)
        {
            this.placeId = placeId;
            client = MobileAdsClientFactory.BuildInterstitialClient();

            this.client.OnAdLoaded += (sender , args) =>
             {
                if(this.OnAdLoaded != null)
                 {
                     this.OnAdLoaded(this , args);
                 }
             };

            this.client.OnAdFailedToLoad += (sender, args) =>
            {
                if(this.OnAdFailedToLoad != null)
                {
                    this.OnAdFailedToLoad(this , args);
                }
            };

            this.client.OnAdDisplayed += (sender, args) =>
            {
                if(this.OnAdDisplayed != null)
                {
                    this.OnAdDisplayed(this , args);
                }
            };

            this.client.OnAdClosed += (sender, args) =>
            {
                if(this.OnAdClosed != null)
                {
                    this.OnAdClosed(this , args);
                }
            };

            this.client.OnAdClicked += (sender, args) =>
            {
                if(this.OnAdClicked != null)
                {
                    this.OnAdClicked(this , args);
                }
            };
        }

        // Ad callBack events that can be hooked into
        public event EventHandler<EventArgs> OnAdLoaded;
        public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;
        public event EventHandler<EventArgs> OnAdDisplayed;
        public event EventHandler<EventArgs> OnAdClosed;
        public event EventHandler<EventArgs> OnAdClicked;


        public void LoadAd()
        {
            client.LoadAd(placeId);
        }

        public bool IsLoaded() {
            return client.IsLoaded();
        }

        public void ShowAd() {
            client.ShowAd();
        }


    }

}


