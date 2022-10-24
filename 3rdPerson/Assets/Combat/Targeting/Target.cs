using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public event Action<Target> OnDestroyed;

    private void onDestroy()
    {
        if (OnDestroyed != null) { OnDestroyed.Invoke(this); }
        //OnDestroyed?.Invoke(this);
    }
}
