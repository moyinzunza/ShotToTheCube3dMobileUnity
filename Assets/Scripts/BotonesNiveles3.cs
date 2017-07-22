using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesNiveles3 : MonoBehaviour {

    public GameObject botonBack;
    //public GameObject botonNext;//boton next aca funciona como back
    public GameObject MensajeFaltanEstrellas;
    int totalStars;

    public GameObject boton37;
    public GameObject Estrella1N37;
    public GameObject Estrella2N37;
    public GameObject Estrella3N37;
    int EstrellasNivel37;


    public GameObject boton38;
    public GameObject Estrella1N38;
    public GameObject Estrella2N38;
    public GameObject Estrella3N38;
    public GameObject candadoNivel38;
    int EstrellasNivel38;



    public GameObject boton39;
    public GameObject Estrella1N39;
    public GameObject Estrella2N39;
    public GameObject Estrella3N39;
    public GameObject candadoNivel39;
    int EstrellasNivel39;



    public GameObject boton40;
    public GameObject Estrella1N40;
    public GameObject Estrella2N40;
    public GameObject Estrella3N40;
    public GameObject candadoNivel40;
    int EstrellasNivel40;



    public GameObject boton41;
    public GameObject Estrella1N41;
    public GameObject Estrella2N41;
    public GameObject Estrella3N41;
    public GameObject candadoNivel41;
    int EstrellasNivel41;



    public GameObject boton42;
    public GameObject Estrella1N42;
    public GameObject Estrella2N42;
    public GameObject Estrella3N42;
    public GameObject candadoNivel42;
    int EstrellasNivel42;


    public GameObject boton43;
    public GameObject Estrella1N43;
    public GameObject Estrella2N43;
    public GameObject Estrella3N43;
    public GameObject candadoNivel43;
    int EstrellasNivel43;



    public GameObject boton44;
    public GameObject Estrella1N44;
    public GameObject Estrella2N44;
    public GameObject Estrella3N44;
    public GameObject candadoNivel44;
    int EstrellasNivel44;



    public GameObject boton45;
    public GameObject Estrella1N45;
    public GameObject Estrella2N45;
    public GameObject Estrella3N45;
    public GameObject candadoNivel45;
    int EstrellasNivel45;



    public GameObject boton46;
    public GameObject Estrella1N46;
    public GameObject Estrella2N46;
    public GameObject Estrella3N46;
    public GameObject candadoNivel46;
    int EstrellasNivel46;




    public GameObject boton47;
    public GameObject Estrella1N47;
    public GameObject Estrella2N47;
    public GameObject Estrella3N47;
    public GameObject candadoNivel47;
    int EstrellasNivel47;




    public GameObject boton48;
    public GameObject Estrella1N48;
    public GameObject Estrella2N48;
    public GameObject Estrella3N48;
    public GameObject candadoNivel48;
    int EstrellasNivel48;



    public GameObject boton49;
    public GameObject Estrella1N49;
    public GameObject Estrella2N49;
    public GameObject Estrella3N49;
    public GameObject candadoNivel49;
    int EstrellasNivel49;



    public GameObject boton50;
    public GameObject Estrella1N50;
    public GameObject Estrella2N50;
    public GameObject Estrella3N50;
    public GameObject candadoNivel50;
    int EstrellasNivel50;



    public GameObject boton51;
    public GameObject Estrella1N51;
    public GameObject Estrella2N51;
    public GameObject Estrella3N51;
    public GameObject candadoNivel51;
    int EstrellasNivel51;


    public GameObject boton52;
    public GameObject Estrella1N52;
    public GameObject Estrella2N52;
    public GameObject Estrella3N52;
    public GameObject candadoNivel52;
    int EstrellasNivel52;


    public GameObject boton53;
    public GameObject Estrella1N53;
    public GameObject Estrella2N53;
    public GameObject Estrella3N53;
    public GameObject candadoNivel53;
    int EstrellasNivel53;


    public GameObject boton54;
    public GameObject Estrella1N54;
    public GameObject Estrella2N54;
    public GameObject Estrella3N54;
    public GameObject candadoNivel54;
    int EstrellasNivel54;
    
    //public GameObject mensajeGooglePlay;
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

        if (EstrellasNivel37 == 3)
        {
            Estrella1N37.SetActive(false);
            Estrella2N37.SetActive(false);
            Estrella3N37.SetActive(false);
        }
        if (EstrellasNivel37 == 2)
        {
            Estrella1N37.SetActive(false);
            Estrella2N37.SetActive(false);
        }
        if (EstrellasNivel37 == 1)
        {
            Estrella1N37.SetActive(false);
        }

        if (EstrellasNivel37 >= 1)
        {
            candadoNivel38.SetActive(false);
        }




        if (EstrellasNivel38 == 3)
        {
            Estrella1N38.SetActive(false);
            Estrella2N38.SetActive(false);
            Estrella3N38.SetActive(false);
        }
        if (EstrellasNivel38 == 2)
        {
            Estrella1N38.SetActive(false);
            Estrella2N38.SetActive(false);
        }
        if (EstrellasNivel38 == 1)
        {
            Estrella1N38.SetActive(false);
        }

        if (EstrellasNivel38 >= 1)
        {
            candadoNivel39.SetActive(false);
        }


        if (EstrellasNivel39 == 3)
        {
            Estrella1N39.SetActive(false);
            Estrella2N39.SetActive(false);
            Estrella3N39.SetActive(false);
        }
        if (EstrellasNivel39 == 2)
        {
            Estrella1N39.SetActive(false);
            Estrella2N39.SetActive(false);
        }
        if (EstrellasNivel39 == 1)
        {
            Estrella1N39.SetActive(false);
        }

        if (EstrellasNivel39 >= 1)
        {
            candadoNivel40.SetActive(false);
        }



        if (EstrellasNivel40 == 3)
        {
            Estrella1N40.SetActive(false);
            Estrella2N40.SetActive(false);
            Estrella3N40.SetActive(false);
        }
        if (EstrellasNivel40 == 2)
        {
            Estrella1N40.SetActive(false);
            Estrella2N40.SetActive(false);
        }
        if (EstrellasNivel40 == 1)
        {
            Estrella1N40.SetActive(false);
        }

        if (EstrellasNivel40 >= 1)
        {
            candadoNivel41.SetActive(false);
        }




        if (EstrellasNivel41 == 3)
        {
            Estrella1N41.SetActive(false);
            Estrella2N41.SetActive(false);
            Estrella3N41.SetActive(false);
        }
        if (EstrellasNivel41 == 2)
        {
            Estrella1N41.SetActive(false);
            Estrella2N41.SetActive(false);
        }
        if (EstrellasNivel41 == 1)
        {
            Estrella1N41.SetActive(false);
        }

        if (EstrellasNivel41 >= 1)
        {
            candadoNivel42.SetActive(false);
        }



        if (EstrellasNivel42 == 3)
        {
            Estrella1N42.SetActive(false);
            Estrella2N42.SetActive(false);
            Estrella3N42.SetActive(false);
        }
        if (EstrellasNivel42 == 2)
        {
            Estrella1N42.SetActive(false);
            Estrella2N42.SetActive(false);
        }
        if (EstrellasNivel42 == 1)
        {
            Estrella1N42.SetActive(false);
        }

        if (EstrellasNivel42 >= 1)
        {
            candadoNivel43.SetActive(false);
        }



        if (EstrellasNivel43 == 3)
        {
            Estrella1N43.SetActive(false);
            Estrella2N43.SetActive(false);
            Estrella3N43.SetActive(false);
        }
        if (EstrellasNivel43 == 2)
        {
            Estrella1N43.SetActive(false);
            Estrella2N43.SetActive(false);
        }
        if (EstrellasNivel43 == 1)
        {
            Estrella1N43.SetActive(false);
        }

        if (EstrellasNivel43 >= 1)
        {
            candadoNivel44.SetActive(false);
        }



        if (EstrellasNivel44 == 3)
        {
            Estrella1N44.SetActive(false);
            Estrella2N44.SetActive(false);
            Estrella3N44.SetActive(false);
        }
        if (EstrellasNivel44 == 2)
        {
            Estrella1N44.SetActive(false);
            Estrella2N44.SetActive(false);
        }
        if (EstrellasNivel44 == 1)
        {
            Estrella1N44.SetActive(false);
        }

        if (EstrellasNivel44 >= 1)
        {
            candadoNivel45.SetActive(false);
        }




        if (EstrellasNivel45 == 3)
        {
            Estrella1N45.SetActive(false);
            Estrella2N45.SetActive(false);
            Estrella3N45.SetActive(false);
        }
        if (EstrellasNivel45 == 2)
        {
            Estrella1N45.SetActive(false);
            Estrella2N45.SetActive(false);
        }
        if (EstrellasNivel45 == 1)
        {
            Estrella1N45.SetActive(false);
        }

        if (EstrellasNivel45 >= 1)
        {
            candadoNivel46.SetActive(false);
        }




        if (EstrellasNivel46 == 3)
        {
            Estrella1N46.SetActive(false);
            Estrella2N46.SetActive(false);
            Estrella3N46.SetActive(false);
        }
        if (EstrellasNivel46 == 2)
        {
            Estrella1N46.SetActive(false);
            Estrella2N46.SetActive(false);
        }
        if (EstrellasNivel46 == 1)
        {
            Estrella1N46.SetActive(false);
        }

        if (EstrellasNivel46 >= 1)
        {
            candadoNivel47.SetActive(false);
        }



        if (EstrellasNivel47 == 3)
        {
            Estrella1N47.SetActive(false);
            Estrella2N47.SetActive(false);
            Estrella3N47.SetActive(false);
        }
        if (EstrellasNivel47 == 2)
        {
            Estrella1N47.SetActive(false);
            Estrella2N47.SetActive(false);
        }
        if (EstrellasNivel47 == 1)
        {
            Estrella1N47.SetActive(false);
        }

        if (EstrellasNivel47 >= 1)
        {
            candadoNivel48.SetActive(false);
        }



        if (EstrellasNivel48 == 3)
        {
            Estrella1N48.SetActive(false);
            Estrella2N48.SetActive(false);
            Estrella3N48.SetActive(false);
        }
        if (EstrellasNivel48 == 2)
        {
            Estrella1N48.SetActive(false);
            Estrella2N48.SetActive(false);
        }
        if (EstrellasNivel48 == 1)
        {
            Estrella1N48.SetActive(false);
        }

        if (EstrellasNivel48 >= 1)
        {
            candadoNivel49.SetActive(false);
        }


        if (EstrellasNivel49 == 3)
        {
            Estrella1N49.SetActive(false);
            Estrella2N49.SetActive(false);
            Estrella3N49.SetActive(false);
        }
        if (EstrellasNivel49 == 2)
        {
            Estrella1N49.SetActive(false);
            Estrella2N49.SetActive(false);
        }
        if (EstrellasNivel49 == 1)
        {
            Estrella1N49.SetActive(false);
        }

        if (EstrellasNivel49 >= 1)
        {
            candadoNivel50.SetActive(false);
        }


        if (EstrellasNivel50 == 3)
        {
            Estrella1N50.SetActive(false);
            Estrella2N50.SetActive(false);
            Estrella3N50.SetActive(false);
        }
        if (EstrellasNivel50 == 2)
        {
            Estrella1N50.SetActive(false);
            Estrella2N50.SetActive(false);
        }
        if (EstrellasNivel50 == 1)
        {
            Estrella1N50.SetActive(false);
        }

        if (EstrellasNivel50 >= 1)
        {
            candadoNivel51.SetActive(false);
        }



        if (EstrellasNivel51 == 3)
        {
            Estrella1N51.SetActive(false);
            Estrella2N51.SetActive(false);
            Estrella3N51.SetActive(false);
        }
        if (EstrellasNivel51 == 2)
        {
            Estrella1N51.SetActive(false);
            Estrella2N51.SetActive(false);
        }
        if (EstrellasNivel51 == 1)
        {
            Estrella1N51.SetActive(false);
        }

        if (EstrellasNivel51 >= 1)
        {
            candadoNivel52.SetActive(false);
        }



        if (EstrellasNivel52 == 3)
        {
            Estrella1N52.SetActive(false);
            Estrella2N52.SetActive(false);
            Estrella3N52.SetActive(false);
        }
        if (EstrellasNivel52 == 2)
        {
            Estrella1N52.SetActive(false);
            Estrella2N52.SetActive(false);
        }
        if (EstrellasNivel52 == 1)
        {
            Estrella1N52.SetActive(false);
        }

        if (EstrellasNivel52 >= 1)
        {
            candadoNivel53.SetActive(false);
        }



        if (EstrellasNivel53 == 3)
        {
            Estrella1N53.SetActive(false);
            Estrella2N53.SetActive(false);
            Estrella3N53.SetActive(false);
        }
        if (EstrellasNivel53 == 2)
        {
            Estrella1N53.SetActive(false);
            Estrella2N53.SetActive(false);
        }
        if (EstrellasNivel53 == 1)
        {
            Estrella1N53.SetActive(false);
        }

        if (EstrellasNivel53 >= 1)
        {
            candadoNivel54.SetActive(false);
        }



        if (EstrellasNivel54 == 3)
        {
            Estrella1N54.SetActive(false);
            Estrella2N54.SetActive(false);
            Estrella3N54.SetActive(false);
        }
        if (EstrellasNivel54 == 2)
        {
            Estrella1N54.SetActive(false);
            Estrella2N54.SetActive(false);
        }
        if (EstrellasNivel54 == 1)
        {
            Estrella1N54.SetActive(false);
        }

        if (EstrellasNivel54 >= 1)
        {
            //candadoNivel16.SetActive(false);
        }


        // creamos un rayo que va desde la cámara hacia el punto de la pantalla donde está el mouse.
        Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        //comprobamos si el player ha hecho click
        if (Input.GetMouseButtonDown(0))
        { //si el player ha hecho click
            RaycastHit hit; //llamamos al rayo casteado 'hit'.
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {



                if (hit.transform == botonBack.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {


                    botonBack.GetComponent<AudioSource>().Play();

                    Invoke("BotonMenu", botonBack.GetComponent<AudioSource>().clip.length);


                }

                /*
                if (hit.transform == botonNext.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {


                    botonNext.GetComponent<AudioSource>().Play();

                    Invoke("BotonNext", botonNext.GetComponent<AudioSource>().clip.length);


                }

                */


                if (hit.transform == boton37.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {

                    boton37.GetComponent<AudioSource>().Play();
                    Invoke("Nivel37", boton37.GetComponent<AudioSource>().clip.length);

                }

                if (hit.transform == boton38.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel37 >= 1)
                    {

                        boton38.GetComponent<AudioSource>().Play();

                        Invoke("Nivel38", boton38.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton39.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel38 >= 1)
                    {

                        boton39.GetComponent<AudioSource>().Play();

                        Invoke("Nivel39", boton39.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton40.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel39 >= 1)
                    {

                        boton40.GetComponent<AudioSource>().Play();

                        Invoke("Nivel40", boton40.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton41.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel40 >= 1)
                    {

                        boton41.GetComponent<AudioSource>().Play();

                        Invoke("Nivel41", boton41.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton42.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel41 >= 1)
                    {

                        boton42.GetComponent<AudioSource>().Play();

                        Invoke("Nivel42", boton42.GetComponent<AudioSource>().clip.length);
                    }

                }


                if (hit.transform == boton43.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel42 >= 1)
                    {

                        boton43.GetComponent<AudioSource>().Play();

                        Invoke("Nivel43", boton43.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton44.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel43 >= 1)
                    {

                        boton44.GetComponent<AudioSource>().Play();

                        Invoke("Nivel44", boton44.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton45.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel44 >= 1)
                    {

                        boton45.GetComponent<AudioSource>().Play();

                        Invoke("Nivel45", boton45.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton46.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel45 >= 1)
                    {

                        boton46.GetComponent<AudioSource>().Play();

                        Invoke("Nivel46", boton46.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton47.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel46 >= 1)
                    {

                        boton47.GetComponent<AudioSource>().Play();

                        Invoke("Nivel47", boton47.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton48.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel47 >= 1)
                    {

                        boton48.GetComponent<AudioSource>().Play();

                        Invoke("Nivel48", boton48.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton49.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel47 >= 1)
                    {

                        boton49.GetComponent<AudioSource>().Play();

                        Invoke("Nivel49", boton49.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton50.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel49 >= 1)
                    {

                        boton50.GetComponent<AudioSource>().Play();

                        Invoke("Nivel50", boton50.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton51.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel50 >= 1)
                    {

                        boton51.GetComponent<AudioSource>().Play();

                        Invoke("Nivel51", boton51.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton52.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel51 >= 1)
                    {

                        boton52.GetComponent<AudioSource>().Play();

                        Invoke("Nivel52", boton52.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton53.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel52 >= 1)
                    {

                        boton53.GetComponent<AudioSource>().Play();

                        Invoke("Nivel53", boton53.GetComponent<AudioSource>().clip.length);
                    }

                }

                if (hit.transform == boton54.transform)//si la posición (nodo transform) del rayo coincide con la del collider de nuestro objeto
                {
                    if (EstrellasNivel53 >= 1)
                    {

                        boton54.GetComponent<AudioSource>().Play();

                        Invoke("Nivel54", boton54.GetComponent<AudioSource>().clip.length);
                    }

                }
            }
        }

    }
    void BotonMenu()
    {
        SceneManager.LoadScene("Niveles2Scene");
    }

    void BotonNext()
    {
        if (totalStars < 45)
        {
            MensajeFaltanEstrellas.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Nivels3Scene");
        }
    }

    void Nivel37()
    {
        PlayerPrefs.SetInt("NivelActual", 37);
        SceneManager.LoadScene("GameScene37");
    }
    void Nivel38()
    {
        PlayerPrefs.SetInt("NivelActual", 38);
        SceneManager.LoadScene("GameScene38");
    }
    void Nivel39()
    {
        PlayerPrefs.SetInt("NivelActual", 39);
        SceneManager.LoadScene("GameScene39");
    }
    void Nivel40()
    {
        PlayerPrefs.SetInt("NivelActual", 40);
        SceneManager.LoadScene("GameScene40");
    }
    void Nivel41()
    {
        PlayerPrefs.SetInt("NivelActual", 41);
        SceneManager.LoadScene("GameScene41");
    }
    void Nivel42()
    {
        PlayerPrefs.SetInt("NivelActual", 42);
        SceneManager.LoadScene("GameScene42");
    }
    void Nivel43()
    {
        PlayerPrefs.SetInt("NivelActual", 43);
        SceneManager.LoadScene("GameScene43");
    }
    void Nivel44()
    {
        PlayerPrefs.SetInt("NivelActual", 44);
        SceneManager.LoadScene("GameScene44");
    }
    void Nivel45()
    {
        PlayerPrefs.SetInt("NivelActual", 45);
        SceneManager.LoadScene("GameScene45");
    }
    void Nivel46()
    {
        PlayerPrefs.SetInt("NivelActual", 46);
        SceneManager.LoadScene("GameScene46");
    }
    void Nivel47()
    {
        PlayerPrefs.SetInt("NivelActual", 47);
        SceneManager.LoadScene("GameScene47");
    }
    void Nivel48()
    {
        PlayerPrefs.SetInt("NivelActual", 48);
        SceneManager.LoadScene("GameScene48");
    }
    void Nivel49()
    {
        PlayerPrefs.SetInt("NivelActual", 49);
        SceneManager.LoadScene("GameScene49");
    }
    void Nivel50()
    {
        PlayerPrefs.SetInt("NivelActual", 50);
        SceneManager.LoadScene("GameScene50");
    }
    void Nivel51()
    {
        PlayerPrefs.SetInt("NivelActual", 51);
        SceneManager.LoadScene("GameScene51");
    }
    void Nivel52()
    {
        PlayerPrefs.SetInt("NivelActual", 52);
        SceneManager.LoadScene("GameScene52");
    }
    void Nivel53()
    {
        PlayerPrefs.SetInt("NivelActual", 53);
        SceneManager.LoadScene("GameScene53");
    }
    void Nivel54()
    {
        PlayerPrefs.SetInt("NivelActual", 54);
        SceneManager.LoadScene("GameScene54");
    }

    
    
}
