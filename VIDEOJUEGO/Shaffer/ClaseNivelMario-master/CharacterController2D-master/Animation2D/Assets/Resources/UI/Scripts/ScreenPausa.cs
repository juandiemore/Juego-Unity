using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPausa : MonoBehaviour {


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TapOnContinuar()
    {

        // Carga de la pantalla ScreenGame

        // 1. Eliminar la pantalla actual
        GameObject oldScreen = GameObject.Find("Canvas/ScreenPausa");
        GameObject.Destroy(oldScreen);

        // 2. Cargamos la nueva pantalla
        GameObject newScreen = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenGame") as GameObject);

        // 3. Obtenemos una referencia al canvas para meter la nueva pantalla adentro
        GameObject canvas = GameObject.Find("Canvas");

        // 4. Metemos la pantalla dentro de canvas
        newScreen.transform.SetParent(canvas.transform);

        // 5. Posicionamos correctamente la pantalla dentro del canvas
        newScreen.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
        newScreen.GetComponent<RectTransform>().localPosition = Vector2.zero;

        // 6. Corregimos el nombre de la nueva pantalla
        newScreen.name = "ScreenGame";
    }

    public void TapOnSalir()
    {

        // Carga de la pantalla ScreenWelcome

        // 1. Eliminar la pantalla actual
        GameObject oldScreen = GameObject.Find("Canvas/ScreenPausa");
        GameObject.Destroy(oldScreen);

        // 2. Cargamos la nueva pantalla
        GameObject newScreen = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenWelcome") as GameObject);

        // 3. Obtenemos una referencia al canvas para meter la nueva pantalla adentro
        GameObject canvas = GameObject.Find("Canvas");

        // 4. Metemos la pantalla dentro de canvas
        newScreen.transform.SetParent(canvas.transform);

        // 5. Posicionamos correctamente la pantalla dentro del canvas
        newScreen.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
        newScreen.GetComponent<RectTransform>().localPosition = Vector2.zero;

        // 6. Corregimos el nombre de la nueva pantalla
        newScreen.name = "ScreenWelcome";
        //reiniciar musica
        //GameObject.Find("Music").GetComponent<AudioSource>().time = 0;
    }
}

    
   

    //public void TapOnReiniciar()
   // {

   //     Debug.Log("Tap en el boton Reiniciar");
  //  }
//}
