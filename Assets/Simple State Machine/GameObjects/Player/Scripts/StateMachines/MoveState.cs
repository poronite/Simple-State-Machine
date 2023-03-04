using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleStateMachine;

public class MoveState : State
{
    [SerializeField]
    private IdleState idleState;

    [SerializeField]
    private Transform player;

    [SerializeField]
    private float moveSpeed;

    private Vector2 moveDirection;

    private Coroutine movePlayerCoroutine;

    public override void EnterState()
    {
        movePlayerCoroutine = StartCoroutine(MovePlayer(moveDirection));        
    }

    public override State UpdateState()
    {
        if (movePlayerCoroutine != null)
        {
            return this;
        }
        else
        {
            return idleState;
        }
    }

    public override void ExitState()
    {
        
    }

    public IEnumerator MovePlayer(Vector2 direction)
    {
        Vector2 currentPosition = player.position;

        Vector2 targetPosition = currentPosition + direction;

        while ((targetPosition - currentPosition).sqrMagnitude > Mathf.Epsilon)
        {
            currentPosition = Vector2.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);

            player.position = currentPosition;

            yield return null;
        }

        player.position = targetPosition;

        movePlayerCoroutine = null;
    }

    public void StoreMovementDirection(Vector2 direction)
    {
        moveDirection = direction;
    }
}
