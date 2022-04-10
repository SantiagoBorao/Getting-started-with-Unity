using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorContact : MonoBehaviour
{
    // Update is called once per frame
    public void ChangeToBlack()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.black;
    }

    public void ChangeToWhite()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.white;
    }
}
