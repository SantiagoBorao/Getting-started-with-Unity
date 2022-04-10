using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleEnable : MonoBehaviour
{
    public InputActionReference toggleRef = null;

    private void Awake()
    {
        Debug.Log("Awake");
        toggleRef.action.started += Toggle;
    }

    private void OnDestroy()
    {
        toggleRef.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        Debug.Log("Toogle");
        bool bActive = !gameObject.activeSelf;
        gameObject.SetActive(bActive);
    }

}
