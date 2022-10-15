using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformInputReading : MonoBehaviour, PlatformControl.IPlatformActions
{
    private PlatformControl controls;
    public event Action moveEvent;

    // Start is called before the first frame update
    void Start()
    {
        controls = new PlatformControl();
        controls.Platform.Enable();
        controls.Platform.SetCallbacks(this);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveEvent?.Invoke();
    }

    public void OnRotateX(InputAction.CallbackContext context)
    {
        
    }

    public void OnRotateY(InputAction.CallbackContext context)
    {
        
    }

}
