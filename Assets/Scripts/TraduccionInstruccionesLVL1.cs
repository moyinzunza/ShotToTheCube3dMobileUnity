using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraduccionInstruccionesLVL1 : MonoBehaviour {

    public TextMesh instrucciones;
    // Use this for initialization
    void Start () {
        switch (Application.systemLanguage.ToString())
        {

            case "Spanish":
                instrucciones.text = "Haga que el cubo toque el suelo";
                break;

            case "English":
                instrucciones.text = "Make the cube touch the ground";
                break;

            case "Japanese":
                instrucciones.text = "キューブが地面に触れるようにする";
                break;

            case "German":
                instrucciones.text = "Machen Sie den Würfel den Boden berühren";
                break;

            case "Russian":
                instrucciones.text = "Сделайте куб коснуться земли";
                break;

            default:
                instrucciones.text = "Make the cube touch the ground";
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
