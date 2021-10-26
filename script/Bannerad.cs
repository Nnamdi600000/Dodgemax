using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Bannerad : MonoBehaviour
{
    private BannerView adBanner;
    private string idApp, idBanner;


    // Start is called before the first frame update
    void Start()
    {
        idApp = "ca-app-pub-8132992604981255~1525980643";
        idBanner = "ca-app-pub-8132992604981255/8081017803";
        
        MobileAds.Initialize(idApp);
        RequestBannerAd();
    }

    public void RequestBannerAd()  
    {
        adBanner = new BannerView(idBanner, AdSize.Banner, AdPosition.Top);
        AdRequest request = AdRequestBuild();
        adBanner.LoadAd(request);
    }

    public void DestroyBannerAd() //To destroy the banner ad
    {
        if (adBanner != null)
            adBanner.Destroy();
    }

    AdRequest AdRequestBuild ()
    {
        return new AdRequest.Builder().Build();
    }
}
