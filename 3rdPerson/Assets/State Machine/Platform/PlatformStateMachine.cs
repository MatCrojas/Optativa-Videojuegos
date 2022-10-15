using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformStateMachine : StateMachine
{

    [field: SerializeField] public PlatformInputReading InputReader { private set; get; }

    private void Start()
    {
        SwitchState(new RotatingState(this));
    }

}
