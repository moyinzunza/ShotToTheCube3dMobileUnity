using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BotonesNiveles : MonoBehaviour {


	public GameObject botonMenu;
	public GameObject botonNext;//boton next para los otros 18 niveles
	public GameObject MensajeFaltanEstrellas;
	int totalStars;

	public GameObject boton1;
	public GameObject Estrella1N1;
	public GameObject Estrella2N1;
	public GameObject Estrella3N1;
	int EstrellasNivel1;


	public GameObject boton2;
	public GameObject Estrella1N2;
	public GameObject Estrella2N2;
	public GameObject Estrella3N2;
	public GameObject candadoNivel2;
	int EstrellasNivel2;



	public GameObject boton3;
	public GameObject Estrella1N3;
	public GameObject Estrella2N3;
	public GameObject Estrella3N3;
	public GameObject candadoNivel3;
	int EstrellasNivel3;



	public GameObject boton4;
	public GameObject Estrella1N4;
	public GameObject Estrella2N4;
	public GameObject Estrella3N4;
	public GameObject candadoNivel4;
	int EstrellasNivel4;



	public GameObject boton5;
	public GameObject Estrella1N5;
	public GameObject Estrella2N5;
	public GameObject Estrella3N5;
	public GameObject candadoNivel5;
	int EstrellasNivel5;



	public GameObject boton6;
	public GameObject Estrella1N6;
	public GameObject Estrella2N6;
	public GameObject Estrella3N6;
	public GameObject candadoNivel6;
	int EstrellasNivel6;


	public GameObject boton7;
	public GameObject Estrella1N7;
	public GameObject Estrella2N7;
	public GameObject Estrella3N7;
	public GameObject candadoNivel7;
	int EstrellasNivel7;



	public GameObject boton8;
	public GameObject Estrella1N8;
	public GameObject Estrella2N8;
	public GameObject Estrella3N8;
	public GameObject candadoNivel8;
	int EstrellasNivel8;



	public GameObject boton9;
	public GameObject Estrella1N9;
	public GameObject Estrella2N9;
	public GameObject Estrella3N9;
	public GameObject candadoNivel9;
	int EstrellasNivel9;



	public GameObject boton10;
	public GameObject Estrella1N10;
	public GameObject Estrella2N10;
	public GameObject Estrella3N10;
	public GameObject candadoNivel10;
	int EstrellasNivel10;




	public GameObject boton11;
	public GameObject Estrella1N11;
	public GameObject Estrella2N11;
	public GameObject Estrella3N11;
	public GameObject candadoNivel11;
	int EstrellasNivel11;




	public GameObject boton12;
	public GameObject Estrella1N12;
	public GameObject Estrella2N12;
	public GameObject Estrella3N12;
	public GameObject candadoNivel12;
	int EstrellasNivel12;



	public GameObject boton13;
	public GameObject Estrella1N13;
	public GameObject Estrella2N13;
	public GameObject Estrella3N13;
	public GameObject candadoNivel13;
	int EstrellasNivel13;



	public GameObject boton14;
	public GameObject Estrella1N14;
	public GameObject Estrella2N14;
	public GameObject Estrella3N14;
	public GameObject candadoNivel14;
	int EstrellasNivel14;



	public GameObject boton15;
	public GameObject Estrella1N15;
	public GameObject Estrella2N15;
	public GameObject Estrella3N15;
	public GameObject candadoNivel15;
	int EstrellasNivel15;


	public GameObject boton16;
	public GameObject Estrella1N16;
	public GameObject Estrella2N16;
	public GameObject Estrella3N16;
	public GameObject candadoNivel16;
	int EstrellasNivel16;


	public GameObject boton17;
	public GameObject Estrella1N17;
	public GameObject Estrella2N17;
	public GameObject Estrella3N17;
	public GameObject candadoNivel17;
	int EstrellasNivel17;


	public GameObject boton18;
	public GameObject Estrella1N18;
	public GameObject Estrella2N18;
	public GameObject Estrella3N18;
	public GameObject candadoNivel18;
	int EstrellasNivel18;



	// Use this for initialization
	void Start () {
		EstrellasNivel1 = PlayerPrefs.GetInt("EstrellasNivel1");
		EstrellasNivel2 = PlayerPrefs.GetInt("EstrellasNivel2");
		EstrellasNivel3 = PlayerPrefs.GetInt("EstrellasNivel3");
		EstrellasNivel4 = PlayerPrefs.GetInt("EstrellasNivel4");
		EstrellasNivel5 = PlayerPrefs.GetInt("EstrellasNivel5");
		EstrellasNivel6 = PlayerPrefs.GetInt("EstrellasNivel6");
		EstrellasNivel7 = PlayerPrefs.GetInt("EstrellasNivel7");
		EstrellasNivel8 = PlayerPrefs.GetInt("EstrellasNivel8");
		EstrellasNivel9 = PlayerPrefs.GetInt("EstrellasNivel9");
		EstrellasNivel10 = PlayerPrefs.GetInt("EstrellasNivel10");
		EstrellasNivel11 = PlayerPrefs.GetInt("EstrellasNivel11");
		EstrellasNivel12 = PlayerPrefs.GetInt("EstrellasNivel12");
		EstrellasNivel13 = PlayerPrefs.GetInt("EstrellasNivel13");
		EstrellasNivel14 = PlayerPrefs.GetInt("EstrellasNivel14");
		EstrellasNivel15 = PlayerPrefs.GetInt("EstrellasNivel15");
		EstrellasNivel16 = PlayerPrefs.GetInt("EstrellasNivel16");
		EstrellasNivel17 = PlayerPrefs.GetInt("EstrellasNivel17");
		EstrellasNivel18 = PlayerPrefs.GetInt("EstrellasNivel18");
	}
	
	// Update is called once per frame
	void Update () {

		totalStars = EstrellasNivel1+EstrellasNivel2+EstrellasNivel3+EstrellasNivel4+EstrellasNivel5+EstrellasNivel6+EstrellasNivel7+EstrellasNivel8+EstrellasNivel9+EstrellasNivel10+EstrellasNivel11+EstrellasNivel12+EstrellasNivel13+EstrellasNivel14+EstrellasNivel15+EstrellasNivel16+EstrellasNivel17+EstrellasNivel18;

		if (EstrellasNivel1 == 3) {
			Estrella1N1.SetActive(false);
			Estrella2N1.SetActive(false);
			Estrella3N1.SetActive(false);
		}
		if (EstrellasNivel1 == 2) {
			Estrella1N1.SetActive(false);
			Estrella2N1.SetActive(false);
		}
		if (EstrellasNivel1 == 1) {
			Estrella1N1.SetActive(false);
		}

		if (EstrellasNivel1 >= 1) {
			candadoNivel2.SetActive(false);
		}




		if (EstrellasNivel2 == 3) {
			Estrella1N2.SetActive(false);
			Estrella2N2.SetActive(false);
			Estrella3N2.SetActive(false);
		}
		if (EstrellasNivel2 == 2) {
			Estrella1N2.SetActive(false);
			Estrella2N2.SetActive(false);
		}
		if (EstrellasNivel2 == 1) {
			Estrella1N2.SetActive(false);
		}
		
		if (EstrellasNivel2 >= 1) {
			candadoNivel3.SetActive(false);
		}


		if (EstrellasNivel3 == 3) {
			Estrella1N3.SetActive(false);
			Estrella2N3.SetActive(false);
			Estrella3N3.SetActive(false);
		}
		if (EstrellasNivel3 == 2) {
			Estrella1N3.SetActive(false);
			Estrella2N3.SetActive(false);
		}
		if (EstrellasNivel3 == 1) {
			Estrella1N3.SetActive(false);
		}
		
		if (EstrellasNivel3 >= 1) {
			candadoNivel4.SetActive(false);
		}



		if (EstrellasNivel4 == 3) {
			Estrella1N4.SetActive(false);
			Estrella2N4.SetActive(false);
			Estrella3N4.SetActive(false);
		}
		if (EstrellasNivel4 == 2) {
			Estrella1N4.SetActive(false);
			Estrella2N4.SetActive(false);
		}
		if (EstrellasNivel4 == 1) {
			Estrella1N4.SetActive(false);
		}
		
		if (EstrellasNivel4 >= 1) {
			candadoNivel5.SetActive(false);
		}




		if (EstrellasNivel5 == 3) {
			Estrella1N5.SetActive(false);
			Estrella2N5.SetActive(false);
			Estrella3N5.SetActive(false);
		}
		if (EstrellasNivel5 == 2) {
			Estrella1N5.SetActive(false);
			Estrella2N5.SetActive(false);
		}
		if (EstrellasNivel5 == 1) {
			Estrella1N5.SetActive(false);
		}
		
		if (EstrellasNivel5 >= 1) {
			candadoNivel6.SetActive(false);
		}



		if (EstrellasNivel6 == 3) {
			Estrella1N6.SetActive(false);
			Estrella2N6.SetActive(false);
			Estrella3N6.SetActive(false);
		}
		if (EstrellasNivel6 == 2) {
			Estrella1N6.SetActive(false);
			Estrella2N6.SetActive(false);
		}
		if (EstrellasNivel6 == 1) {
			Estrella1N6.SetActive(false);
		}
		
		if (EstrellasNivel6 >= 1) {
			candadoNivel7.SetActive(false);
		}



		if (EstrellasNivel7 == 3) {
			Estrella1N7.SetActive(false);
			Estrella2N7.SetActive(false);
			Estrella3N7.SetActive(false);
		}
		if (EstrellasNivel7 == 2) {
			Estrella1N7.SetActive(false);
			Estrella2N7.SetActive(false);
		}
		if (EstrellasNivel7 == 1) {
			Estrella1N7.SetActive(false);
		}
		
		if (EstrellasNivel7 >= 1) {
			candadoNivel8.SetActive(false);
		}



		if (EstrellasNivel8 == 3) {
			Estrella1N8.SetActive(false);
			Estrella2N8.SetActive(false);
			Estrella3N8.SetActive(false);
		}
		if (EstrellasNivel8 == 2) {
			Estrella1N8.SetActive(false);
			Estrella2N8.SetActive(false);
		}
		if (EstrellasNivel8 == 1) {
			Estrella1N8.SetActive(false);
		}
		
		if (EstrellasNivel8 >= 1) {
			candadoNivel9.SetActive(false);
		}




		if (EstrellasNivel9 == 3) {
			Estrella1N9.SetActive(false);
			Estrella2N9.SetActive(false);
			Estrella3N9.SetActive(false);
		}
		if (EstrellasNivel9 == 2) {
			Estrella1N9.SetActive(false);
			Estrella2N9.SetActive(false);
		}
		if (EstrellasNivel9 == 1) {
			Estrella1N9.SetActive(false);
		}
		
		if (EstrellasNivel9 >= 1) {
			candadoNivel10.SetActive(false);
		}




		if (EstrellasNivel10 == 3) {
			Estrella1N10.SetActive(false);
			Estrella2N10.SetActive(false);
			Estrella3N10.SetActive(false);
		}
		if (EstrellasNivel10 == 2) {
			Estrella1N10.SetActive(false);
			Estrella2N10.SetActive(false);
		}
		if (EstrellasNivel10 == 1) {
			Estrella1N10.SetActive(false);
		}
		
		if (EstrellasNivel10 >= 1) {
			candadoNivel11.SetActive(false);
		}



		if (EstrellasNivel11 == 3) {
			Estrella1N11.SetActive(false);
			Estrella2N11.SetActive(false);
			Estrella3N11.SetActive(false);
		}
		if (EstrellasNivel11 == 2) {
			Estrella1N11.SetActive(false);
			Estrella2N11.SetActive(false);
		}
		if (EstrellasNivel11 == 1) {
			Estrella1N11.SetActive(false);
		}
		
		if (EstrellasNivel11 >= 1) {
			candadoNivel12.SetActive(false);
		}



		if (EstrellasNivel12 == 3) {
			Estrella1N12.SetActive(false);
			Estrella2N12.SetActive(false);
			Estrella3N12.SetActive(false);
		}
		if (EstrellasNivel12 == 2) {
			Estrella1N12.SetActive(false);
			Estrella2N12.SetActive(false);
		}
		if (EstrellasNivel12 == 1) {
			Estrella1N12.SetActive(false);
		}
		
		if (EstrellasNivel12 >= 1) {
			candadoNivel13.SetActive(false);
		}


		if (EstrellasNivel13 == 3) {
			Estrella1N13.SetActive(false);
			Estrella2N13.SetActive(false);
			Estrella3N13.SetActive(false);
		}
		if (EstrellasNivel13 == 2) {
			Estrella1N13.SetActive(false);
			Estrella2N13.SetActive(false);
		}
		if (EstrellasNivel13 == 1) {
			Estrella1N13.SetActive(false);
		}
		
		if (EstrellasNivel13 >= 1) {
			candadoNivel14.SetActive(false);
		}


		if (EstrellasNivel14 == 3) {
			Estrella1N14.SetActive(false);
			Estrella2N14.SetActive(false);
			Estrella3N14.SetActive(false);
		}
		if (EstrellasNivel14 == 2) {
			Estrella1N14.SetActive(false);
			Estrella2N14.SetActive(false);
		}
		if (EstrellasNivel14 == 1) {
			Estrella1N14.SetActive(false);
		}
		
		if (EstrellasNivel14 >= 1) {
			candadoNivel15.SetActive(false);
		}



		if (EstrellasNivel15 == 3) {
			Estrella1N15.SetActive(false);
			Estrella2N15.SetActive(false);
			Estrella3N15.SetActive(false);
		}
		if (EstrellasNivel15 == 2) {
			Estrella1N15.SetActive(false);
			Estrella2N15.SetActive(false);
		}
		if (EstrellasNivel15 == 1) {
			Estrella1N15.SetActive(false);
		}
		
		if (EstrellasNivel15 >= 1) {
			candadoNivel16.SetActive(false);
		}



		if (EstrellasNivel16 == 3) {
			Estrella1N16.SetActive(false);
			Estrella2N16.SetActive(false);
			Estrella3N16.SetActive(false);
		}
		if (EstrellasNivel16 == 2) {
			Estrella1N16.SetActive(false);
			Estrella2N16.SetActive(false);
		}
		if (EstrellasNivel16 == 1) {
			Estrella1N16.SetActive(false);
		}
		
		if (EstrellasNivel16 >= 1) {
			candadoNivel17.SetActive(false);
		}



		if (EstrellasNivel17 == 3) {
			Estrella1N17.SetActive(false);
			Estrella2N17.SetActive(false);
			Estrella3N17.SetActive(false);
		}
		if (EstrellasNivel17 == 2) {
			Estrella1N17.SetActive(false);
			Estrella2N17.SetActive(false);
		}
		if (EstrellasNivel17 == 1) {
			Estrella1N17.SetActive(false);
		}
		
		if (EstrellasNivel17 >= 1) {
			candadoNivel18.SetActive(false);
		}



		if (EstrellasNivel18 == 3) {
			Estrella1N18.SetActive(false);
			Estrella2N18.SetActive(false);
			Estrella3N18.SetActive(false);
		}
		if (EstrellasNivel18 == 2) {
			Estrella1N18.SetActive(false);
			Estrella2N18.SetActive(false);
		}
		if (EstrellasNivel18 == 1) {
			Estrella1N18.SetActive(false);
		}
		
		if (EstrellasNivel18 >= 1) {
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




				if(hit.transform == boton1.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{

					boton1.GetComponent<AudioSource>().Play();
					Invoke ("Nivel1",boton1.GetComponent<AudioSource>().clip.length);
					
				}

				if(hit.transform == boton2.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel1 >= 1){
					
						boton2.GetComponent<AudioSource>().Play();

						Invoke ("Nivel2",boton2.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton3.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel2 >= 1){
						
						boton3.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel3",boton3.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton4.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel3 >= 1){
						
						boton4.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel4",boton4.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton5.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel4 >= 1){
						
						boton5.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel5",boton5.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton6.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel5 >= 1){
						
						boton6.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel6",boton6.GetComponent<AudioSource>().clip.length);
					}
					
				}


				if(hit.transform == boton7.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel6 >= 1){
						
						boton7.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel7",boton7.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton8.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel7 >= 1){
						
						boton8.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel8",boton8.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton9.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel8 >= 1){
						
						boton9.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel9",boton9.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton10.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel9 >= 1){
						
						boton10.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel10",boton10.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton11.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel10 >= 1){
						
						boton11.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel11",boton11.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton12.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel11 >= 1){
						
						boton12.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel12",boton12.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton13.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel12 >= 1){
						
						boton13.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel13",boton13.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton14.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel13 >= 1){
						
						boton14.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel14",boton14.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton15.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel14 >= 1){
						
						boton15.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel15",boton15.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton16.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel15 >= 1){
						
						boton16.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel16",boton16.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton17.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel16 >= 1){
						
						boton17.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel17",boton17.GetComponent<AudioSource>().clip.length);
					}
					
				}

				if(hit.transform == boton18.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
				{
					if(EstrellasNivel17 >= 1){
						
						boton18.GetComponent<AudioSource>().Play();
						
						Invoke ("Nivel18",boton18.GetComponent<AudioSource>().clip.length);
					}
					
				}
			}
		}
	
	}
	void BotonMenu(){
        SceneManager.LoadScene("MainScene");
	}

	void BotonNext(){
				if (totalStars < 45) {
			        MensajeFaltanEstrellas.SetActive(true);
				} else {
						SceneManager.LoadScene ("Niveles2Scene");
				}
		}

	void Nivel1(){
		PlayerPrefs.SetInt ("NivelActual",1);
		SceneManager.LoadScene("GameScene1");
	}
	void Nivel2(){
		PlayerPrefs.SetInt ("NivelActual",2);
		SceneManager.LoadScene("GameScene2");
	}
	void Nivel3(){
		PlayerPrefs.SetInt ("NivelActual",3);
		SceneManager.LoadScene("GameScene3");
	}
	void Nivel4(){
		PlayerPrefs.SetInt ("NivelActual",4);
		SceneManager.LoadScene("GameScene4");
	}
	void Nivel5(){
		PlayerPrefs.SetInt ("NivelActual",5);
		SceneManager.LoadScene("GameScene5");
	}
	void Nivel6(){
		PlayerPrefs.SetInt ("NivelActual",6);
		SceneManager.LoadScene("GameScene6");
	}
	void Nivel7(){
		PlayerPrefs.SetInt ("NivelActual",7);
		SceneManager.LoadScene("GameScene7");
	}
	void Nivel8(){
		PlayerPrefs.SetInt ("NivelActual",8);
		SceneManager.LoadScene("GameScene8");
	}
	void Nivel9(){
		PlayerPrefs.SetInt ("NivelActual",9);
		SceneManager.LoadScene("GameScene9");
	}
	void Nivel10(){
		PlayerPrefs.SetInt ("NivelActual",10);
		SceneManager.LoadScene("GameScene10");
	}
	void Nivel11(){
		PlayerPrefs.SetInt ("NivelActual",11);
		SceneManager.LoadScene("GameScene11");
	}
	void Nivel12(){
		PlayerPrefs.SetInt ("NivelActual",12);
		SceneManager.LoadScene("GameScene12");
	}
	void Nivel13(){
		PlayerPrefs.SetInt ("NivelActual",13);
		SceneManager.LoadScene("GameScene13");
	}
	void Nivel14(){
		PlayerPrefs.SetInt ("NivelActual",14);
		SceneManager.LoadScene("GameScene14");
	}
	void Nivel15(){
		PlayerPrefs.SetInt ("NivelActual",15);
		SceneManager.LoadScene("GameScene15");
	}
	void Nivel16(){
		PlayerPrefs.SetInt ("NivelActual",16);
		SceneManager.LoadScene("GameScene16");
	}
	void Nivel17(){
		PlayerPrefs.SetInt ("NivelActual",17);
		SceneManager.LoadScene("GameScene17");
	}
	void Nivel18(){
		PlayerPrefs.SetInt ("NivelActual",18);
		SceneManager.LoadScene("GameScene18");
	}
}
