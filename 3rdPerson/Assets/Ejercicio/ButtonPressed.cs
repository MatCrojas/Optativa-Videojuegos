using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{

    public event Action onPushed;

    public event Action onNotPushed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            onPushed?.Invoke();
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            onNotPushed?.Invoke();
        }
        
    }

}
