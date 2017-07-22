using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesNiveles2 : MonoBehaviour {

	
	public GameObject botonMenu;
	public GameObject botonNext;//boton next aca funciona como back
	public GameObject MensajeFaltanEstrellas;
	int totalStars;
	
	public GameObject boton19;
	public GameObject Estrella1N19;
	public GameObject Estrella2N19;
	public GameObject Estrella3N19;
	int EstrellasNivel19;
	
	
	public GameObject boton20;
	public GameObject Estrella1N20;
	public GameObject Estrella2N20;
	public GameObject Estrella3N20;
	public GameObject candadoNivel20;
	int EstrellasNivel20;
	
	
	
	public GameObject boton21;
	public GameObject Estrella1N21;
	public GameObject Estrella2N21;
	public GameObject Estrella3N21;
	public GameObject candadoNivel21;
	int EstrellasNivel21;
	
	
	
	public GameObject boton22;
	public GameObject Estrella1N22;
	public GameObject Estrella2N22;
	public GameObject Estrella3N22;
	public GameObject candadoNivel22;
	int EstrellasNivel22;
	
	
	
	public GameObject boton23;
	public GameObject Estrella1N23;
	public GameObject Estrella2N23;
	public GameObject Estrella3N23;
	public GameObject candadoNivel23;
	int EstrellasNivel23;
	
	
	
	public GameObject boton24;
	public GameObject Estrella1N24;
	public GameObject Estrella2N24;
	public GameObject Estrella3N24;
	public GameObject candadoNivel24;
	int EstrellasNivel24;
	
	
	public GameObject boton25;
	public GameObject Estrella1N25;
	public GameObject Estrella2N25;
	public GameObject Estrella3N25;
	public GameObject candadoNivel25;
	int EstrellasNivel25;
	
	
	
	public GameObject boton26;
	public GameObject Estrella1N26;
	public GameObject Estrella2N26;
	public GameObject Estrella3N26;
	public GameObject candadoNivel26;
	int EstrellasNivel26;
	
	
	
	public GameObject boton27;
	public GameObject Estrella1N27;
	public GameObject Estrella2N27;
	public GameObject Estrella3N27;
	public GameObject candadoNivel27;
	int EstrellasNivel27;
	
	
	
	public GameObject boton28;
	public GameObject Estrella1N28;
	public GameObject Estrella2N28;
	public GameObject Estrella3N28;
	public GameObject candadoNivel28;
	int EstrellasNivel28;
	
	
	
	
	public GameObject boton29;
	public GameObject Estrella1N29;
	public GameObject Estrella2N29;
	public GameObject Estrella3N29;
	public GameObject candadoNivel29;
	int EstrellasNivel29;
	
	
	
	
	public GameObject boton30;
	public GameObject Estrella1N30;
	public GameObject Estrella2N30;
	public GameObject Estrella3N30;
	public GameObject candadoNivel30;
	int EstrellasNivel30;
	
	
	
	public GameObject boton31;
	public GameObject Estrella1N31;
	public GameObject Estrella2N31;
	public GameObject Estrella3N31;
	public GameObject candadoNivel31;
	int EstrellasNivel31;
	
	
	
	public GameObject boton32;
	public GameObject Estrella1N32;
	public GameObject Estrella2N32;
	public GameObject Estrella3N32;
	public GameObject candadoNivel32;
	int EstrellasNivel32;
	
	
	
	public GameObject boton33;
	public GameObject Estrella1N33;
	public GameObject Estrella2N33;
	public GameObject Estrella3N33;
	public GameObject candadoNivel33;
	int EstrellasNivel33;
	
	
	public GameObject boton34;
	public GameObject Estrella1N34;
	public GameObject Estrella2N34;
	public GameObject Estrella3N34;
	public GameObject candadoNivel34;
	int EstrellasNivel34;
	
	
	public GameObject boton35;
	public GameObject Estrella1N35;
	public GameObject Estrella2N35;
	public GameObject Estrella3N35;
	public GameObject candadoNivel35;
	int EstrellasNivel35;
	
	
	public GameObject boton36;
	public GameObject Estrella1N36;
	public GameObject Estrella2N36;
	public GameObject Estrella3N36;
	public GameObject candadoNivel36;
	int EstrellasNivel36;
	
	int MensajeGooglePlay;
	public GameObject googleplayCanvas;
	// Use this for initialization
	void Start () {
		MensajeGooglePlay = PlayerPrefs.GetInt("MensajeIrGooglePlay");
		EstrellasNivel19 = PlayerPrefs.GetInt("EstrellasNivel19");
		EstrellasNivel20 = PlayerPrefs.GetInt("EstrellasNivel20");
		EstrellasNivel21 = PlayerPrefs.GetInt("EstrellasNivel21");
		EstrellasNivel22 = PlayerPrefs.GetInt("EstrellasNivel22");
		EstrellasNivel23 = PlayerPrefs.GetInt("EstrellasNivel23");
		EstrellasNivel24 = PlayerPrefs.GetInt("EstrellasNivel24");
		EstrellasNivel25 = PlayerPrefs.GetInt("EstrellasNivel25");
		EstrellasNivel26 = PlayerPrefs.GetInt("EstrellasNivel26");
		EstrellasNivel27 = PlayerPrefs.GetInt("EstrellasNivel27");
		EstrellasNivel28 = PlayerPrefs.GetInt("EstrellasNivel28");
		EstrellasNivel29 = PlayerPrefs.GetInt("EstrellasNivel29");
		EstrellasNivel30 = PlayerPrefs.GetInt("EstrellasNivel30");
		EstrellasNivel31 = PlayerPrefs.GetInt("EstrellasNivel31");
		EstrellasNivel32 = PlayerPrefs.GetInt("EstrellasNivel32");
		EstrellasNivel33 = PlayerPrefs.GetInt("EstrellasNivel33");
		EstrellasNivel34 = PlayerPrefs.GetInt("EstrellasNivel34");
		EstrellasNivel35 = PlayerPrefs.GetInt("EstrellasNivel35");
		EstrellasNivel36 = PlayerPrefs.GetInt("EstrellasNivel36");
	}
	
	// Update is called once per frame
	void Update () {

		if (MensajeGooglePlay == 0) {
            googleplayCanvas.SetActive(true);
		}
		
		totalStars = EstrellasNivel19+EstrellasNivel20+EstrellasNivel21+EstrellasNivel22+EstrellasNivel23+EstrellasNivel24+EstrellasNivel25+EstrellasNivel26+EstrellasNivel27+EstrellasNivel28+EstrellasNivel29+EstrellasNivel30+EstrellasNivel31+EstrellasNivel32+EstrellasNivel33+EstrellasNivel34+EstrellasNivel35+EstrellasNivel36;
		
		if (EstrellasNivel19 == 3) {
			Estrella1N19.SetActive(false);
			Estrella2N19.SetActive(false);
			Estrella3N19.SetActive(false);
		}
		if (EstrellasNivel19 == 2) {
			Estrella1N19.SetActive(false);
			Estrella2N19.SetActive(false);
		}
		if (EstrellasNivel19 == 1) {
			Estrella1N19.SetActive(false);
		}
		
		if (EstrellasNivel19 >= 1) {
			candadoNivel20.SetActive(false);
		}
		
		
		
		
		if (EstrellasNivel20 == 3) {
			Estrella1N20.SetActive(false);
			Estrella2N20.SetActive(false);
			Estrella3N20.SetActive(false);
		}
		if (EstrellasNivel20 == 2) {
			Estrella1N20.SetActive(false);
			Estrella2N20.SetActive(false);
		}
		if (EstrellasNivel20 == 1) {
			Estrella1N20.SetActive(false);
		}
		
		if (EstrellasNivel20 >= 1) {
			candadoNivel21.SetActive(false);
		}
		
		
		if (EstrellasNivel21 == 3) {
			Estrella1N21.SetActive(false);
			Estrella2N21.SetActive(false);
			Estrella3N21.SetActive(false);
		}
		if (EstrellasNivel21 == 2) {
			Estrella1N21.SetActive(false);
			Estrella2N21.SetActive(false);
		}
		if (EstrellasNivel21 == 1) {
			Estrella1N21.SetActive(false);
		}
		
		if (EstrellasNivel21 >= 1) {
			candadoNivel22.SetActive(false);
		}
		
		
		
		if (EstrellasNivel22 == 3) {
			Estrella1N22.SetActive(false);
			Estrella2N22.SetActive(false);
			Estrella3N22.SetActive(false);
		}
		if (EstrellasNivel22 == 2) {
			Estrella1N22.SetActive(false);
			Estrella2N22.SetActive(false);
		}
		if (EstrellasNivel22 == 1) {
			Estrella1N22.SetActive(false);
		}
		
		if (EstrellasNivel22 >= 1) {
			candadoNivel23.SetActive(false);
		}
		
		
		
		
		if (EstrellasNivel23 == 3) {
			Estrella1N23.SetActive(false);
			Estrella2N23.SetActive(false);
			Estrella3N23.SetActive(false);
		}
		if (EstrellasNivel23 == 2) {
			Estrella1N23.SetActive(false);
			Estrella2N23.SetActive(false);
		}
		if (EstrellasNivel23 == 1) {
			Estrella1N23.SetActive(false);
		}
		
		if (EstrellasNivel23 >= 1) {
			candadoNivel24.SetActive(false);
		}
		
		
		
		if (EstrellasNivel24 == 3) {
			Estrella1N24.SetActive(false);
			Estrella2N24.SetActive(false);
			Estrella3N24.SetActive(false);
		}
		if (EstrellasNivel24 == 2) {
			Estrella1N24.SetActive(false);
			Estrella2N24.SetActive(false);
		}
		if (EstrellasNivel24 == 1) {
			Estrella1N24.SetActive(false);
		}
		
		if (EstrellasNivel24 >= 1) {
			candadoNivel25.SetActive(false);
		}
		
		
		
		if (EstrellasNivel25 == 3) {
			Estrella1N25.SetActive(false);
			Estrella2N25.SetActive(false);
			Estrella3N25.SetActive(false);
		}
		if (EstrellasNivel25 == 2) {
			Estrella1N25.SetActive(false);
			Estrella2N25.SetActive(false);
		}
		if (EstrellasNivel25 == 1) {
			Estrella1N25.SetActive(false);
		}
		
		if (EstrellasNivel25 >= 1) {
			candadoNivel26.SetActive(false);
		}
		
		
		
		if (EstrellasNivel26 == 3) {
			Estrella1N26.SetActive(false);
			Estrella2N26.SetActive(false);
			Estrella3N26.SetActive(false);
		}
		if (EstrellasNivel26 == 2) {
			Estrella1N26.SetActive(false);
			Estrella2N26.SetActive(false);
		}
		if (EstrellasNivel26 == 1) {
			Estrella1N26.SetActive(false);
		}
		
		if (EstrellasNivel26 >= 1) {
			candadoNivel27.SetActive(false);
		}
		
		
		
		
		if (EstrellasNivel27 == 3) {
			Estrella1N27.SetActive(false);
			Estrella2N27.SetActive(false);
			Estrella3N27.SetActive(false);
		}
		if (EstrellasNivel27 == 2) {
			Estrella1N27.SetActive(false);
			Estrella2N27.SetActive(false);
		}
		if (EstrellasNivel27 == 1) {
			Estrella1N27.SetActive(false);
		}
		
		if (EstrellasNivel27 >= 1) {
			candadoNivel28.SetActive(false);
		}
		
		
		
		
		if (EstrellasNivel28 == 3) {
			Estrella1N28.SetActive(false);
			Estrella2N28.SetActive(false);
			Estrella3N28.SetActive(false);
		}
		if (EstrellasNivel28 == 2) {
			Estrella1N28.SetActive(false);
			Estrella2N28.SetActive(false);
		}
		if (EstrellasNivel28 == 1) {
			Estrella1N28.SetActive(false);
		}
		
		if (EstrellasNivel28 >= 1) {
			candadoNivel29.SetActive(false);
		}
		
		
		
		if (EstrellasNivel29 == 3) {
			Estrella1N29.SetActive(false);
			Estrella2N29.SetActive(false);
			Estrella3N29.SetActive(false);
		}
		if (EstrellasNivel29 == 2) {
			Estrella1N29.SetActive(false);
			Estrella2N29.SetActive(false);
		}
		if (EstrellasNivel29 == 1) {
			Estrella1N29.SetActive(false);
		}
		
		if (EstrellasNivel29 >= 1) {
			candadoNivel30.SetActive(false);
		}
		
		
		
		if (EstrellasNivel30 == 3) {
			Estrella1N30.SetActive(false);
			Estrella2N30.SetActive(false);
			Estrella3N30.SetActive(false);
		}
		if (EstrellasNivel30 == 2) {
			Estrella1N30.SetActive(false);
			Estrella2N30.SetActive(false);
		}
		if (EstrellasNivel30 == 1) {
			Estrella1N30.SetActive(false);
		}
		
		if (EstrellasNivel30 >= 1) {
			candadoNivel31.SetActive(false);
		}
		
		
		if (EstrellasNivel31 == 3) {
			Estrella1N31.SetActive(false);
			Estrella2N31.SetActive(false);
			Estrella3N31.SetActive(false);
		}
		if (EstrellasNivel31 == 2) {
			Estrella1N31.SetActive(false);
			Estrella2N31.SetActive(false);
		}
		if (EstrellasNivel31 == 1) {
			Estrella1N31.SetActive(false);
		}
		
		if (EstrellasNivel31 >= 1) {
			candadoNivel32.SetActive(false);
		}
		
		
		if (EstrellasNivel32 == 3) {
			Estrella1N32.SetActive(false);
			Estrella2N32.SetActive(false);
			Estrella3N32.SetActive(false);
		}
		if (EstrellasNivel32 == 2) {
			Estrella1N32.SetActive(false);
			Estrella2N32.SetActive(false);
		}
		if (EstrellasNivel32 == 1) {
			Estrella1N32.SetActive(false);
		}
		
		if (EstrellasNivel32 >= 1) {
			candadoNivel33.SetActive(false);
		}
		
		
		
		if (EstrellasNivel33 == 3) {
			Estrella1N33.SetActive(false);
			Estrella2N33.SetActive(false);
			Estrella3N33.SetActive(false);
		}
		if (EstrellasNivel33 == 2) {
			Estrella1N33.SetActive(false);
			Estrella2N33.SetActive(false);
		}
		if (EstrellasNivel33 == 1) {
			Estrella1N33.SetActive(false);
		}
		
		if (EstrellasNivel33 >= 1) {
			candadoNivel34.SetActive(false);
		}
		
		
		
		if (EstrellasNivel34 == 3) {
			Estrella1N34.SetActive(false);
			Estrella2N34.SetActive(false);
			Estrella3N34.SetActive(false);
		}
		if (EstrellasNivel34 == 2) {
			Estrella1N34.SetActive(false);
			Estrella2N34.SetActive(false);
		}
		if (EstrellasNivel34 == 1) {
			Estrella1N34.SetActive(false);
		}
		
		if (EstrellasNivel34 >= 1) {
			candadoNivel35.SetActive(false);
		}
		
		
		
		if (EstrellasNivel35 == 3) {
			Estrella1N35.SetActive(false);
			Estrella2N35.SetActive(false);
			Estrella3N35.SetActive(false);
		}
		if (EstrellasNivel35 == 2) {
			Estrella1N35.SetActive(false);
			Estrella2N35.SetActive(false);
		}
		if (EstrellasNivel35 == 1) {
			Estrella1N35.SetActive(false);
		}
		
		if (EstrellasNivel35 >= 1) {
			candadoNivel36.SetActive(false);
		}
		
		
		
		if (EstrellasNivel36 == 3) {
			Estrella1N36.SetActive(false);
			Estrella2N36.SetActive(false);
			Estrella3N36.SetActive(false);
		}
		if (EstrellasNivel36 == 2) {
			Estrella1N36.SetActive(false);
			Estrella2N36.SetActive(false);
		}
		if (EstrellasNivel36 == 1) {
			Estrella1N36.SetActive(false);
		}
		
		if (EstrellasNivel36 >= 1) {
			//candadoNivel16.SetActive(false);
		}
		
		
		// creamos un rayo que va desde la cámara hacia el punto de la pantalla donde está el mouse.
		Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		//comprobamos si el player ha hecho click
		if (Input.GetMouseButtonDown(0)) { //si el player ha hecho click
			RaycastHit hit; //llamamos al rayo casteado 'hit'.
			if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
				
				
				
				if(hit.transform == botonMenu.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					
					
					botonMenu.GetComponent<AudioSource>().Play();
					
					Invoke ("BotonMenu",botonMenu.GetComponent<AudioSource>().clip.length);
					
					
				}
				
				
				if(hit.transform == botonNext.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					
					
					botonNext.GetComponent<AudioSource>().Play();
					
					Invoke ("BotonNext",botonNext.GetComponent<AudioSource>().clip.length);
					
					
				}
				
				
				
				
				if(hit.transform == boton19.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					
					boton19.GetComponent<AudioSource>().Play();
					Invoke ("Nivel19",boton19.GetComponent<AudioSource>().clip.length);
					
				}
				
				if(hit.transform == boton20.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel19 >= 1){
						
						boton20.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel20",boton20.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton21.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel20 >= 1){
						
						boton21.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel21",boton21.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton22.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel21 >= 1){
						
						boton22.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel22",boton22.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton23.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel22 >= 1){
						
						boton23.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel23",boton23.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton24.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel23 >= 1){
						
						boton24.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel24",boton24.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				
				if(hit.transform == boton25.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel24 >= 1){
						
						boton25.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel25",boton25.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton26.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel25 >= 1){
						
						boton26.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel26",boton26.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton27.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel26 >= 1){
						
						boton27.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel27",boton27.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton28.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel27 >= 1){
						
						boton28.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel28",boton28.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton29.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel28 >= 1){
						
						boton29.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel29",boton29.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton30.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel29 >= 1){
						
						boton30.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel30",boton30.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton31.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel29 >= 1){
						
						boton31.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel31",boton31.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton32.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel31 >= 1){
						
						boton32.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel32",boton32.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton33.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel32 >= 1){
						
						boton33.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel33",boton33.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton34.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel33 >= 1){
						
						boton34.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel34",boton34.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton35.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel34 >= 1){
						
						boton35.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel35",boton35.GetComponent<AudioSource>().clip.length);
					}
					
				}
				
				if(hit.transform == boton36.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel35 >= 1){
						
						boton36.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel36",boton36.GetComponent<AudioSource>().clip.length);
					}
					
				}
			}
		}
		
	}
	void BotonMenu(){
		SceneManager.LoadScene("Nivels");
	}
	
	void BotonNext(){
		if (totalStars < 45) {
			MensajeFaltanEstrellas.SetActive(true);
		} else {
			SceneManager.LoadScene ("Niveles3Scene");
		}
	}
	
	void Nivel19(){
		PlayerPrefs.SetInt ("NivelActual",19);
		SceneManager.LoadScene("GameScene19");
	}
	void Nivel20(){
		PlayerPrefs.SetInt ("NivelActual",20);
		SceneManager.LoadScene("GameScene20");
	}
	void Nivel21(){
		PlayerPrefs.SetInt ("NivelActual",21);
		SceneManager.LoadScene("GameScene21");
	}
	void Nivel22(){
		PlayerPrefs.SetInt ("NivelActual",22);
		SceneManager.LoadScene("GameScene22");
	}
	void Nivel23(){
		PlayerPrefs.SetInt ("NivelActual",23);
		SceneManager.LoadScene("GameScene23");
	}
	void Nivel24(){
		PlayerPrefs.SetInt ("NivelActual",24);
		SceneManager.LoadScene("GameScene24");
	}
	void Nivel25(){
		PlayerPrefs.SetInt ("NivelActual",25);
		SceneManager.LoadScene("GameScene25");
	}
	void Nivel26(){
		PlayerPrefs.SetInt ("NivelActual",26);
		SceneManager.LoadScene("GameScene26");
	}
	void Nivel27(){
		PlayerPrefs.SetInt ("NivelActual",27);
		SceneManager.LoadScene("GameScene27");
	}
	void Nivel28(){
		PlayerPrefs.SetInt ("NivelActual",28);
		SceneManager.LoadScene("GameScene28");
	}
	void Nivel29(){
		PlayerPrefs.SetInt ("NivelActual",29);
		SceneManager.LoadScene("GameScene29");
	}
	void Nivel30(){
		PlayerPrefs.SetInt ("NivelActual",30);
		SceneManager.LoadScene("GameScene30");
	}
	void Nivel31(){
		PlayerPrefs.SetInt ("NivelActual",31);
		SceneManager.LoadScene("GameScene31");
	}
	void Nivel32(){
		PlayerPrefs.SetInt ("NivelActual",32);
		SceneManager.LoadScene("GameScene32");
	}
	void Nivel33(){
		PlayerPrefs.SetInt ("NivelActual",33);
		SceneManager.LoadScene("GameScene33");
	}
	void Nivel34(){
		PlayerPrefs.SetInt ("NivelActual",34);
		SceneManager.LoadScene("GameScene34");
	}
	void Nivel35(){
		PlayerPrefs.SetInt ("NivelActual",35);
		SceneManager.LoadScene("GameScene35");
	}
	void Nivel36(){
		PlayerPrefs.SetInt ("NivelActual",36);
		SceneManager.LoadScene("GameScene36");
	}


    public void IrAGooglePlay()
    {
        PlayerPrefs.SetInt("MensajeIrGooglePlay", 1);
        MensajeGooglePlay = 1;
        googleplayCanvas.SetActive(false);
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.greencube.shotcube");
    }

    public void GooglePlayCancel()
    {
        PlayerPrefs.SetInt("MensajeIrGooglePlay", 1);
        MensajeGooglePlay = 1;
        googleplayCanvas.SetActive(false);
    }
}
