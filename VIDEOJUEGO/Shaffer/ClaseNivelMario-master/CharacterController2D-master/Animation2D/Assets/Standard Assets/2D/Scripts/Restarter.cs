using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                GameObject oldScreen = GameObject.Find("Level1");
                GameObject.Destroy(oldScreen);
                GameObject newScreen = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenPerdiste") as GameObject);
                GameObject canvas = GameObject.Find("Canvas");
      //          newScreen.transform.SetParent(canvas.transform);

                // 5. Posicionamos correctamente la pantalla dentro del canvas
                newScreen.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
                newScreen.GetComponent<RectTransform>().localPosition = Vector2.zero;

                // 6. Corregimos el nombre de la nueva pantalla
                newScreen.name = "ScreenPerdiste";
            }
        }
      
    }
}
