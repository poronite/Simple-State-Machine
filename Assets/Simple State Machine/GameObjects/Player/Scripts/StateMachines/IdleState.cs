using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    [SerializeField]
    private MoveState moveState;

    public override void EnterState()
    {
        
    }

    public override State UpdateState()
    {
        Vector2 input;

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        if (input != Vector2.zero)
        {
            if (input.x != 0) input.y = 0;

            moveState.StoreMovementDirection(input);

            return moveState;
        }
        else
        {
            return this;
        }
    }

    public override void ExitState()
    {
        
    }
}
