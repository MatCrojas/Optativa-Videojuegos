using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingState : PlatformBaseState
{

    private float timer = 5f;

    public RotatingState(PlatformStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        
    }
    public override void Tick(float deltaTime)
    {

        timer -= deltaTime;

        if (timer <= 0)
        {
            stateMachine.SwitchState(new MovementState(stateMachine));
        }

        stateMachine.transform.Rotate(
            Vector3.up, 5f * deltaTime);


    }

    public override void Exit()
    {
        
    }

}
