using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Recupera el objeto al que hace referencia y le cambia su posición
            gameObject.transform.Translate(0, 1, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(1, 0, 0);
        }
        
    }
}