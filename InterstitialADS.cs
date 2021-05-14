using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class InterstitialADS : MonoBehaviour {
    private InterstitialAd InterAd;
    public string InterID = "";
    private void Start() {
        MobileAds.Initialize(giveAD => { });
        InterStatil();
    }

    public void InterStatil(){
        InterAd = new InterstitialAd(InterID);
        AdRequest newAD = new AdRequest.Builder().Build();

        InterAd.LoadAd(newAD);
        InterAd.Show();
    }
}
