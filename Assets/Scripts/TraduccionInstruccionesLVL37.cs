
using UnityEngine;

public class TraduccionInstruccionesLVL37 : MonoBehaviour {


    public TextMesh instrucciones;

    // Use this for initialization
    void Start () {
        switch (Application.systemLanguage.ToString())
        {

            case "Spanish":
                instrucciones.text = "Haga que el cubo toque la zona de gravedad";
                break;

            case "English":
                instrucciones.text = "Make the cube touch the gravity zone";
                break;

            case "Japanese":
                instrucciones.text = "キューブが重力ゾーンに触れるようにする";
                break;

            case "German":
                instrucciones.text = "Machen Sie den Würfel berühren die Schwerkraftzone";
                break;

            case "Russian":
                instrucciones.text = "Сделайте куб касаться зоны тяжести";
                break;

            default:
                instrucciones.text = "Make the cube touch the gravity zone";
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
