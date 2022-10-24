using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEventCube : MonoBehaviour
{

    public ButtonPressed ButtonPressed;

    [SerializeField]
    private float distance = 0f;
    [SerializeField]
    private bool move = false;
    [SerializeField]
    private float velocity = 1f;

    // Start is called before the first frame update
    void Start()
    {

        ButtonPressed.onPushed += Movement;
        ButtonPressed.onNotPushed += Stop;

    }

    private void Movement()
    {
        move = true; 
    }

    private void Stop()
    {
        move = false;
    }


    private void Update()
    {
        if (move)
        {
            distance += Time.deltaTime;
            transform.Translate(new Vector3(Time.deltaTime * velocity, 0, 0));
        }

        if (!move && distance > 0)
        {
            distance -= Time.deltaTime;
            transform.Translate(new Vector3(-Time.deltaTime * velocity, 0, 0));
        }
        
    }

}
