using UnityEngine;

public class MensajeFaltanEstrellas : MonoBehaviour {

	public TextMesh MensajeFaltan;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("QuitarMensaje", 2);


		switch (Application.systemLanguage.ToString ()) {
			
		case "Spanish":
			MensajeFaltan.text = "Necesitas 45 Estrellas";
			break;
			
		case "English":
			MensajeFaltan.text = "You Need 45 Stars";
			break;
			
		case "Japanese":
			MensajeFaltan.text = "あなたは、 45スターを必要とする";
			break;
			
		case "German":
			MensajeFaltan.text = "Sie müssen 45 Sterne";
			break;
			
		case "Russian":
			MensajeFaltan.text = "Вы должны +45 Звезды";
			break;
			
		default:
			MensajeFaltan.text = "You Need 45 Stars";
			break;
		}
	}
	void QuitarMensaje(){
		this.gameObject.SetActive (false);
	}
}
