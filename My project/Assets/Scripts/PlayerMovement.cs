using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce;

    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Instanciamos el objeto Rigidbody e indicamos que sera el del cubo
        _rigidbody = this.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Verifica que el cubo dejo el suelo, y no permite saltar nuevamente hasta que lo toque
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= 1.1 && transform.position.y >= 0 && _rigidbody.velocity.magnitude < 0.1)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce);
        }

        if(transform.position.y <= -20)
        {
            SceneManager.LoadScene("Game Over");
        }

    }

}
