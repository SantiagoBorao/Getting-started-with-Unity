using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCollision : MonoBehaviour
{
    bool white = true;

    //Recibe un GameObjet, si su color no es blanco, va al componente ChangeColor de ese GameObjet y lo pone a blanco.
    //Sino, a negro.
    private void ChangeColor(GameObject go)
    {
        if(!white)
        {
            go.GetComponent<ChangeColor>().ChangeToWhite();
            white = true;
        }
        else
        {
            go.GetComponent<ChangeColor>().ChangeToBlack();
            white = false;
        }
    }


    //Es llamado cada vez que el objeto que lleva este script colisiona con otro objeto de la escena
    //Cuando un objeto colisiona con el script, obtenemos una referencia al objeto y le cambiamos el color.
    void OnCollisionEnter(Collision collision)
    {
       Debug.Log("Entra en OnCollisionerEnter");

       GameObject go = collision.gameObject;
       ChangeColor(go);
    }

    //Similar pero ignorará la colisión.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entra en OnTriggerEnter");
        
        GameObject go = other.gameObject;
        ChangeColor(go);
    }
}