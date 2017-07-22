using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesGameOver : MonoBehaviour {

	
	public GameObject BotonMenu;
	public GameObject BotonRestart;
	public GameObject BotonNext;

	public GameObject BotonMenuPerder;
	public GameObject BotonRestartPerder;
    public GameObject BotonSkip;


	
	int NivelActual;
	
	void Start () {
		NivelActual = PlayerPrefs.GetInt("NivelActual");
	}
	
	
	
	void Update () {
		
		
		// creamos un rayo que va desde la cámara hacia el punto de la pantalla donde está el mouse.
		Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		//comprobamos si el player ha hecho click
		if (Input.GetMouseButtonDown(0)) { //si el player ha hecho click
			RaycastHit hit; //llamamos al rayo casteado 'hit'.
			if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
				
				
				if(hit.transform == BotonMenu.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{

					BotonMenu.GetComponent<AudioSource>().Play();
					Invoke ("BotonMenuf",BotonMenu.GetComponent<AudioSource>().clip.length);
					
				}
				if(hit.transform == BotonRestart.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{

					BotonRestart.GetComponent<AudioSource>().Play();
					Invoke ("BotonRestartf",BotonRestart.GetComponent<AudioSource>().clip.length);
					
				}
				if(hit.transform == BotonNext.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{

					BotonNext.GetComponent<AudioSource>().Play();
					Invoke ("BotonNextf",BotonNext.GetComponent<AudioSource>().clip.length);
					
				}

				if(hit.transform == BotonMenuPerder.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{

					BotonMenuPerder.GetComponent<AudioSource>().Play();
					Invoke ("BotonMenuf",BotonMenuPerder.GetComponent<AudioSource>().clip.length);
					
				}
				if(hit.transform == BotonRestartPerder.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{

					BotonRestartPerder.GetComponent<AudioSource>().Play();
					Invoke ("BotonRestartf",BotonRestartPerder.GetComponent<AudioSource>().clip.length);
					
				}
                if (hit.transform == BotonSkip.transform)
                {
                    BotonSkip.GetComponent<AudioSource>().Play();
                    Invoke("BotonSkipf", BotonSkip.GetComponent<AudioSource>().clip.length);
                }
			}
		}





    }
	void BotonMenuf(){
		BotonesGame.contador_disparos = 0;
		SceneManager.LoadScene("MainScene");
	}
	void BotonRestartf(){
		BotonesGame.contador_disparos = 0;
		SceneManager.LoadScene("GameScene"+NivelActual);
	}
	void BotonNextf(){
		int NextLevel;
		BotonesGame.contador_disparos = 0;

        

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
			PlayerPrefs.SetInt ("NivelActual",NivelActual+1);
			NextLevel = NivelActual + 1;
			SceneManager.LoadScene("GameScene"+NextLevel);
			}
		
		}
        else
        {
			BotonesGame.contador_disparos = 0;
			SceneManager.LoadScene("MainScene");
		}


	}

    void BotonSkipf() {
        if (BotonesGame.rewardBasedVideo.IsLoaded())
        {
            BotonesGame.rewardBasedVideo.Show();
        }
    }

}