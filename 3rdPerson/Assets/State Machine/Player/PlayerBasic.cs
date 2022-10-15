using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBasic : MonoBehaviour, Controls.IPlayerActions
{
    // Start is called before the first frame update
    private Controls controls;
    private CharacterController caracterController;
    private Vector2 inputDirection;
    private Vector3 movementDirection;
    private Animator animator;

    private float rotationDumping = 0.3f;
    private float animationDumping = 0.03f;
    private int blendHash = Animator.StringToHash("Blend");


    void Start()
    {
        controls = new Controls();
        controls.Player.SetCallbacks(this);
        controls.Player.Enable();

        caracterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        movementDirection = new Vector3(
                inputDirection.x,
                0f,
                inputDirection.y
            );
        */

        movementDirection = CalculateMovement();

        caracterController.Move(movementDirection * 5 * Time.deltaTime);

        if (inputDirection.magnitude != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation,
                Quaternion.LookRotation(movementDirection), rotationDumping);
            animator.SetFloat(blendHash , 1, animationDumping, Time.deltaTime);
        } else
        {
            animator.SetFloat(blendHash, 0, animationDumping, Time.deltaTime);
        }


     }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputDirection = context.ReadValue<Vector2>();
    }

    public Vector3 CalculateMovement()
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 rigth = Camera.main.transform.right;

        forward.y = 0f;
        rigth.y = 0f;

        forward.Normalize();
        rigth.Normalize();

        return forward * inputDirection.y +
            rigth * inputDirection.x;
    }

    public void OnTarget(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnCancel(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
