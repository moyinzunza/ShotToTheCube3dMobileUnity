using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueloAntigravedad : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collider)
    {
        collider.rigidbody.useGravity = false;
        collider.rigidbody.AddForce(0, 1, 0);
    }
    
}
