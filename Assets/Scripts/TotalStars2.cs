using UnityEngine;

public class TotalStars2 : MonoBehaviour {

	public TextMesh textoTotalStars;

    public static int totalStars;
	int EstrellasNivel19;
	int EstrellasNivel20;
	int EstrellasNivel21;
	int EstrellasNivel22;
	int EstrellasNivel23;
	int EstrellasNivel24;
	int EstrellasNivel25;
	int EstrellasNivel26;
	int EstrellasNivel27;
	int EstrellasNivel28;
	int EstrellasNivel29;
	int EstrellasNivel30;
	int EstrellasNivel31;
	int EstrellasNivel32;
	int EstrellasNivel33;
	int EstrellasNivel34;
	int EstrellasNivel35;
	int EstrellasNivel36;
	
	// Use this for initialization
	void Start () {
		
		EstrellasNivel19 = PlayerPrefs.GetInt("EstrellasNivel19");
		EstrellasNivel20 = PlayerPrefs.GetInt("EstrellasNivel20");
		EstrellasNivel21 = PlayerPrefs.GetInt("EstrellasNivel21");
		EstrellasNivel22 = PlayerPrefs.GetInt("EstrellasNivel22");
		EstrellasNivel23 = PlayerPrefs.GetInt("EstrellasNivel23");
		EstrellasNivel24 = PlayerPrefs.GetInt("EstrellasNivel24");
		EstrellasNivel25 = PlayerPrefs.GetInt("EstrellasNivel25");
		EstrellasNivel26 = PlayerPrefs.GetInt("EstrellasNivel26");
		EstrellasNivel27 = PlayerPrefs.GetInt("EstrellasNivel27");
		EstrellasNivel28 = PlayerPrefs.GetInt("EstrellasNivel28");
		EstrellasNivel29 = PlayerPrefs.GetInt("EstrellasNivel29");
		EstrellasNivel30 = PlayerPrefs.GetInt("EstrellasNivel30");
		EstrellasNivel31 = PlayerPrefs.GetInt("EstrellasNivel31");
		EstrellasNivel32 = PlayerPrefs.GetInt("EstrellasNivel32");
		EstrellasNivel33 = PlayerPrefs.GetInt("EstrellasNivel33");
		EstrellasNivel34 = PlayerPrefs.GetInt("EstrellasNivel34");
		EstrellasNivel35 = PlayerPrefs.GetInt("EstrellasNivel35");
		EstrellasNivel36 = PlayerPrefs.GetInt("EstrellasNivel36");
	}
	
	// Update is called once per frame
	void Update () {
		
		totalStars = EstrellasNivel19+EstrellasNivel20+EstrellasNivel21+EstrellasNivel22+EstrellasNivel23+EstrellasNivel24+EstrellasNivel25+EstrellasNivel26+EstrellasNivel27+EstrellasNivel28+EstrellasNivel29+EstrellasNivel30+EstrellasNivel31+EstrellasNivel32+EstrellasNivel33+EstrellasNivel34+EstrellasNivel35+EstrellasNivel36;
		textoTotalStars.text = totalStars.ToString ()+"/54"; 
	}
}
