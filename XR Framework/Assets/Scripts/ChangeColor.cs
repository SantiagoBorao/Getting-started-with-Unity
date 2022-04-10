using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeColor : MonoBehaviour
{

    public void ChangeToBlack(){
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.black;
    }

    public void ChangeToWhite(){
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.white;
    }

    public void ChangeToBlackInt(XRBaseInteractor obj){
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.black;
    }

    public void ChangeToWhiteInt(XRBaseInteractor obj){
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.white;
    }

}
