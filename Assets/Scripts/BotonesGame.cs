using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class BotonesGame : MonoBehaviour {

    public GameObject BotonShot;
    public GameObject BotonRestart;
    public GameObject BotonSalir;
    public static int contador_disparos = 0;
    private bool ganaste = false;
    public GameObject CamaraGameOver;
    public GameObject Estrella1;
    public GameObject Estrella2;
    public GameObject Estrella3;
    public TextMesh bullets_disponibles;


    int NivelActual;
    int random_num1;

    public static int random_num2;
    public static BannerView nativeExpressAdView;
    public static InterstitialAd interstitial;
    public static RewardBasedVideoAd rewardBasedVideo;
    private bool rewardBasedEventHandlersSet = false;

    void Start() {
        
        RequestBanner();
        RequestInterstitial();
        RequestRewardBasedVideo();
        Cubo.cuboAgua = false;
        NivelActual = PlayerPrefs.GetInt("NivelActual");
        BotonesGame.contador_disparos = 0;
        NotificationCenter.DefaultCenter().AddObserver(this, "GanarGame");
    }


    private void RequestRewardBasedVideo()
    {
    #if UNITY_ANDROID
        string adUnitId = "ca-app-pub-7511977534046999/7433804910";
    #elif UNITY_IPHONE
        string adUnitId = "";
    #else
        string adUnitId = "unexpected_platform";
    #endif

        rewardBasedVideo = RewardBasedVideoAd.Instance;

        AdRequest request = new AdRequest.Builder().Build();


        if (!rewardBasedEventHandlersSet)
        {
            // Ad event fired when the rewarded video ad
            // has been received.
            rewardBasedVideo.OnAdLoaded += HandleRewardBasedVideoLoaded;
            // has failed to load.
            rewardBasedVideo.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
            // is opened.
            rewardBasedVideo.OnAdOpening += HandleRewardBasedVideoOpened;
            // has started playing.
            rewardBasedVideo.OnAdStarted += HandleRewardBasedVideoStarted;
            // has rewarded the user.
            rewardBasedVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;
            // is closed.
            rewardBasedVideo.OnAdClosed += HandleRewardBasedVideoClosed;
            // is leaving the application.
            rewardBasedVideo.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;

            rewardBasedEventHandlersSet = true;
        }


        rewardBasedVideo.LoadAd(request, adUnitId);
    }


    void HandleRewardBasedVideoLoaded(object sender, System.EventArgs e)
    {
        //OnRewardedVideoLoaded.Invoke();
        Debug.Log("OnRewardedVideoLoaded()", this);
    }

    void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs e)
    {
        //OnRewardedBasedVideoFailedToLoad.Invoke();
        Debug.Log("OnRewardedBasedVideoFailedToLoad()", this);
    }

    void HandleRewardBasedVideoOpened(object sender, System.EventArgs e)
    {
        //OnRewardBasedVideoOpened.Invoke();
        Debug.Log("OnRewardBasedVideoOpened()", this);
    }

    void HandleRewardBasedVideoStarted(object sender, System.EventArgs e)
    {
        //OnRewardBasedVideoStarted.Invoke();
        Debug.Log("OnRewardBasedVideoStarted()", this);
    }

    void HandleRewardBasedVideoRewarded(object sender, Reward e)
    {

        int NextLevel;
        contador_disparos = 0;



        if (NivelActual < 41)
        {

            if (TotalStars.totalStars <= 44 && NivelActual == 18)
            {
                SceneManager.LoadScene("Nivels");
            }
            else if (TotalStars2.totalStars <= 44 && NivelActual == 36)
            {
                SceneManager.LoadScene("Niveles2Scene");
            }
            else
            {
                PlayerPrefs.SetInt("EstrellasNivel" + NivelActual, 1);
                PlayerPrefs.SetInt("NivelActual", NivelActual + 1);
                NextLevel = NivelActual + 1;
                SceneManager.LoadScene("GameScene" + NextLevel);
            }

        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
        //OnRewardBasedVideoRewarded.Invoke();
        Debug.Log("OnRewardBasedVideoRewarded()", this);
    }

    void HandleRewardBasedVideoClosed(object sender, System.EventArgs e)
    {
        //OnRewardBasedVideoClosed.Invoke();
        Debug.Log("OnRewardBasedVideoClosed()", this);
        RequestRewardBasedVideo();
    }

    void HandleRewardBasedVideoLeftApplication(object sender, System.EventArgs e)
    {
        //OnRewardBasedVideoLeftApplication.Invoke();
        Debug.Log("OnRewardBasedVideoLeftApplication()", this);
    }




    public void RequestBanner()
    {
    #if UNITY_ANDROID
        string adUnitId = "ca-app-pub-7511977534046999/3038836469";
    #elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
    #else
        string adUnitId = "unexpected_platform";
    #endif

        // Create a 320x50 banner at the top of the screen.
        Debug.Log("width: " + Screen.width + ", Height: " + Screen.height);

        float width = Mathf.Sqrt((Screen.width * Screen.width) + (Screen.height * Screen.height));
        width = width / Screen.dpi;
        width = (Screen.width / width) * 1.41f;
        if (width > 1200)
        {
            width = 1200;
        }
        // Create a 320x150 native express ad at the top of the screen.

        //anuncio tamaño completo
        int intWidth = (int)width;

        // Create a 320x50 banner at the top of the screen.
        BotonesGame.nativeExpressAdView = new BannerView(adUnitId, new AdSize(intWidth, 80), AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        BotonesGame.nativeExpressAdView.LoadAd(request);
    }

    public void RequestInterstitial()
    {
    #if UNITY_ANDROID
        string adUnitId2 = "ca-app-pub-7511977534046999/1143300864";
    #elif UNITY_IPHONE
        string adUnitId2 = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
    #else
        string adUnitId2 = "unexpected_platform";
    #endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId2);
        // Create an empty ad request.
        AdRequest request2 = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request2);
    }

    void OnDestroy()
    {
        Debug.Log("Script Destruido");
        nativeExpressAdView.Destroy();
    }

    void Update () {
		

        bullets_disponibles.text = (3-contador_disparos).ToString ();


		if (contador_disparos == 2) {
			
			Estrella1.SetActive(false);
		}

		if (contador_disparos == 3) {
			Estrella2.SetActive(false);
			Invoke ("Perder", 5);		
		}

		
		
		
		// creamos un rayo que va desde la cámara hacia el punto de la pantalla donde está el mouse.
		Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		//comprobamos si el player ha hecho click
		if (Input.GetMouseButtonDown(0)) { //si el player ha hecho click
			RaycastHit hit; //llamamos al rayo casteado 'hit'.
			if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {

				if(hit.transform == BotonShot.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(contador_disparos<=2){
					contador_disparos++;
					BotonShot.GetComponent<AudioSource>().Play();
					NotificationCenter.DefaultCenter().PostNotification(this, "shot");
					}

				}
				if(hit.transform == BotonRestart.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
                    nativeExpressAdView.Destroy();
                    
                    
						Invoke("mostrarInterstitial", 0);
                        Invoke("Restart", 1);
                    
                    
                    
					
				}
				if(hit.transform == BotonSalir.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
                    
                    nativeExpressAdView.Destroy();
                    
                    Invoke ("Salir",0);
					
				}
		}
	}





	
	
}


    

	public void mostrarInterstitial(){
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }
	void GanarGame(){
		ganaste = true;
     
        nativeExpressAdView.Destroy();
        
    }
	void Perder(){

        
        nativeExpressAdView.Destroy();
        

        if (!ganaste) {
			Estrella3.SetActive(false);
			NotificationCenter.DefaultCenter ().PostNotification (this, "PerderGame");
            
            CamaraGameOver.SetActive(true);

		}

	}
	void Restart(){
        
            nativeExpressAdView.Destroy();
        
        contador_disparos = 0;
		SceneManager.LoadScene("GameScene"+NivelActual);
	}
	void Salir(){
        contador_disparos = 0;
		SceneManager.LoadScene("MainScene");
	}



}
