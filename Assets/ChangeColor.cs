using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Todas los scripts extienden de MonoBehaviour
public class ChangeColor : MonoBehaviour
{

public void ChangeToBlack()
{
    //gameObject en minúsucla hace referencia al objeto en el que se encuentra el objeto, en este caso la esfera.
    //En este caso estamos obteniendo el Renderer del objeto en cuestión
    Renderer rend = gameObject.GetComponent<Renderer>();
    rend.material.color = Color.black;
}

public void ChangeToWhite()
{
    Renderer rend = gameObject.GetComponent<Renderer>();
    rend.material.color = Color.white;
}

    //Update is called once per frame
    //Se llama cada frame
    void Update()
    {
        //Devuelve true cuando se pulsa una vez la tecla
        if(Input.GetKeyDown(KeyCode.B))
        {
            ChangeToBlack();
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            ChangeToWhite();
        }
        
    }
}