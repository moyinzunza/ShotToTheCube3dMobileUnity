using UnityEngine;
using System.Collections;

public class GeneradorItem : MonoBehaviour {

	public GameObject obj;
	private GameObject clone;
	// Use this for initialization
	void Start () {
		
		NotificationCenter.DefaultCenter ().AddObserver (this, "shot");

	}
	

	
	void shot(){
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void Generar(){

		//xyz
		clone = Instantiate (obj, transform.position, Quaternion.identity) as GameObject;
		clone.GetComponent<Rigidbody>().AddForce((Input.mousePosition.x-(Screen.width/2))*2,(Input.mousePosition.y-(Screen.height/2))*2,980);



	}
}
