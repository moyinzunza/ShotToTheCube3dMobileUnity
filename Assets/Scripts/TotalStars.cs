using UnityEngine;
using System.Collections;

public class TotalStars : MonoBehaviour {

	public TextMesh textoTotalStars;

	public static int totalStars;
	int EstrellasNivel1;
	int EstrellasNivel2;
	int EstrellasNivel3;
	int EstrellasNivel4;
	int EstrellasNivel5;
	int EstrellasNivel6;
	int EstrellasNivel7;
	int EstrellasNivel8;
	int EstrellasNivel9;
	int EstrellasNivel10;
	int EstrellasNivel11;
	int EstrellasNivel12;
	int EstrellasNivel13;
	int EstrellasNivel14;
	int EstrellasNivel15;
	int EstrellasNivel16;
	int EstrellasNivel17;
	int EstrellasNivel18;

	// Use this for initialization
	void Start () {

		EstrellasNivel1 = PlayerPrefs.GetInt("EstrellasNivel1");
		EstrellasNivel2 = PlayerPrefs.GetInt("EstrellasNivel2");
		EstrellasNivel3 = PlayerPrefs.GetInt("EstrellasNivel3");
		EstrellasNivel4 = PlayerPrefs.GetInt("EstrellasNivel4");
		EstrellasNivel5 = PlayerPrefs.GetInt("EstrellasNivel5");
		EstrellasNivel6 = PlayerPrefs.GetInt("EstrellasNivel6");
		EstrellasNivel7 = PlayerPrefs.GetInt("EstrellasNivel7");
		EstrellasNivel8 = PlayerPrefs.GetInt("EstrellasNivel8");
		EstrellasNivel9 = PlayerPrefs.GetInt("EstrellasNivel9");
		EstrellasNivel10 = PlayerPrefs.GetInt("EstrellasNivel10");
		EstrellasNivel11 = PlayerPrefs.GetInt("EstrellasNivel11");
		EstrellasNivel12 = PlayerPrefs.GetInt("EstrellasNivel12");
		EstrellasNivel13 = PlayerPrefs.GetInt("EstrellasNivel13");
		EstrellasNivel14 = PlayerPrefs.GetInt("EstrellasNivel14");
		EstrellasNivel15 = PlayerPrefs.GetInt("EstrellasNivel15");
		EstrellasNivel16 = PlayerPrefs.GetInt("EstrellasNivel16");
		EstrellasNivel17 = PlayerPrefs.GetInt("EstrellasNivel17");
		EstrellasNivel18 = PlayerPrefs.GetInt("EstrellasNivel18");
	
	}
	
	// Update is called once per frame
	void Update () {

		totalStars = EstrellasNivel1+EstrellasNivel2+EstrellasNivel3+EstrellasNivel4+EstrellasNivel5+EstrellasNivel6+EstrellasNivel7+EstrellasNivel8+EstrellasNivel9+EstrellasNivel10+EstrellasNivel11+EstrellasNivel12+EstrellasNivel13+EstrellasNivel14+EstrellasNivel15+EstrellasNivel16+EstrellasNivel17+EstrellasNivel18;
		textoTotalStars.text = totalStars.ToString ()+"/54"; 
	}
}
