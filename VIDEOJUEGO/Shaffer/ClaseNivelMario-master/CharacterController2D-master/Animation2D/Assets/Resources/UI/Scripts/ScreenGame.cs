using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenGame : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {

            // Carga de la pantalla ScreenGame

            // 1. Eliminar la pantalla actual

            // 2. Cargamos la nueva pantalla
            GameObject newScreen = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenPausa") as GameObject);

            // 3. Obtenemos una referencia al canvas para meter la nueva pantalla adentro
            GameObject canvas = GameObject.Find("Canvas");

            // 4. Metemos la pantalla dentro de canvas
            newScreen.transform.SetParent(canvas.transform);

            // 5. Posicionamos correctamente la pantalla dentro del canvas
            newScreen.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
            newScreen.GetComponent<RectTransform>().localPosition = Vector2.zero;

            // 6. Corregimos el nombre de la nueva pantalla
            newScreen.name = "ScreenPausa";



        }
    }

    public void TapOnPause()
    {

        // Carga de la pantalla ScreenPause

        // 1. Eliminar la pantalla actual
        GameObject oldScreen = GameObject.Find("Canvas/ScreenGame");
        GameObject.Destroy(oldScreen);

        // 2. Cargamos la nueva pantalla
        GameObject newScreen = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenPause") as GameObject);

        // 3. Obtenemos una referencia al canvas para meter la nueva pantalla adentro
        GameObject canvas = GameObject.Find("Canvas");

        // 4. Metemos la pantalla dentro de canvas
        newScreen.transform.SetParent(canvas.transform);

        // 5. Posicionamos correctamente la pantalla dentro del canvas
        newScreen.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
        newScreen.GetComponent<RectTransform>().localPosition = Vector2.zero;

        // 6. Corregimos el nombre de la nueva pantalla
        newScreen.name = "ScreenPause";

        //pausar musica de fondo
        //GameObject.Find("Music").GetComponent<AudioSource>().time = 0;
    }

    public void TapOnJump()
    {
        Debug.Log("Tap en el boton Jump");
    }
}
