using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{

    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private bool left = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!left)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= 5) left = !left;
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= -5) left = !left;
        }
        
    }
}
