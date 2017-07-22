using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMain : MonoBehaviour {


	public GameObject BotonPlay;
	public GameObject BotonLevels;
	public GameObject BotonExit;

	public TextMesh tituloplay;
	public TextMesh titulolevels;
	public TextMesh tituloexit;

    public static InterstitialAd interstitialsplash;

    int NivelActual;

    void Start () {



        //admob.start();
        RequestInterstitial();
        BotonesGame.contador_disparos = 0;
		NivelActual = PlayerPrefs.GetInt ("NivelActual");
		if (NivelActual == 0) {
			NivelActual = 1;
			PlayerPrefs.SetInt ("NivelActual", 1);
		
		} else {
			NivelActual = PlayerPrefs.GetInt ("NivelActual");	
		}

		switch (Application.systemLanguage.ToString ()) {

		case "Spanish":
			tituloplay.text = "Jugar";
			titulolevels.text = "Niveles";
			tituloexit.text = "Salir";
			break;

		case "English":
			tituloplay.text = "Play";
			titulolevels.text = "Levels";
			tituloexit.text = "Exit";
			break;

		case "Japanese":
			tituloplay.text = "遊びます";
			titulolevels.text = "レベル";
			tituloexit.text = "出口";
			break;

		case "German":
			tituloplay.text = "Spielen";
			titulolevels.text = "Ebenen";
			tituloexit.text = "Ausgang";
			break;

		case "Russian":
			tituloplay.text = "Играть";
			titulolevels.text = "Уровни";
			tituloexit.text = "Выход";
			break;
		
		default:
			tituloplay.text = "Play";
			titulolevels.text = "Levels";
			tituloexit.text = "Exit";
			break;
		}
		
	}


    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId2 = "ca-app-pub-7511977534046999/7567184065";
#elif UNITY_IPHONE
        string adUnitId2 = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
        string adUnitId2 = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitialsplash = new InterstitialAd(adUnitId2);
        // Create an empty ad request.
        AdRequest request2 = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitialsplash.LoadAd(request2);
    }

    int splashshow = 0;
    void Update () {

        if (splashshow == 0)
        {
            if (interstitialsplash.IsLoaded())
            {
                interstitialsplash.Show();
                splashshow = 1;
            }
        }


        // creamos un rayo que va desde la cámara hacia el punto de la pantalla donde está el mouse.
        Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		//comprobamos si el player ha hecho click
		if (Input.GetMouseButtonDown(0)) { //si el player ha hecho click
			RaycastHit hit; //llamamos al rayo casteado 'hit'.
			if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
				

				if(hit.transform == BotonPlay.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
                   
                    GetComponent<AudioSource>().Stop();
					BotonPlay.GetComponent<AudioSource>().Play();
					Invoke ("Play",BotonPlay.GetComponent<AudioSource>().clip.length);
					
				}
				if(hit.transform == BotonLevels.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
                    
                    GetComponent<AudioSource>().Stop();
					BotonLevels.GetComponent<AudioSource>().Play();
					Invoke ("Levels",BotonLevels.GetComponent<AudioSource>().clip.length);
					
				}
				if(hit.transform == BotonExit.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					GetComponent<AudioSource>().Stop();
					BotonExit.GetComponent<AudioSource>().Play();
					Invoke ("Salir",BotonExit.GetComponent<AudioSource>().clip.length);
					
				}
			}
		}
		
		
		
		
		
		
		
	}
	void Play(){
        //admob.DestroyBanner();

        SceneManager.LoadScene("GameScene"+NivelActual);
	}
	void Levels(){
        //admob.DestroyBanner();
        SceneManager.LoadScene("worlds");
	}
	void Salir(){
		Application.Quit();
	}
	
}