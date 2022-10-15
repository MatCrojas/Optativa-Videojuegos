using UnityEngine;
using UnityEngine.InputSystem;

public abstract class PlayerBaseState : State
{
    
    protected PlayerStateMachine stateMachine;

    void start()
    {
        
    }

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

   

}
