using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewBall : MonoBehaviour
{
    //Variable pública a la que podremos hacer referencia desde el inspector.
    //Podemos seleccionar un GameObject que no sea este mismo.
    public GameObject myPrefab;

    void Update()
    {
        GameObject myInstance;
        if (Input.GetKeyDown(KeyCode.N))
        {
            //Instancia el prefab que se le pase.
            myInstance = Instantiate(myPrefab);
            myInstance.transform.position = new Vector3(Random.Range(-2.0f, 2.0f),
                                                        gameObject.transform.position.y,
                                                        gameObject.transform.position.z);
        }
    }

}