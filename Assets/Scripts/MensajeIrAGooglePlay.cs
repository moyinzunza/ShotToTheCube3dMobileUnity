using UnityEngine;
using UnityEngine.UI;

public class MensajeIrAGooglePlay : MonoBehaviour {


	public Text Pregunta;
	public Text IrAGooglePlay;
	public Text No;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		switch (Application.systemLanguage.ToString ()) {
			
		case "Spanish":
			Pregunta.text = "Podrias ayudarnos con 5 estrellas?";
			IrAGooglePlay.text = "Ir a GooglePlay";
			No.text = "No";
			break;
			
		case "English":
			Pregunta.text = "Could you please help us with 5 stars ?";
			IrAGooglePlay.text = "Go to GooglePlay";
			No.text = "No";
			break;
			
		case "Japanese":
			Pregunta.text = "あなたは5つ星で私たちを助けてくださいませんか？";
			IrAGooglePlay.text = "GooglePlayに行く";
			No.text = "しない";
			break;
			
		case "German":
			Pregunta.text = "Können Sie uns helfen, mit 5 Sternen ?";
			IrAGooglePlay.text = "Zum GooglePlay";
			No.text = "Unterlassen Sie";
			break;
			
		case "Russian":
			Pregunta.text = "Не могли бы вы , пожалуйста, помогите нам 5 звезд?";
			IrAGooglePlay.text = "Перейти к GooglePlay";
			No.text = "не";
			break;
			
		default:
			Pregunta.text = "Could you please help us with 5 stars ?";
			IrAGooglePlay.text = "Go to GooglePlay";
			No.text = "No";
			break;
		}

        
	}
}

