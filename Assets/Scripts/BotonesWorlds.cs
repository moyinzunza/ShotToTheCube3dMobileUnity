using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesWorlds : MonoBehaviour {

    public GameObject MensajeFaltanEstrellas;
    public GameObject BotonMain;
    public GameObject BotonWorld1;
    public TextMesh textWorld1;
    public GameObject BotonWorld2;
    public GameObject candado2;
    public TextMesh textWorld2;
    public GameObject BotonWorld3;
    public GameObject candado3;
    public TextMesh textWorld3;

    int EstrellasNivel1, EstrellasNivel2, EstrellasNivel3, EstrellasNivel4, EstrellasNivel5, EstrellasNivel6, EstrellasNivel7, EstrellasNivel8, EstrellasNivel9, EstrellasNivel10, EstrellasNivel11, EstrellasNivel12, EstrellasNivel13, EstrellasNivel14, EstrellasNivel15, EstrellasNivel16, EstrellasNivel17, EstrellasNivel18;
    int EstrellasNivel19, EstrellasNivel20, EstrellasNivel21, EstrellasNivel22, EstrellasNivel23, EstrellasNivel24, EstrellasNivel25, EstrellasNivel26, EstrellasNivel27, EstrellasNivel28, EstrellasNivel29, EstrellasNivel30, EstrellasNivel31, EstrellasNivel32, EstrellasNivel33, EstrellasNivel34, EstrellasNivel35, EstrellasNivel36;
    int EstrellasNivel37, EstrellasNivel38, EstrellasNivel39, EstrellasNivel40, EstrellasNivel41, EstrellasNivel42, EstrellasNivel43, EstrellasNivel44, EstrellasNivel45, EstrellasNivel46, EstrellasNivel47, EstrellasNivel48, EstrellasNivel49, EstrellasNivel50, EstrellasNivel51, EstrellasNivel52, EstrellasNivel53, EstrellasNivel54;
    int EstrellasWorld1, EstrellasWorld2, EstrellasWorld3;
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

        EstrellasWorld1 = EstrellasNivel1 + EstrellasNivel2 + EstrellasNivel3 + EstrellasNivel4 + EstrellasNivel5 + EstrellasNivel6 + EstrellasNivel7 + EstrellasNivel8 + EstrellasNivel9 + EstrellasNivel10 + EstrellasNivel11 + EstrellasNivel12 + EstrellasNivel13 + EstrellasNivel14 + EstrellasNivel15 + EstrellasNivel16 + EstrellasNivel17 + EstrellasNivel18;
        textWorld1.text = EstrellasWorld1 + "/54";
        if (EstrellasWorld1 >= 45) {
            candado2.SetActive(false);
        }

        EstrellasWorld2 = EstrellasNivel19 + EstrellasNivel20 + EstrellasNivel21 + EstrellasNivel22 + EstrellasNivel23 + EstrellasNivel24 + EstrellasNivel25 + EstrellasNivel26 + EstrellasNivel27 + EstrellasNivel28 + EstrellasNivel29 + EstrellasNivel30 + EstrellasNivel31 + EstrellasNivel32 + EstrellasNivel33 + EstrellasNivel34 + EstrellasNivel35 + EstrellasNivel36;
        textWorld2.text = EstrellasWorld2 + "/54";
        if (EstrellasWorld2 >= 45) {
            candado3.SetActive(false);
        }
        
        EstrellasWorld3 = EstrellasNivel37 + EstrellasNivel38 + EstrellasNivel39 + EstrellasNivel40 + EstrellasNivel41 + EstrellasNivel42 + EstrellasNivel43 + EstrellasNivel44 + EstrellasNivel45 + EstrellasNivel46 + EstrellasNivel47 + EstrellasNivel48 + EstrellasNivel49 + EstrellasNivel50 + EstrellasNivel51 + EstrellasNivel52 + EstrellasNivel53 + EstrellasNivel54;
        textWorld3.text = EstrellasWorld3 + "/54";

    }

    // Update is called once per frame
    void Update () {

        // creamos un rayo que va desde la cámara hacia el punto de la pantalla donde está el mouse.
        Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        //comprobamos si el player ha hecho click
        if (Input.GetMouseButtonDown(0))
        { //si el player ha hecho click
            RaycastHit hit; //llamamos al rayo casteado 'hit'.
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {


                if (hit.transform == BotonMain.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    
                    BotonMain.GetComponent<AudioSource>().Play();
                    Invoke("goToMain", BotonMain.GetComponent<AudioSource>().clip.length);

                }
                if (hit.transform == BotonWorld1.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    
                    BotonWorld1.GetComponent<AudioSource>().Play();
                    Invoke("goToLevels1", BotonWorld1.GetComponent<AudioSource>().clip.length);

                }
                if (hit.transform == BotonWorld2.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    BotonWorld2.GetComponent<AudioSource>().Play();
                    Invoke("goToLevels2", BotonWorld2.GetComponent<AudioSource>().clip.length);

                }
                if (hit.transform == BotonWorld3.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    BotonWorld3.GetComponent<AudioSource>().Play();
                    Invoke("goToLevels3", BotonWorld3.GetComponent<AudioSource>().clip.length);

                }
            }
        }

    }

    void goToMain()
    {
        //admob.DestroyBanner();
        SceneManager.LoadScene("MainScene");
    }
    void goToLevels1()
    {
        SceneManager.LoadScene("Nivels");
    }
    void goToLevels2()
    {
        if (EstrellasWorld1 < 45)
        {
            MensajeFaltanEstrellas.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Niveles2Scene");
        }
    }
    void goToLevels3()
    {
        if (EstrellasWorld2 < 45)
        {
            MensajeFaltanEstrellas.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Niveles3Scene");
        }
    }

}
