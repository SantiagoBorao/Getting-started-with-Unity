using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Resize : MonoBehaviour
{
    public InputActionReference resizeRef = null;

    // Update is called once per frame
    void Update()
    {
        Vector2 vector2Val = resizeRef.action.ReadValue<Vector2>();

        if (vector2Val.x < -0.5f)
        {
            ChangeSize(true);
        } else if (vector2Val.x  > 0.5f)
        {
            ChangeSize(false);
        }

    }

    void ChangeSize(bool increase)
    {
        if (increase)
        {
                gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        } else
        {
                gameObject.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);

        }
    }
}