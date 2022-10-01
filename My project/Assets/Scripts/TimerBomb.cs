using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBomb : MonoBehaviour
{

    [SerializeField]
    private float _bomb = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Error en el codigo, iniciando autodestruccion...");
    }

    // Update is called once per frame
    void Update()
    {

        if (_bomb >= 0)
        {
            _bomb -= Time.deltaTime;
            Debug.Log(Math.Round(_bomb) + "...");
        }
        else
        {
            Debug.Log("¡BOOM!");
            this.enabled = false;
        }

    }
}
