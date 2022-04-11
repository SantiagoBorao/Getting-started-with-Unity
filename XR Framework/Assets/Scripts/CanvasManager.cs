using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{

    public void ShowCanvas()
    {
        gameObject.SetActive(true);
    }

    public void HideCanvas()
    {
        gameObject.SetActive(false);
    }

    public void ToggleCanvas()
    {
        if (gameObject.activeSelf == true)
        {
            gameObject.SetActive(false);
        } else {
            gameObject.SetActive(true);
        }
    }
}

