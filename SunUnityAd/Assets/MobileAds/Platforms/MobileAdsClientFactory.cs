using MobileAds.Common;
using UnityEngine;
using System;

namespace MobileAds
{
    internal class MobileAdsClientFactory
    {

        internal static IAdServiceClient BuildAdServiceClient() {
            #if UNITY_EDITOR
                return new MobileAds.Common.TestClient();
            #elif UNITY_ANDROID
                return new MobileAds.Android.AdService(); 
            #elif (UNITY_5 && UNITY_IOS) || UNITY_IPHONE
                return new MobileAds.IOS.AdService(); 
            #endif
        }

        internal static IInterstitialClient BuildInterstitialClient()
        {
            #if UNITY_EDITOR
                return new MobileAds.Common.TestClient();
            #elif UNITY_ANDROID
                return new MobileAds.Android.InterstitialClient(); 
            #elif (UNITY_5 && UNITY_IOS) || UNITY_IPHONE
                return new MobileAds.IOS.InterstitialClient(); 
            #endif
        }

    }
}

