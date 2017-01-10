using UnityEngine;
using System.Collections;

namespace MobileAds.Android
{
    public class Configs
    {
        #region Fully-qulified class names

        #region Ads SDK class name

        public const string AdListenerClassName = "com.sunteng.unityads.ads.UnityAdListener";


        #endregion

        #region Mobile Ads Unity Plugin class names

        public const string InterstitialClassName = "com.sunteng.unityads.ads.Interstitial";
        public const string AdServiceClassName = "com.sunteng.unityads.ads.AdService";

        #endregion

        #region Unity class names
        public const string UnityActivityClassName = "com.unity3d.player.UnityPlayer";
        #endregion

        #region
        public const string BundleClassName = "android.os.Bundle";
        #endregion

        #endregion

    }
}