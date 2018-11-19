using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWelcome : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TapOnPlay()
    {

        // Carga de la pantalla ScreenLevels

        // 1. Eliminar la pantalla actual
        GameObject oldScreen = GameObject.Find("Canvas/ScreenWelcome");
        GameObject.Destroy(oldScreen);

        // 2. Cargamos la nueva pantalla
        GameObject newScreen = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenLevels") as GameObject);

        // 3. Obtenemos una referencia al canvas para meter la nueva pantalla adentro
        GameObject canvas = GameObject.Find("Canvas");

        // 4. Metemos la pantalla dentro de canvas
        newScreen.transform.SetParent(canvas.transform);

        // 5. Posicionamos correctamente la pantalla dentro del canvas
        newScreen.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
        newScreen.GetComponent<RectTransform>().localPosition = Vector2.zero;

        // 6. Corregimos el nombre de la nueva pantalla
        newScreen.name = "ScreenLevels";

    }

}
