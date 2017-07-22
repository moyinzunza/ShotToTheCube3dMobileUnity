using UnityEngine;

public class TotalStars3 : MonoBehaviour {


    public TextMesh textoTotalStars;

    int totalStars;
    int EstrellasNivel37;
    int EstrellasNivel38;
    int EstrellasNivel39;
    int EstrellasNivel40;
    int EstrellasNivel41;
    int EstrellasNivel42;
    int EstrellasNivel43;
    int EstrellasNivel44;
    int EstrellasNivel45;
    int EstrellasNivel46;
    int EstrellasNivel47;
    int EstrellasNivel48;
    int EstrellasNivel49;
    int EstrellasNivel50;
    int EstrellasNivel51;
    int EstrellasNivel52;
    int EstrellasNivel53;
    int EstrellasNivel54;

    // Use this for initialization
    void Start()
    {

        EstrellasNivel37 = PlayerPrefs.GetInt("EstrellasNivel37");
        EstrellasNivel38 = PlayerPrefs.GetInt("EstrellasNivel38");
        EstrellasNivel39 = PlayerPrefs.GetInt("EstrellasNivel39");
        EstrellasNivel40 = PlayerPrefs.GetInt("EstrellasNivel40");
        EstrellasNivel41 = PlayerPrefs.GetInt("EstrellasNivel41");
        EstrellasNivel42 = PlayerPrefs.GetInt("EstrellasNivel42");
        EstrellasNivel43 = PlayerPrefs.GetInt("EstrellasNivel43");
        EstrellasNivel44 = PlayerPrefs.GetInt("EstrellasNivel44");
        EstrellasNivel45 = PlayerPrefs.GetInt("EstrellasNivel45");
        EstrellasNivel46 = PlayerPrefs.GetInt("EstrellasNivel46");
        EstrellasNivel47 = PlayerPrefs.GetInt("EstrellasNivel47");
        EstrellasNivel48 = PlayerPrefs.GetInt("EstrellasNivel48");
        EstrellasNivel49 = PlayerPrefs.GetInt("EstrellasNivel49");
        EstrellasNivel50 = PlayerPrefs.GetInt("EstrellasNivel50");
        EstrellasNivel51 = PlayerPrefs.GetInt("EstrellasNivel51");
        EstrellasNivel52 = PlayerPrefs.GetInt("EstrellasNivel52");
        EstrellasNivel53 = PlayerPrefs.GetInt("EstrellasNivel53");
        EstrellasNivel54 = PlayerPrefs.GetInt("EstrellasNivel54");
    }

    // Update is called once per frame
    void Update()
    {

        totalStars = EstrellasNivel37 + EstrellasNivel38 + EstrellasNivel39 + EstrellasNivel40 + EstrellasNivel41 + EstrellasNivel42 + EstrellasNivel43 + EstrellasNivel44 + EstrellasNivel45 + EstrellasNivel46 + EstrellasNivel47 + EstrellasNivel48 + EstrellasNivel49 + EstrellasNivel50 + EstrellasNivel51 + EstrellasNivel52 + EstrellasNivel53 + EstrellasNivel54;
        textoTotalStars.text = totalStars.ToString() + "/54";
    }
}

