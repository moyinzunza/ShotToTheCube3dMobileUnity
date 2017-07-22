using UnityEngine;
using System.Collections;

public class cube2 : MonoBehaviour {

	public GameObject bloque;
	public GameObject particulas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collider){
		if (collider.gameObject.tag == "bullet") {

			particulas.SetActive(true);
			Invoke ("desbloquear", 0f);



		}
	}
	void desbloquear(){

		bloque.SetActive(false);
		this.gameObject.SetActive (false);


	}

}
