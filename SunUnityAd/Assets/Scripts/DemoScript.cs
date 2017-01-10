using UnityEngine;
using System;
using MobileAds;
using MobileAds.Api;
using MobileAds.Common;

public class DemoScript : MonoBehaviour
{

    private InterstitialAd interstitial;

    private float deltaTime = 0.0f;

    // Use this for initialization
    void Start()
    {
        IAdServiceClient adClient = MobileAdsClientFactory.BuildAdServiceClient();
        adClient.init("2", "8hME_QwQ2GkZT9.VDIwvwSY4*Skjg?Uf", "38");
    }

    // Update is called once per frame
    void Update()
    {
        this.deltaTime += (Time.deltaTime - this.deltaTime) * 0.1f;
    }

    public void OnGUI()
    {
        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, Screen.width, Screen.height);
        style.alignment = TextAnchor.LowerRight;
        style.fontSize = (int)(Screen.height * 0.01);
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float fps = 1.0f / this.deltaTime;
        string text = string.Format("{0:0.} fps", fps);
        GUI.Label(rect, text, style);

        GUI.skin.button.fontSize = (int)(0.035 * Screen.width);
        float buttonWidth = 0.35f * Screen.width;
        float buttonHeight = 0.1f * Screen.height;
        float columnOnePosition = 0.1f * Screen.width;
        float columnTwoPosition = 0.5f * Screen.width;

        Rect loadInterstitialRect = new Rect(columnOnePosition, 0.4f * Screen.height, buttonWidth, buttonHeight);
        if (GUI.Button(loadInterstitialRect, "load\nInterstitial"))
        {
            this.RequestInterstitial();
        }

        Rect showInterstitialRect = new Rect(columnTwoPosition , 0.4f * Screen.height , buttonWidth , buttonHeight);
        if (GUI.Button(showInterstitialRect, "show\nIntersititial"))
        {
            this.ShowInterstitail();
        }
    }

    private void ShowInterstitail()
    {
        if (this.interstitial != null && this.interstitial.IsLoaded())
        {
            interstitial.ShowAd();
        }

    }

    private void RequestInterstitial()
    {
        #if UNITY_EDITOR
            string placeId = "0";
#elif UNITY_ANDROID
            string placeId = "39";
#elif UNITY_IPHONE
            string placeId = "36";
#else
            string placeId = "-1";
#endif

        // create an interstitialAD
        this.interstitial = new InterstitialAd(placeId);
        this.interstitial.LoadAd();

        //Register for ad event;
        this.interstitial.OnAdClosed += HandleInterstitialLoaded;
        this.interstitial.OnAdFailedToLoad += HandleInterstitialLoadFailed;
        this.interstitial.OnAdDisplayed += HandleInterstitialDisplayed;
        this.interstitial.OnAdClicked += HandleInterstitialClicked;
        this.interstitial.OnAdClosed += HandleInterstitialClosed;
    }


    #region Intertitial callback handlers

    public void HandleInterstitialLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleInterstitialLoaded event received");
    }

    public void HandleInterstitialLoadFailed(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleInterstitialLoadFailed event received with message:" + args.Message);
    }

    public void HandleInterstitialDisplayed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleInterstitialDisplayed event received");
    }

    public void HandleInterstitialClicked(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleInterstitialClicked event received");
    }

    public void HandleInterstitialClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleInterstitialClosed event received");
    }

    #endregion
}
