using System;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Mediation;

public class UnityAdsManager : MonoBehaviour
{
#if UNITY_IOS
    public string GAME_ID = "4985434"; //optional, we will autofetch the gameID if the project is linked in the dashboard
#elif UNITY_ANDROID
    public string GAME_ID = "4985435"; //optional, we will autofetch the gameID if the project is linked in the dashboard
#else
    public string GAME_ID = "0";
#endif
    IRewardedAd m_AD;
  
   public void OnInitializeClicked()
   {
       Initialize();
   }

   public async void Initialize()
   {
       try
       {
           InitializationOptions opt = new InitializationOptions();
           opt.SetGameId(GAME_ID);

           await UnityServices.InitializeAsync(opt);
           OnInitializationComplete();
       }
       catch (Exception e)
       {
           OnInitializationFailed(e);
       }
   }

   public async void LoadRewardedAd()
   {
       string rewardedAdUnitId = "myRewardedAdUnitId";
       IRewardedAd rewardedAd;

       rewardedAd = MediationService.Instance.CreateRewardedAd(rewardedAdUnitId);
       m_AD = rewardedAd;
       try
       {
           rewardedAd.OnLoaded += OnUnityAdsAdLoaded;
           rewardedAd.OnFailedLoad += OnUnityAdsFailedToLoad;
           rewardedAd.OnShowed += OnUnityAdsShowStart;
           rewardedAd.OnFailedShow += OnUnityAdsShowFailure;
           rewardedAd.OnClicked += OnUnityAdsShowClick;
           rewardedAd.OnClosed += OnUnityAdsClosed;
           rewardedAd.OnUserRewarded += OnUserRewarded;
           await rewardedAd.LoadAsync();
       }
       catch (LoadFailedException) {}
   }

   //this would likely be hooked to a UI button or a game event
   public async void ShowRewardedAd()
   {
       // Ensure the ad has loaded, then show it
       if (m_AD.AdState == AdState.Loaded) 
       {
         try
         {
            await m_AD.ShowAsync();
         }
         catch(Exception e)
         {
            //handle failure here
         }
       }
   }

   public void OnInitializationComplete()
   {
       // We recommend to load right after initialization according to docs
       LoadRewardedAd();
       Debug.Log("Init Success");
   }

   public void OnInitializationFailed(Exception e)
   {
        SdkInitializationError initializationError = SdkInitializationError.Unknown;
        if (e is InitializeFailedException initializeFailedException)
        {
            initializationError = initializeFailedException.initializationError;
        }

        Debug.Log($"{initializationError}:{e.Message}");
   }


   public void OnUnityAdsAdLoaded(object sender, EventArgs e)
   {
       Debug.Log($"Load Success");
   }

   public void OnUnityAdsFailedToLoad(object sender, LoadErrorEventArgs e)
   {
       Debug.Log($"{e.Error}:{e.Message}");
   }

   public void OnUnityAdsShowFailure(object sender, ShowErrorEventArgs args)
   {
       Debug.Log($"Ad failed to show: {args.Error}");
   }

   public void OnUnityAdsShowStart(object sender, EventArgs args)
   {
       Debug.Log("Ad shown successfully.");
   }

   public void OnUnityAdsShowClick(object sender, EventArgs e)
   {
       Debug.Log("Ad show clicked");
   }

   public void OnUnityAdsClosed(object sender, EventArgs e)
   {
       Debug.Log("Ad Closed");
   }

   void OnUserRewarded(object sender, RewardEventArgs e)
   {
       Debug.Log($"Received reward: type:{e.Type}; amount:{e.Amount}");
       // DO something here?
   }
}