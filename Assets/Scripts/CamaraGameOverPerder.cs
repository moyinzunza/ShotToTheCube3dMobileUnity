using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class CamaraGameOverPerder : MonoBehaviour {

	public TextMesh Titulo;
	public TextMesh TituloSombra;
	private bool Ganaste = true;
	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;
	public GameObject boton_menu_ganar;
	public GameObject boton_restart_ganar;
	public GameObject boton_next;
	public GameObject boton_menu_perder;
	public GameObject boton_restart_perder;
	public GameObject indicadores;
    public GameObject boton_skip_level;
    public TextMesh skip_text;

	int NivelActual;
	int EstrellasNivel;
	int EstrellasActuales;

    //public admobscript admob;
   
    // Use this for initialization
    void Start () {
        NivelActual = PlayerPrefs.GetInt ("NivelActual");
		EstrellasNivel = PlayerPrefs.GetInt ("EstrellasNivel" + NivelActual);
		NotificationCenter.DefaultCenter ().AddObserver (this, "PerderGame");
	
	}

    private void OnEnable()
    {
        Invoke("mostrarAnuncio", 0.7f);
    }


    // Update is called once per frame
    void Update () {

		if (Cubo.cuboAgua == true) {
			Ganaste = false;		
		}


		indicadores.SetActive (false);
		if (Ganaste) {

			if(BotonesGame.contador_disparos == 1){
				EstrellasActuales = 3;
				Invoke ("activarEstrella1", 0);
				Invoke ("activarEstrella2", 1);
				Invoke ("activarEstrella3", 2);


			}
			if(BotonesGame.contador_disparos == 2){
				Invoke ("activarEstrella1", 0);
				Invoke ("activarEstrella2", 1);
				EstrellasActuales = 2;
			}
			if(BotonesGame.contador_disparos == 3){
				Invoke ("activarEstrella1", 0);
				EstrellasActuales = 1;
			}

			if(EstrellasNivel < EstrellasActuales){
				PlayerPrefs.SetInt("EstrellasNivel"+NivelActual, EstrellasActuales);
				
			}
			boton_menu_ganar.SetActive(true);
			boton_restart_ganar.SetActive(true);
			boton_next.SetActive(true);
			boton_menu_perder.SetActive(false);
			boton_restart_perder.SetActive(false);
            boton_skip_level.SetActive(false);

			switch (Application.systemLanguage.ToString ()) {
				
			case "Spanish":
				Titulo.text = "Ganaste";
				TituloSombra.text = "Ganaste";
				break;
				
			case "English":
				Titulo.text = "You Win";
				TituloSombra.text = "You Win";
				break;
				
			case "Japanese":
				Titulo.text = "あなたは勝つ";
				TituloSombra.text = "あなたは勝つ";
				break;
				
			case "German":
				Titulo.text = "Du gewinnst";
				TituloSombra.text = "Du gewinnst";
				break;
				
			case "Russian":
				Titulo.text = "Ты победил";
				TituloSombra.text = "Ты победил";
				break;
				
			default:
				Titulo.text = "You Win";
				TituloSombra.text = "You Win";
				break;
			}

		
		} else {
			estrella1.SetActive(false);
			estrella2.SetActive(false);
			estrella3.SetActive(false);
			PlayerPrefs.SetInt("EstrellasNivel"+NivelActual, EstrellasNivel);
			boton_menu_ganar.SetActive(false);
			boton_restart_ganar.SetActive(false);
			boton_next.SetActive(false);
			boton_menu_perder.SetActive(true);
			boton_restart_perder.SetActive(true);
            if (EstrellasNivel == 0 && BotonesGame.rewardBasedVideo.IsLoaded())
            {
                boton_skip_level.SetActive(true);
            }
            else {
                boton_skip_level.SetActive(false);
            }

			switch (Application.systemLanguage.ToString ()) {
				
			case "Spanish":
                    skip_text.text = "Ver anuncio para saltar nivel";
				    Titulo.text = "Perdiste";
				    TituloSombra.text = "Perdiste";
                    break;
				
			case "English":
                    skip_text.text = "Watch ad to skip level";
                    Titulo.text = "You lose";
				    TituloSombra.text = "You lose";
                    break;
				
			case "Japanese":
                    skip_text.text = "広告を見てレベルをスキップする";
                    Titulo.text = "あなたは失う";
				    TituloSombra.text = "あなたは失う";
                    break;
				
			case "German":
                    skip_text.text = "siehe Anzeige zu springen Ebene";
                    Titulo.text = "Du verlierst";
				    TituloSombra.text = "Du verlierst";
                    break;
				
			case "Russian":
                    skip_text.text = "Смотреть объявление и пропустить уровень";
                    Titulo.text = "Ты проиграл";
				    TituloSombra.text = "Ты проиграл";
                    break;
				
			default:
                    skip_text.text = "Watch ad to skip level";
                    Titulo.text = "You lose";
                    TituloSombra.text = "You lose";
                    break;
			}

		}
		
	}

	void PerderGame(){
		Ganaste = false;
	}

	void activarEstrella1(){
		estrella1.SetActive(true);
	}
	void activarEstrella2(){
		estrella2.SetActive(true);
	}
	void activarEstrella3(){
		estrella3.SetActive(true);
	}
    int AnuncioMostrado = 0;
	void mostrarAnuncio(){
        if(AnuncioMostrado == 0) { 
       
            if (BotonesGame.interstitial.IsLoaded())
            {
                BotonesGame.interstitial.Show();
                    AnuncioMostrado = 1;
            }
            Debug.Log("AnuncioMostrado", gameObject);
        
        }
    }

   

}