using UnityEngine;
using System.Collections;

public class Planks : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collider){
		GetComponent<AudioSource>().Play ();
	}
}