using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public float difficult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * difficult);

        difficult += Time.deltaTime * difficult;

        if(transform.position.z <= -10)
        {
            Destroy(gameObject);
        }
    }

}
