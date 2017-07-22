using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacebookTranslate : MonoBehaviour {

    public Text Pregunta;
    public Text Compartir;
    public Text Cancelar;

    // Use this for initialization
    void Start () {

        switch (Application.systemLanguage.ToString())
        {

            case "Spanish":
                Pregunta.text = "Seria de gran ayuda que nos ayudaras compartiendo el juego en facebook, Deseas Compartirlo?";
                Compartir.text = "Compartir";
                Cancelar.text = "Cancelar";
                break;

            case "English":
                Pregunta.text = "It would be very helpful if you help us by sharing the game on facebook, Do you want to share it ?";
                Compartir.text = "Share";
                Cancelar.text = "Cancel";
                break;

            case "Japanese":
                Pregunta.text = "それはあなたが共有したい、Facebook上のゲームを共有することによって、私たちを助けるためにあなたを助けるでしょうか";
                Compartir.text = "シェア";
                Cancelar.text = "キャンセル";
                break;

            case "German":
                Pregunta.text = "Es würde helfen Sie uns helfen, indem Sie das Spiel auf Facebook teilen, möchten Sie teilen?";
                Compartir.text = "Aktie";
                Cancelar.text = "Stornieren";
                break;

            case "Russian":
                Pregunta.text = "Это поможет вам, чтобы помочь нам, разделяя игру на Facebook, вы хотите поделиться?";
                Compartir.text = "Поделиться";
                Cancelar.text = "Отмена";
                break;

            default:
                Pregunta.text = "It would be very helpful if you help us by sharing the game on facebook, Do you want to share it ?";
                Compartir.text = "Share";
                Cancelar.text = "Cancel";
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
