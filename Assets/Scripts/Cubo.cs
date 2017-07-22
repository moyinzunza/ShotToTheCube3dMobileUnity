using UnityEngine;
using System.Collections;

public class Cubo : MonoBehaviour {

	private bool ganaste = false;
	public GameObject CamaraGameOver;
	public GameObject boton_disparos;
	public static bool cuboAgua = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collider){
		if (collider.gameObject.tag == "Suelo") {
						if (!ganaste) {
								ganaste = true;
								GetComponent<AudioSource>().Play ();
								boton_disparos.SetActive(false);
								NotificationCenter.DefaultCenter().PostNotification(this, "GanarGame");
								Invoke ("Ganar", GetComponent<AudioSource>().clip.length);
								
						}
				}

	}
	void OnTriggerEnter(Collider agua){
		if (!ganaste) {
						if (agua.gameObject.tag == "Agua") {
								boton_disparos.SetActive (false);
								Invoke ("Perder", 1);
						}
				}
	}



	void Ganar(){
		if (ganaste) {
				//codigo de notifiacacion center para ganar
					Debug.Log ("ganaste!!!!");
					
					CamaraGameOver.SetActive(true);
					
				}
	}
	void Perder(){
		cuboAgua = true;
		CamaraGameOver.SetActive (true);
        BotonesGame.nativeExpressAdView.Destroy();
        NotificationCenter.DefaultCenter().PostNotification(this, "PerderGame");
    }

}