using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MovementState : PlatformBaseState
{
    public float timer = 5f;

    public MovementState(PlatformStateMachine stateMachine) : base(stateMachine)
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
            stateMachine.SwitchState(new RotatingXState(stateMachine));
        }

        stateMachine.transform.Translate(
    Vector3.up * 5f * deltaTime);

    }

    public override void Exit()
    {

    }
}
