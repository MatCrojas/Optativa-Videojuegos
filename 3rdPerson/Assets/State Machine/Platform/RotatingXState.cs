using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingXState : PlatformBaseState
{

    private float timer = 5f;

    public RotatingXState(PlatformStateMachine stateMachine) : base(stateMachine)
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
            stateMachine.SwitchState(new RotatingState(stateMachine));
        }

        stateMachine.transform.Rotate(
            Vector3.right, 5f * deltaTime);
    }

    public override void Exit()
    {

    }



}
