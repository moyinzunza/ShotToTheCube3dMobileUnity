using UnityEngine;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {




	public float fuerzaSalto = 5f;

	private bool enSuelo = true;
	public Transform comprobadorSuelo;
	private float comprobadorRadio = 0.4f;
	public LayerMask mascaraSuelo;

	private bool dobleSalto = false;

	private Animator animator;


	private bool corriendo = false;
	public float velocidad = 2f;

	void Awake(){
		animator = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "Saltar");
	}

	void FixedUpdate(){
		if (corriendo) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
		}
		animator.SetFloat ("velx", GetComponent<Rigidbody2D>().velocity.x);
		enSuelo = Physics2D.OverlapCircle (comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		animator.SetBool ("ifGrounded", enSuelo);
		if (enSuelo) {
			dobleSalto = false;
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		if (corriendo) {

						velocidad = velocidad + 0.001f;
				}





		
	
	}

	void Saltar(){
		if(corriendo){
			if (enSuelo || !dobleSalto) {
				GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaSalto);
				
				GetComponent<AudioSource>().Play();
				
				//rigidbody2D.AddForce( new Vector2(0, fuerzaSalto));
				
			}
			if(!dobleSalto || !enSuelo){
				dobleSalto = true;
			}
		}
		else{
			corriendo = true;
			NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeEmpiezaACorrer");
		}
	}
}
