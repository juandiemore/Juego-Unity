using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLevels : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    } // End Start

    // Update is called once per frame
    void Update()
    {

       
    }

    public void TapOnBack()
    {

        // Carga de la pantalla ScreenWelcome

        // 1. Eliminar la pantalla actual
        GameObject oldScreen = GameObject.Find("Canvas/ScreenLevels");
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
    }

    public void TapOnLevel1()
    {

        // Carga de la pantalla ScreenGame

        // 1. Eliminar la pantalla actual
        GameObject oldScreen = GameObject.Find("Canvas/ScreenLevels");
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


        // Cargamos el nivel 1
        GameObject newLevel = GameObject.Instantiate(Resources.Load("Levels/Level1") as GameObject);

        // Corregimos el nombre del nivel cargado
        newLevel.name = "Level1";
    }

    public void TapOnLevel2()
    {

        // Carga de la pantalla ScreenGame

        // 1. Eliminar la pantalla actual
        GameObject oldScreen = GameObject.Find("Canvas/ScreenLevels");
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


        // Cargamos el nivel 2
        GameObject newLevel = GameObject.Instantiate(Resources.Load("Levels/Level2") as GameObject);

        // Corregimos el nombre del nivel cargado
        newLevel.name = "Level2";
    }



}
