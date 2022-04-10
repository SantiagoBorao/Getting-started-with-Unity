using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{

    public void ToggleCanvas(){
        
        if (gameObject.activeSelf == true)
        {
           gameObject.SetActive(false);
        } else {
           gameObject.SetActive(true);
        }
    }

}

